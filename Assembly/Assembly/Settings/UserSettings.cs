
using System.Collections.Specialized;

namespace Assembly.Settings
{
    class UserSettings
    {
        Properties.Settings settings = Properties.Settings.Default;
        public string name;
        public string key;
        public string content;
        public bool addOnlyKey = false;
        int index = -1;

        /// <summary>
        /// Сохраняет настройку.
        /// </summary>
        public int SaveSetting()
        {
            if (settings[name] == null)
            {
                AddSetting(new StringCollection());
                index = 0;
            }
            else
            {
                FindCurrentSetting();
                if (index != -1)
                {
                    RemoveSetting(index);
                }
                AddSetting((StringCollection)settings[name]);
            }
            return index;
        }
        
        /// <summary>
        /// Добавление настройки.
        /// </summary>
        /// <param name="collection">Коллекция</param>
        public void AddSetting(StringCollection collection)
        {
            StringCollection coll = collection;

            if (addOnlyKey)
                coll.Add(key);
            else
                coll.Add($"{key}#{content}");

            settings[name] = coll;
            settings.Save();
        }
        
        /// <summary>
        /// Находит необходимую настройку по ключу.
        /// </summary>
        public int FindCurrentSetting()
        {
            StringCollection coll = (StringCollection)settings[name];
            foreach (var item in coll)
            {
                if (item.Split('#')[0] == key)
                {
                    index = coll.IndexOf(item);
                    break;
                }
            }
            return index;
        }
        
        /// <summary>
        /// Удаляет настройку по индексу.
        /// </summary>
        /// <param name="index">Число</param>
        public void RemoveSetting(int index)
        {
            StringCollection coll = (StringCollection)settings[name];
            coll.RemoveAt(index);
            settings[name] = coll;
            settings.Save();
        }

        /// <summary>
        /// Получает контент по ключу.
        /// </summary>
        /// <returns>Строка настроек по ключу</returns>
        public string GetContent()
        {
            int index = FindCurrentSetting();
            StringCollection coll = (StringCollection)settings[name];
            return coll[index].Split('#')[1];
        }

    }
}
