using System;
using Assembly.Settings;
using System.Collections.Generic;
using Bases;
using System.Threading;
using System.Collections.Specialized;
using System.Net;

namespace Assembly
{
    /// <summary>
    /// Сборка.
    /// </summary>
    class Assembly
    {
        string name;
        public List<string> checkedCollection;
        public string Name { get { return name; } }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя сборки.</param>
        /// <param name="checkedCollection">Коллекция нажатых элементов маршрута на форме.</param>
        public Assembly(string name, List<string> checkedCollection)
        {
            this.name = name;
            this.checkedCollection = checkedCollection;
        }

        /// <summary>
        /// Создать класс Atributes с данными из настроек.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns>Atributes</returns>
        public Atributes CreateAtributes(string assemblyName)
        {
            var setAtributes = new UserSettings { name = "Atributes", key = assemblyName };

            Atributes atributes = new Atributes("");
            atributes.Pattern = CreateFolderPattern(assemblyName);
            foreach (var item in setAtributes.GetContent().Split('\n'))
            {
                if (string.IsNullOrEmpty(item)) continue;

                string[] a = item.Split('=');
                string name = a[0];
                string value = a[1];

                switch (name)
                {
                    case "platform":
                        atributes.Platform = value;
                        break;
                    case "rootFolder":
                        atributes.RootFolder = value;
                        break;
                    case "release":
                        atributes.Release = value;
                        break;
                    case "previousRelease":
                        atributes.PreviousRelease = value;
                        break;
                    case "nameDemoForUpload":
                        atributes.NameDemoForUpload = value;
                        break;
                    case "nameMainForUpload":
                        atributes.NameMainForUpload = value;
                        break;
                    case "serverLicense":
                        atributes.ServerLicense = value;
                        break;
                    case "prefix":
                        atributes.Prefix = value;
                        break;
                    case "folderForTest":
                        atributes.FolderForTest = value;
                        break;
                    case "mainBaseName":
                        atributes.MainBase = CreateBase(value);
                        break;
                    case "demoBaseName":
                        atributes.DemoBase = CreateBase(value);
                        break;
                    case "emptyBaseName":
                        atributes.EmptyBase = CreateBase(value);
                        break;
                }
            }
            return atributes;
        }

        /// <summary>
        /// Создать класс Base для баз входящих в атрибуты сборки.
        /// </summary>
        /// <param name="baseName">Имя базы</param>
        /// <returns>Base</returns>
        public Base CreateBase(string baseName)
        {
            var setBase = new UserSettings { name = "Bases", key = baseName };

            Base newBase = new Base(baseName);

            foreach (var item in setBase.GetContent().Split('\n'))
            {
                if (string.IsNullOrEmpty(item)) continue;

                string[] a = item.Split('=');
                string name = a[0];
                string value = a[1];

                switch (name)
                {
                    case "serverBase":
                        newBase.ServerBase = Boolean.Parse(value);
                        break;
                    case "baseFolder":
                        newBase.BaseFolder = value;
                        break;
                    case "baseUser":
                        newBase.BaseUser = value;
                        break;
                    case "repositoryBase":
                        newBase.RepositoryBase = Boolean.Parse(value);
                        break;
                    case "repository":
                        newBase.Repository = value;
                        break;
                    case "repositoryUser":
                        newBase.RepositoryUser = value;
                        break;
                    case "repositoryPass":
                        newBase.RepositoryPass = value;
                        break;
                }
            }
            return newBase;
        }

        /// <summary>
        /// Создать класс FolderPattern для атрибутов сборки из настроек.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns>FolderPattern</returns>
        public FolderPattern CreateFolderPattern(string assemblyName)
        {
            var setFolderPatterns = new UserSettings { name = "FolderPatterns", key = assemblyName };

            FolderPattern fp = new FolderPattern();

            foreach (var item in setFolderPatterns.GetContent().Split('\n'))
            {
                if (string.IsNullOrEmpty(item)) continue;

                string[] a = item.Split('=');
                string name = a[0];
                string value = a[1];

                switch (name)
                {
                    case "archive":
                        fp.Archive = value;
                        break;
                    case "package":
                        fp.Package = value;
                        break;
                    case "result":
                        fp.Result = value;
                        break;
                    case "resultUpdate":
                        fp.ResultUpdate = value;
                        break;
                    case "resultFull":
                        fp.ResultFull = value;
                        break;
                    case "delivery":
                        fp.Delivery = value;
                        break;
                    case "patterns":
                        fp.Patterns = value;
                        break;
                    case "patternUpdate":
                        fp.PatternUpdate = value;
                        break;
                    case "patternFull":
                        fp.PatternFull = value;
                        break;
                }
            }
            return fp; 
        }
    }
}
