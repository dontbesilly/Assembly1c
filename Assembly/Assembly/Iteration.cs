using System;
using System.IO;
using System.Text;
using CommonStartupParametrs;
using System.Collections.Generic;

namespace Assembly
{
    /// <summary>
    /// Итерация сборки, сборочная единица.
    /// </summary>
    class Iteration
    {
        public static string[] iterationArray = 
            { "Загрузить демо базу",
            "Обновить основную базу",
            "Открыть основную базу конфигуратор",
            "Создать файлы обновления",
            "Обновить демо базу файлом обновления",
            "Обновить пустую базу файлом обновления",
            "Открыть демо базу предприятие",
            "Открыть демо базу конфигуратор",
            "Открыть пустую базу предприятие",
            "Открыть пустую базу конфигуратор",
            "Выгрузить демо базу",
            "Выгрузить пустую базу",
            "Скопировать файлы обновления",
            "Скопировать папки шаблонов в результат",
            "Создать текстовые файлы поставки из шаблонов",
            "Создать полный дистрибутив",
            "Создать дистрибутив обновления",
            "Создать .rar архивы сборки",
            "Скопировать содержимое в папку тестирования" };

        public Dictionary<string, Delegate> iterationColl = new Dictionary<string, Delegate>();

        bool LoadDemo = false;

        public Iteration(Atributes atributes)
        {
            foreach (var item in iterationArray)
            {
                switch (item)
                {
                    case "Загрузить демо базу":
                        iterationColl.Add(item, new Action(() => LoadDemoBase(atributes)));
                        break;
                    case "Обновить основную базу":
                        iterationColl.Add(item, new Action(() => UpdateMainBase(atributes)));
                        break;
                    case "Открыть основную базу конфигуратор":
                        iterationColl.Add(item, new Action(() => OpenMainBase(atributes)));
                        break;
                    case "Создать файлы обновления":
                        iterationColl.Add(item, new Action(() => CreateUpdateFile(atributes)));
                        break;
                    case "Обновить демо базу файлом обновления":
                        iterationColl.Add(item, new Action(() => UpdateDemoBaseDistrFile(atributes)));
                        break;
                    case "Обновить пустую базу файлом обновления":
                        iterationColl.Add(item, new Action(() => UpdateEmptyBaseDistrFile(atributes)));
                        break;
                    case "Открыть демо базу предприятие":
                        iterationColl.Add(item, new Action(() => OpenDemoBaseEnterprise(atributes)));
                        break;
                    case "Открыть пустую базу предприятие":
                        iterationColl.Add(item, new Action(() => OpenEmptyBaseEnterprise(atributes)));
                        break;
                    case "Открыть демо базу конфигуратор":
                        iterationColl.Add(item, new Action(() => OpenDemoBase(atributes)));
                        break;
                    case "Открыть пустую базу конфигуратор":
                        iterationColl.Add(item, new Action(() => OpenEmptyBase(atributes)));
                        break;
                    case "Выгрузить демо базу":
                        iterationColl.Add(item, new Action(() => DumpDemoBase(atributes)));
                        break;
                    case "Выгрузить пустую базу":
                        iterationColl.Add(item, new Action(() => DumpEmptyBase(atributes)));
                        break;
                    case "Скопировать файлы обновления":
                        iterationColl.Add(item, new Action(() => CopyingCF(atributes)));
                        break;
                    case "Скопировать папки шаблонов в результат":
                        iterationColl.Add(item, new Action(() => CopyingTemplate(atributes)));
                        break;
                    case "Создать текстовые файлы поставки из шаблонов":
                        iterationColl.Add(item, new Action(() => ReplaceContent(atributes)));
                        break;
                    case "Создать полный дистрибутив":
                        iterationColl.Add(item, new Action(() => CreateFullDistributive(atributes)));
                        break;
                    case "Создать дистрибутив обновления":
                        iterationColl.Add(item, new Action(() => CreateUpdateDistributive(atributes)));
                        break;
                    case "Создать .rar архивы сборки":
                        iterationColl.Add(item, new Action(() => CreateRar(atributes)));
                        break;
                    case "Скопировать содержимое в папку тестирования":
                        iterationColl.Add(item, new Action(() => CopyingToTest(atributes)));
                        break;
                }
            }
        }

