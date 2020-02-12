
namespace Assembly
{
    /// <summary>
    /// Имена папок, относительно корневой папки сборки.
    /// </summary>
    struct FolderPattern
    {
        string archive, package, delivery, patterns, patternUpdate, patternFull;
        string result, resultUpdate, resultFull;

        public string Archive { get { return archive; } set { archive = value; } } // Имя папки архива с .cf
        public string Package { get { return package; } set { package = value; } } // Имя папки с файлами комплекта поставки
        public string Delivery { get { return delivery; } set { delivery = value; } } // Имя папки в которой хранятся промежуточные файлы поставки

        public string Result { get { return result; } set { result = value; } } // Имя папки с результатом
        public string ResultUpdate { get { return resultUpdate; } set { resultUpdate = value; } } // Имя папки с результатом поставки обновления
        public string ResultFull { get { return resultFull; } set { resultFull = value; } } // Имя папки с результатом полной поставки

        public string Patterns { get { return patterns; } set { patterns = value; } } // Имя папки в которой лежат шаблоны
        public string PatternUpdate { get { return patternUpdate; } set { patternUpdate = value; } } // Имя папки в которой лежат шаблоны
        public string PatternFull { get { return patternFull; } set { patternFull = value; } } // Имя папки в которой лежат шаблоны

        public FolderPattern(string name)
        {
            switch (name)
            {
                default:
                    archive = "Архив";
                    package = "КомплектПоставки";
                    result = "Результат";
                    resultUpdate = result + "\\Update_Finans";
                    resultFull = result + "\\CD_Finans";
                    delivery = "ФайлыПоставки";
                    patterns = "Шаблоны";
                    patternUpdate = patterns+"\\Шаблон_Обновление";
                    patternFull = patterns+"\\Шаблон_Полный";
                    break;
            }
        }

        public string ContentForSettings()
        {
            string str = $"archive={Archive}\n" +
                          $"package={Package}\n" +
                          $"result={Result}\n" +
                          $"resultUpdate={ResultUpdate}\n" +
                          $"resultFull={ResultFull}\n" +
                          $"delivery={Delivery}\n" +
                          $"patterns={Patterns}\n" +
                          $"patternUpdate={PatternUpdate}\n" +
                          $"patternFull={PatternFull}\n";
            return str;
        }

    }
}
