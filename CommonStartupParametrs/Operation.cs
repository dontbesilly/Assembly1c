using System;
using System.Diagnostics;
using Bases;

namespace CommonStartupParametrs
{
    public class Operation
    {
        /// <summary>
        /// Выполняет команду 1С.
        /// </summary>
        /// <param name="arguments">Команда 1С, которую необходимо выполнить</param>
        /// <param name="programExe">Версия платформы</param>
        /// <returns>Ошибка</returns>
        public static Exception StartProcess(string arguments, string programExe)
        {
            Exception err = new Exception();
            try { Process.Start(programExe, arguments).WaitForExit(); }
            catch (Exception e)
            {
                err = e;
            }
            return err;
        }

        /// <summary>
        /// Серверная или файловая база
        /// </summary>
        /// <param name="server">true or false</param>
        /// <returns>Строка</returns>
        static string ServerFile(bool server)
        {
            string arg = server == true ? "/S" : "/F";
            return arg;
        }

        /// <summary>
        /// Загружает базу с диска в базу 1С
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="rootFolder">Каталог, где лежит база</param>
        /// <param name="loadBaseName">Имя загружаемого файла ИБ</param>
        /// <returns>Ошибка</returns>
        public static Exception RestoreBase(Base baseAtributes, string platformVersion, string rootFolder, string loadBaseName)
        {
            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /RestoreIB {rootFolder}\\{loadBaseName} /UpdateDBCfg";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Загружает файл конфигурации в базу 1С
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="rootFolder">Каталог, где лежит база</param>
        /// <param name="configurationName">Имя загружаемого файла конфигурации</param>
        /// <returns>Ошибка</returns>
        public static Exception RestoreConfiguration(Base baseAtributes, string platformVersion, string rootFolder, string configurationName)
        {
            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /LoadCfg {rootFolder}\\{configurationName} /UpdateDBCfg";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Обновляет базу из хранилища 1С.
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <returns>Ошибка</returns>
        public static Exception UpdateRepository(Base baseAtributes, string platformVersion)
        {
            // Если есть пароль, тогда подставляем. С пустым паролем /ConfigurationRepositoryP работать не будет. 
            string pass = baseAtributes.RepositoryPass == String.Empty ? "" : $" /ConfigurationRepositoryP {baseAtributes.RepositoryPass}";
            string updateCommand = $"/ConfigurationRepositoryUpdateCfg " +
                                    $"/ConfigurationRepositoryF {baseAtributes.Repository} " +
                                    $"/ConfigurationRepositoryN {baseAtributes.RepositoryUser}{pass} /UpdateDBCfg";

            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" {updateCommand}";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Открывает базу.
        /// </summary>
        /// <param name="baseAtributes"></param>
        /// <param name="platformVersion"></param>
        /// <returns>Ошибка</returns>
        public static Exception OpenBase(Base baseAtributes, string platformVersion, bool configuration)
        {
            string arg = configuration == true ? "DESIGNER" : "ENTERPRISE";
            string arguments =
                $"{arg} {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\"";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Выгружает базу .dt в каталог.
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="rootFolder">Каталог, куда выгружаем базу</param>
        /// <param name="unloadBaseName">Имя выгружаемого файла ИБ</param>
        /// <returns>Ошибка</returns>
        public static Exception DumpBase(Base baseAtributes, string platformVersion, string rootFolder, string unloadBaseName)
        {
            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /DumpIB {rootFolder}\\{unloadBaseName}";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Выгружает конфигурацию .cf в каталог.
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="rootFolder">Каталог, куда выгружаем конфигурацию</param>
        /// <param name="baseName">Имя выгружаемого файла конфигурации</param>
        /// <returns>Ошибка</returns>
        public static Exception DumpConfiguration(Base baseAtributes, string platformVersion, string rootFolder, string baseName)
        {
            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /DumpCfg {rootFolder}\\{baseName}";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Создает файл поставки.
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="folderWithCf">Путь до папки, где лежат папки с .cf разных релизов</param>
        /// <param name="release">Релиз</param>
        /// <param name="previousRelease">Предыдущие релизы, строка строго через запятую без пробелов</param>
        /// <returns>Ошибка</returns>
        public static Exception CreateUpdateFile(Base baseAtributes, string platformVersion, string folderWithCf, string release, string previousRelease)
        {
            // ТЕСТ
            string repository = String.Empty;
            if (baseAtributes.RepositoryBase)
            {
                // Если есть пароль, тогда подставляем. С пустым паролем /ConfigurationRepositoryP работать не будет. 
                string pass = baseAtributes.RepositoryPass == String.Empty ? "" : $" /ConfigurationRepositoryP {baseAtributes.RepositoryPass}";
                repository = $"/ConfigurationRepositoryF {baseAtributes.Repository} " +
                                        $"/ConfigurationRepositoryN {baseAtributes.RepositoryUser}{pass} /UpdateDBCfg";
            }
            // ТЕСТ

            string newCf = $"{folderWithCf}\\{release}\\1cv8.cf";
            string newCfu = newCf + "u";

            string[] arr = previousRelease.Split(',');
            string previousCf = "";
            foreach (var item in arr)
                previousCf += $"-f {folderWithCf}\\{item}\\1cv8.cf ";

            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" {repository} /CreateDistributionFiles -cffile " +
                $"{newCf} -cfufile {newCfu} {previousCf}";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Обновляет базу на поддержке новым файлом обновления.
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="folderWithCf">Путь до папки, где лежат папки с .cf разных релизов</param>
        /// <param name="release">Релиз</param>
        /// <returns>Ошибка</returns>
        public static Exception UpdateBaseWithDistributeFile(Base baseAtributes, string platformVersion, string folderWithCf, string release)
        {
            string newCf = $"{folderWithCf}\\{release}\\1cv8.cf";

            string arguments =
               $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /UpdateCfg {newCf} /UpdateDBCfg";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Создаёт сборку 1С из файла комплекта поставки .edf
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <param name="folderWithPackage">Путь до папки, где лежат файлы .edf</param>
        /// <param name="release">Текущий релиз сборки</param>
        /// <param name="folderForDistribution">Путь до папки, куда будет сделана сборка</param>
        /// <param name="full">Опция - делать полную сборку или только обновление</param>
        /// <returns>Ошибка</returns>
        public static Exception CreateDistribution(Base baseAtributes, string platformVersion, string folderWithPackage, string release, string folderForDistribution, bool full)
        {
            string option = full == true ? "Полный" : "Обновление";

            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /CreateDistributive " +
                $"{folderForDistribution} -File {folderWithPackage}\\КП_{release}.edf -Option {option}";

            return StartProcess(arguments, platformVersion);
        }

        /// <summary>
        /// Удаляет связь с хранилищем 1С.
        /// </summary>
        /// <param name="baseAtributes">Структура базы</param>
        /// <param name="platformVersion">Версия платформы 1С</param>
        /// <returns></returns>
        public static Exception UnbindBase(Base baseAtributes, string platformVersion)
        {
            string arguments =
                $"DESIGNER {ServerFile(baseAtributes.ServerBase)} {baseAtributes.BaseFolder} /N \"{baseAtributes.BaseUser}\" /ConfigurationRepositoryUnbindCfg -force";

            return StartProcess(arguments, platformVersion);
        }

    }
}