        public void LoadDemoBase(Atributes atributes)
        {
            Operation.RestoreBase(atributes.DemoBase, atributes.Platform, atributes.RootFolder, atributes.NameDemoForUpload);
            Operation.UnbindBase(atributes.DemoBase, atributes.Platform);
            LoadDemo = true;
        }

        public void UpdateMainBase(Atributes atributes)
        {
            if (atributes.MainBase.RepositoryBase)
            {
                Operation.UpdateRepository(atributes.MainBase, atributes.Platform);
            }
            else
            {
                Operation.RestoreBase(atributes.MainBase, atributes.Platform, atributes.RootFolder, atributes.NameMainForUpload);
                Operation.UnbindBase(atributes.MainBase, atributes.Platform);
            }
        }

        public void OpenMainBase(Atributes atributes)
        {
            Operation.OpenBase(atributes.MainBase, atributes.Platform, true);
        }

        public void CreateUpdateFile(Atributes atributes)
        {
            Operation.CreateUpdateFile(atributes.MainBase, 
                                        atributes.Platform,
                                        $"{atributes.RootFolder}\\{atributes.Pattern.Archive}",
                                        atributes.Release,
                                        atributes.PreviousRelease);
        }

        public void UpdateDemoBaseDistrFile(Atributes atributes)
        {
            if (LoadDemo)
            {
                Operation.RestoreConfiguration(atributes.DemoBase,
                                            atributes.Platform,
                                            $"{atributes.RootFolder}\\{atributes.Pattern.Archive}\\{atributes.Release}",
                                            "1cv8.cf");
            }
            else
            {
                Operation.UpdateBaseWithDistributeFile(atributes.DemoBase,
                                            atributes.Platform,
                                            $"{atributes.RootFolder}\\{atributes.Pattern.Archive}",
                                            atributes.Release);
            }
        }

        public void UpdateEmptyBaseDistrFile(Atributes atributes)
        {
            Operation.UpdateBaseWithDistributeFile(atributes.EmptyBase,
                                        atributes.Platform,
                                        $"{atributes.RootFolder}\\{atributes.Pattern.Archive}",
                                        atributes.Release);
        }

        public void OpenDemoBase(Atributes atributes)
        {
            Operation.OpenBase(atributes.DemoBase, atributes.Platform, true);
        }

        public void OpenEmptyBase(Atributes atributes)
        {
            Operation.OpenBase(atributes.EmptyBase, atributes.Platform, true);
        }

        public void OpenDemoBaseEnterprise(Atributes atributes)
        {
            Operation.OpenBase(atributes.DemoBase, atributes.Platform, false);
        }

        public void OpenEmptyBaseEnterprise(Atributes atributes)
        {
            Operation.OpenBase(atributes.EmptyBase, atributes.Platform, false);
        }

        public void DumpDemoBase(Atributes atributes)
        {
            Operation.DumpBase(atributes.DemoBase, 
                                atributes.Platform, 
                                $"{atributes.RootFolder}\\{atributes.Pattern.Delivery}",
                                "1cv8.dt");
        }

        public void DumpEmptyBase(Atributes atributes)
        {
            Operation.DumpBase(atributes.EmptyBase,
                                atributes.Platform,
                                $"{atributes.RootFolder}\\{atributes.Pattern.Delivery}",
                                "1cv8New.dt");
        }

        /// <summary>
        /// Копирует файлы конфигурации поставки из одного места в другое.
        /// </summary>
        /// <param name="rootFolder"></param>
        /// <param name="release"></param>
        public void CopyingCF(Atributes atributes)
        {
            try
            {
                File.Copy(
                    $@"{atributes.RootFolder}\{atributes.Pattern.Archive}\{atributes.Release}\1cv8.cf",
                    $@"{atributes.RootFolder}\{atributes.Pattern.Delivery}\1cv8.cf",
                    true);
                File.Copy(
                    $@"{atributes.RootFolder}\{atributes.Pattern.Archive}\{atributes.Release}\1cv8.cfu",
                    $@"{atributes.RootFolder}\{atributes.Pattern.Delivery}\1cv8.cfu",
                    true);
            }
            catch { }
        }

