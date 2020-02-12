using Bases;

namespace Assembly
{
    class Atributes
    {
        FolderPattern folderPattern = new FolderPattern();
        string rootFolder, platform, serverLicense, release, previousRelease;
        Base mainBase, demoBase, emptyBase;
        string mainBaseName, demoBaseName, emptyBaseName;
        string nameDemoForUpload, nameMainForUpload, prefix, folderForTest;

        public string RootFolder { get { return rootFolder; } set { rootFolder = value; } } // Путь до сборки.
        public string Platform { get { return platform; } set { platform = value; } } // Путь до платформы 1С.
        public string ServerLicense { get { return serverLicense; } set { serverLicense = value; } } // Сервер лицензий. Текствое поле для информации.
        public string Release { get { return release; } set { release = value; } } // Релиз сборки.
        public string PreviousRelease { get { return previousRelease; } set { previousRelease = value; } } // Предыдущие релизы, с которых осуществляется сборка.
        public Base MainBase { get { return mainBase; } set { mainBase = value; } } // Основная база сборки.
        public Base DemoBase { get { return demoBase; } set { demoBase = value; } } // Демонстрационная база сборки.
        public Base EmptyBase { get { return emptyBase; } set { emptyBase = value; } } // Пустая база сборки.
        public string NameDemoForUpload { get { return nameDemoForUpload; } set { nameDemoForUpload = value; } } // Имя демо базы, которую планируется загрузить.
        public string NameMainForUpload { get { return nameMainForUpload; } set { nameMainForUpload = value; } } // Имя основной базы, которую планируется загрузить.
        public FolderPattern Pattern { get { return folderPattern; } set { folderPattern = value; } } // Шаблон имен папок сборки.
        public string Prefix { get { return prefix; } set { prefix = value; } } // Префикс сборки, для имени папки результата.
        public string FolderForTest { get { return folderForTest; } set { folderForTest = value; } } // Папка куда копируем результат всей сборки.

        public Atributes(string name)
        {
            switch (name)
            {
                case "for test":
                    folderPattern = new FolderPattern(name);
                    mainBase = new Base("сборка_основная_бп");
                    demoBase = new Base("сборка_демо_бп");
                    emptyBase = new Base("сборка_пустая_бп");
                    platform = @"C:\Program Files\1cv8\8.3.10.2650\bin\1cv8.exe";
                    rootFolder = @"D:\Сборки\testBp";
                    release = "3.0.54.20_3.1.34.9";
                    previousRelease = "3.0.53.38_3.1.34.6,3.0.54.15_3.1.34.8";
                    nameDemoForUpload = "демо.dt";
                    nameMainForUpload = "обнов.dt";
                    serverLicense = "1.6.5.171";
                    prefix = "_";
                    folderForTest = @"D:\Сборки\Тестирование";
                    break;
                default:
                    platform = @"C:\Program Files\1cv8\8.3.10.2650\bin\1cv8.exe";
                    rootFolder = @"D:\Сборки\test";
                    release = "3.0.54.20_3.1.34.9";
                    previousRelease = "3.0.54.15_3.1.34.8,3.0.53.38_3.1.34.6";
                    nameDemoForUpload = "demo.dt";
                    nameMainForUpload = "obnov.dt";
                    serverLicense = "1.6.5.171";
                    prefix = "_";
                    folderForTest = @"D:\Сборки\Тестирование";
                    mainBaseName = "";
                    demoBaseName = "";
                    emptyBaseName = "";
                    break;
            }
        }

        public string ContentForSettings()
        {
            string str = $"platform={Platform}\n" +
                          $"rootFolder={RootFolder}\n" +
                          $"release={Release}\n" +
                          $"previousRelease={PreviousRelease}\n" +
                          $"nameDemoForUpload={NameDemoForUpload}\n" +
                          $"nameMainForUpload={NameMainForUpload}\n" +
                          $"serverLicense={ServerLicense}\n" +
                          $"prefix={Prefix}\n" +
                          $"folderForTest={FolderForTest}\n" +
                          $"mainBaseName={mainBaseName}\n" +
                          $"demoBaseName={demoBaseName}\n" +
                          $"emptyBaseName={emptyBaseName}\n";
            return str;
        }
    }
}
