
using System.Collections.Generic;

namespace Bases
{
    /// <summary>
    /// Атрибуты базы.
    /// </summary>
    public abstract class BaseAtributes
    {
        protected string baseFolder; //Путь к базе.Для серверной - путь к серверу(@"Server\BaseName"), для файловой - путь к базе(@"C:\Base")
        protected string baseUser, repository, repositoryUser, repositoryPass;
        protected bool serverBase, repositoryBase;

        public string BaseFolder { get { return baseFolder; } set { baseFolder = value; } }
        public string BaseUser { get { return baseUser; } set { baseUser = value; } }
        public string Repository { get { return repository; } set { repository = value; } }
        public string RepositoryUser { get { return repositoryUser; } set { repositoryUser = value; } }
        public string RepositoryPass { get { return repositoryPass; } set { repositoryPass = value; } }
        public bool ServerBase { get { return serverBase; } set { serverBase = value; } }
        public bool RepositoryBase { get { return repositoryBase; } set { repositoryBase = value; } }
    }

    /// <summary>
    /// Описание баз, используемых в программе.
    /// Возможно переделать это во что-то другое. Например брать из БД
    /// </summary>
    public class Base : BaseAtributes
    {
        string name;
        Dictionary<string, Base> bases = new Dictionary<string, Base>();
        public string Name { get { return name; } }

        public Base this[string name]
        {
            get { return bases[name]; }
            set { bases[name] = value; }
        }

        public Base(string name)
        {
            this.name = name;
            FindBase(name);
            bases.Add(name, this);
        }

        public virtual void FindBase(string baseName)
        {
            switch (baseName)
            {
                case "сборка_основная_бп":
                    serverBase = false;
                    baseFolder = @"D:\Сборки\testBp\Базы\Основная";
                    baseUser = "Агличев В.В. (БИТ.ФИНАНС)";
                    repositoryBase = false;
                    repository = @"D:\Сборки\test\ХранилищеТест";
                    repositoryUser = "Агличев В.В. (БИТ.ФИНАНС)";
                    break;
                case "сборка_демо_бп":
                    serverBase = false;
                    baseFolder = @"D:\Сборки\testBp\Базы\Демонстрационная";
                    baseUser = "Агличев В.В. (БИТ.ФИНАНС)";
                    repositoryBase = false;
                    break;
                case "сборка_пустая_бп":
                    serverBase = false;
                    baseFolder = @"D:\Сборки\testBp\Базы\Пустая";
                    baseUser = "Администратор";
                    repositoryBase = false;
                    break;
                default:
                    serverBase = false;
                    baseFolder = "";
                    baseUser = "";
                    repositoryBase = false;
                    repository = "";
                    repositoryUser = "";
                    repositoryPass = "";
                    break;
            }
        }
    }
}