        /// <summary>
        /// Копирует каталоги и файлы шаблонов в сборку.
        /// </summary>
        /// <param name="baseFolder"></param>
        /// <param name="directoryCD"></param>
        /// <param name="directoryUpdate"></param>
        public void CopyingTemplate(Atributes atributes)
        {
            string pathFull = $"{atributes.RootFolder}\\{atributes.Pattern.ResultFull}{atributes.Prefix}{atributes.Release}";
            CopyingDirectory($"{atributes.RootFolder}\\{atributes.Pattern.PatternFull}", pathFull);

            string pathUpdate = $"{atributes.RootFolder}\\{atributes.Pattern.ResultUpdate}{atributes.Prefix}{atributes.Release}";
            CopyingDirectory($"{atributes.RootFolder}\\{atributes.Pattern.PatternUpdate}", pathUpdate);
        }

        /// <summary>
        /// Копирует все файлы из одной папки в другую. Вызывается рекурсивно.
        /// </summary>
        /// <param name="DirTemplate"></param>
        /// <param name="DirDestination"></param>
        void CopyingDirectory(string DirTemplate, string DirDestination)
        {
            try { new DirectoryInfo(DirDestination).Create(); }
            catch { }

            foreach (FileInfo file in new DirectoryInfo(DirTemplate).GetFiles())
            {
                try { File.Copy(file.FullName, $@"{DirDestination}\{file.Name}", true); }
                catch { }
            }
            foreach (var item in new DirectoryInfo(DirTemplate).GetDirectories())
            {
                try { new DirectoryInfo(DirDestination + '\\' + item.Name).Create(); }
                catch { }
                CopyingDirectory(DirTemplate + '\\' + item.Name, DirDestination + '\\' + item.Name);
            }
        }

