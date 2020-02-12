
namespace Bases
{
    /// <summary>
    /// Атрибуты базы.
    /// </summary>
    public struct BaseAtributes
    {
        public string baseFolder; //Путь к базе.Для серверной - путь к серверу(@"Server\BaseName"), для файловой - путь к базе(@"C:\Base")
        public string baseUser, repository, repositoryUser, repositoryPass;
        public bool serverBase, repositoryBase;
    }

    /// <summary>
    /// Описание баз, используемых в программе.
    /// Возможно переделать это во что-то другое. Например брать из БД
    /// </summary>
    public struct Base
    {
        public static BaseAtributes TestBase()
        {
            BaseAtributes TestBase = new BaseAtributes
            {
                serverBase = false,
                baseFolder = @"D:\Сборки\тест\Bases\TestBase",
                baseUser = "Агличев В.В. (БИТ.ФИНАНС)",
            };
            return TestBase;
        }

        public static BaseAtributes ServerBase()
        {
            BaseAtributes TestBase = new BaseAtributes
            {
                serverBase = true,
                baseFolder = @"CO-PROJECT-55\test_Demo",
                baseUser = "Агличев В.В. (БИТ.ФИНАНС)",
            };
            return TestBase;
        }

        public static BaseAtributes Comrades()
        {
            BaseAtributes TestBase = new BaseAtributes
            {
                serverBase = true,
                baseFolder = @"CO-PROJECT-55\comrades_main",
                baseUser = "Агличев В.В. (БИТ.ФИНАНС)",
                repository = @"\\pServer\Хранилище.БИТ.ФИНАНС\Хранилище_Standalone",
                repositoryUser = "IDotsenko",
            };
            return TestBase;
        }

    }
}