        /// <summary>
        /// Заменяет содержимое файлов шаблонов и создает текстовые файлы поставки.
        /// </summary>
        /// <param name="atributes"></param>
        public void ReplaceContent(Atributes atributes)
        {
            string templateFolder = $"{atributes.RootFolder}\\{atributes.Pattern.Patterns}";
            string packageFolder = $"{atributes.RootFolder}\\{atributes.Pattern.Package}";
            string deliveryFolder = $"{atributes.RootFolder}\\{atributes.Pattern.Delivery}";

            string platform = atributes.Platform.Split('\\')[3];
            string releaseSlash = atributes.Release.Replace("_", "/");
            string previousReleaseSlash = atributes.PreviousRelease.Replace("_", "/");
            string[] releaseArr = atributes.Release.Split('_');
            string releaseMain = releaseArr[0];
            string releaseOur = releaseArr[1];
            
            string readmeTemp = "";
            string[] tempArray = Directory.GetFiles(templateFolder);
            foreach (string name in tempArray)
            {                
                string str = string.Empty;
                using (StreamReader reader = new StreamReader(name, Encoding.Default))
                {
                    str = reader.ReadToEnd();
                }
                str = str.Replace("%deliveryFolder%", deliveryFolder);
                str = str.Replace("%releaseL%", releaseSlash);
                str = str.Replace("%release_%", atributes.Release);
                str = str.Replace("%releaseMain%", releaseMain);
                str = str.Replace("%releaseOur%", releaseOur);
                str = str.Replace("%versSL%", atributes.ServerLicense);
                str = str.Replace("%versPlat%", platform);
                str = str.Replace("%previousReleaseL%", previousReleaseSlash);
                str = str.Replace("%Date%", DateTime.Now.ToShortDateString());
                
                string copyFolder = string.Empty;
                Encoding encoding = Encoding.Default;
                if (name.ToLower().Contains("кп_шаблон.edf"))
                {
                    copyFolder = $@"{packageFolder}\КП_{atributes.Release}.edf";
                    encoding = Encoding.Unicode;
                }
                else if (name.ToLower().Contains("1cv8upd_шаблон.htm"))
                {
                    copyFolder = $@"{deliveryFolder}\1cv8upd.htm";
                    encoding = Encoding.Unicode;
                }
                else if (name.ToLower().Contains("updinfo_шаблон.txt"))
                {
                    copyFolder = $@"{deliveryFolder}\UpdInfo.txt";
                }
                else if (name.ToLower().Contains("readme_изменения.txt"))
                {
                    readmeTemp = str;
                }
                
                if (copyFolder != string.Empty)
                {
                    using (StreamWriter file = new StreamWriter(copyFolder, false, encoding))
                    {
                        file.Write(str);
                    }
                }
            }

            string tempstr = string.Empty;
            using (StreamReader reader = new StreamReader($"{templateFolder}\\readme_шаблон.txt", Encoding.Default))
            {
                tempstr = readmeTemp + reader.ReadToEnd();
            }
            using (StreamWriter file = new StreamWriter($"{templateFolder}\\readme_шаблон.txt", false, Encoding.Default))
            {
                file.Write(tempstr);
            }

            string newstr = string.Empty;
            using (StreamReader reader = new StreamReader($"{templateFolder}\\readme_шапка.txt", Encoding.Default))
            {
                newstr = reader.ReadToEnd();
            }
            using (StreamWriter file = new StreamWriter($@"{deliveryFolder}\ReadMe.txt", false, Encoding.Default))
            {
                file.Write(newstr + tempstr);
            }
            using (StreamWriter file = new StreamWriter($"{atributes.RootFolder}\\{atributes.Pattern.ResultFull}{atributes.Prefix}{atributes.Release}\\ReadMe.txt", false, Encoding.Default))
            {
                file.Write(newstr + readmeTemp);
            }
            using (StreamWriter file = new StreamWriter($"{atributes.RootFolder}\\{atributes.Pattern.ResultUpdate}{atributes.Prefix}{atributes.Release}\\ReadMe.txt", false, Encoding.Default))
            {
                file.Write(newstr + readmeTemp);
            }
        }

        public void CreateFullDistributive(Atributes atributes)
        {
            Operation.CreateDistribution(atributes.EmptyBase,
                                        atributes.Platform,
                                        $"{atributes.RootFolder}\\{atributes.Pattern.Package}",
                                        atributes.Release,
                                        $"{atributes.RootFolder}\\{atributes.Pattern.ResultFull}{atributes.Prefix}{atributes.Release}",
                                        true);
        }

        public void CreateUpdateDistributive(Atributes atributes)
        {
            Operation.CreateDistribution(atributes.EmptyBase,
                                        atributes.Platform,
                                        $"{atributes.RootFolder}\\{atributes.Pattern.Package}",
                                        atributes.Release,
                                        $"{atributes.RootFolder}\\{atributes.Pattern.ResultUpdate}{atributes.Prefix}{atributes.Release}",
                                        false);
        }

        public void CreateRar(Atributes atributes)
        {
            string rar = @"C:\Program Files\WinRAR\WinRAR.exe";

            string nameRar = $"{atributes.RootFolder}\\{atributes.Pattern.ResultFull}{atributes.Prefix}{atributes.Release}";
            string arguments = $"a -afzip -ed -ep1 -r {nameRar}.zip {nameRar}";
            Operation.StartProcess(arguments, rar);

            nameRar = $"{atributes.RootFolder}\\{atributes.Pattern.ResultUpdate}{atributes.Prefix}{atributes.Release}";
            arguments = $"a -afzip -ed -ep1 -r {nameRar}.zip {nameRar}";
            Operation.StartProcess(arguments, rar);
        }

        public void CopyingToTest(Atributes atributes)
        {
            CopyingDirectory($"{atributes.RootFolder}\\{atributes.Pattern.Result}", 
                $"{atributes.FolderForTest}\\Результат{atributes.Prefix}{atributes.Release}");
        }
    }
}
