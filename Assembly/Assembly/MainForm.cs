using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using Assembly.Settings;

namespace Assembly
{
    public partial class MainForm : Form
    {
        delegate string GetContent(string key);
        delegate void FillSetting(string name, string value);

        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Assemblies != null)
                UpdateAssemblies(false);
            UpdateAllBasesCheckBox(false);
        }

        /// <summary>
        /// Событие начала сборки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGO_Click(object sender, EventArgs e)
        {
            SaveAllSettings();

            List<string> ci = new List<string>();
            foreach (var item in clbRoute.CheckedItems)
                ci.Add(item.ToString());

            string t = cbAssembly.Text;
            ThreadPool.QueueUserWorkItem(delegate { new NoticeForm(t, ci).ShowDialog(); });
        }

        /// <summary>
        /// Событие выбора сборки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAssembly_SelectedIndexChanged(object sender, EventArgs e)
        {
            string si = ((ComboBox)sender).SelectedItem.ToString();
            FillAllAssemblySettings(si);
        }

        /// <summary>
        /// Заполнить все настройки на форме по сборке.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        void FillAllAssemblySettings(string assemblyName)
        {
            clbRoute.Items.Clear();
            FillSettingOnTheForm(assemblyName, "Route", FillRoute);
            FillSettingOnTheForm(assemblyName, "Atributes", FillAtributes);
            FillSettingOnTheForm(assemblyName, "FolderPatterns", FillFolderPatterns);
        }

        /// <summary>
        /// Удалить все настройки по сборке.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        void RemoveAllAssemblySettings(string assemblyName)
        {
            RemoveCurrentSetting(assemblyName, "Route");
            RemoveCurrentSetting(assemblyName, "Atributes");
            RemoveCurrentSetting(assemblyName, "FolderPatterns");
        }

        /// <summary>
        /// Сохранить все настройки по сборке.
        /// </summary>
        void SaveAllSettings()
        {
            if (cbAssembly.Items.IndexOf(cbAssembly.Text)!=-1)
            {
                AddSetting(cbAssembly.Text, "Route", ContentForRoute);
                AddSetting(cbAssembly.Text, "Atributes", ContentForAtributes);
                AddSetting(cbAssembly.Text, "FolderPatterns", ContentForFolderPatterns);
            }
            else
            {
                AddSetting(cbAssembly.Text, "Route", ContentForRouteConstructor);
                AddSetting(cbAssembly.Text, "Atributes", ContentForAtributesConstructor);
                AddSetting(cbAssembly.Text, "FolderPatterns", ContentForFolderPatternsConstructor);
            }
        }

        /// <summary>
        /// Событие добавление сборки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAssembly_Click(object sender, EventArgs e)
        {
            AddAssembly(cbAssembly.Text);
            SaveAllSettings();
            FillAllAssemblySettings(cbAssembly.Text);
            UpdateAssemblies(false);
        }

        /// <summary>
        /// Событие удаление сборки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAssembly_Click(object sender, EventArgs e)
        {
            RemoveCurrentSetting(cbAssembly.Text, "Assemblies");
            RemoveAllAssemblySettings(cbAssembly.Text);
            UpdateAssemblies(true);
        }

        /// <summary>
        /// Событие добавление базы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBase_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbBase.Text))
            {
                AddSetting(cbBase.Text, "Bases", ContentForBase);
                UpdateAllBasesCheckBox(false);
            }
        }

        /// <summary>
        /// Событие удаление базы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBase_Click(object sender, EventArgs e)
        {
            RemoveCurrentSetting(cbBase.Text, "Bases");
            UpdateAllBasesCheckBox(true);
        }

        /// <summary>
        /// Событие изменение базы из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSettingOnTheForm(cbBase.Text, "Bases", FillBases);
        }

        /// <summary>
        /// Обновляет выпадающий список из сборок.
        /// </summary>
        /// <param name="clearField">Очищать текущее поле сборки.</param>
        void UpdateAssemblies(bool clearField)
        {
            if (clearField)
            {
                cbAssembly.Text = "";
            }
            cbAssembly.Items.Clear();
            foreach (var item in Properties.Settings.Default.Assemblies)
            {
                cbAssembly.Items.Add(item);
            }
        }

        /// <summary>
        /// Обновляет выпадающие списки баз.
        /// </summary>
        /// <param name="clearField">Очищать текущие поля баз.</param>
        void UpdateAllBasesCheckBox(bool clearField)
        {
            if (clearField)
            {
                cbBase.Text = "";
                cbMainBase.Text = "";
                cbDemoBase.Text = "";
                cbEmptyBase.Text = "";
            }
            cbBase.Items.Clear();
            cbMainBase.Items.Clear();
            cbDemoBase.Items.Clear();
            cbEmptyBase.Items.Clear();
            if (Properties.Settings.Default.Bases != null)
            {
                foreach (var item in Properties.Settings.Default.Bases)
                {
                    string baseName = item.Split('#')[0];
                    cbBase.Items.Add(baseName);
                    cbMainBase.Items.Add(baseName);
                    cbDemoBase.Items.Add(baseName);
                    cbEmptyBase.Items.Add(baseName);
                }
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRoute.Items.Count; i++)
            {
                clbRoute.SetItemChecked(i, true);
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRoute.Items.Count; i++)
            {
                clbRoute.SetItemChecked(i, false);
            }
        }

        #region Settings

        /// <summary>
        /// Добавить настройку по ключу.
        /// </summary>
        /// <param name="key">Ключ настройки.</param>
        /// <param name="settingName">Имя настройки</param>
        /// <param name="del">Делегат</param>
        void AddSetting(string key, string settingName, GetContent del)
        {
            UserSettings userSettings = new UserSettings
            {
                name = settingName,
                key = key,
                content = del.Invoke(key)
            };
            userSettings.SaveSetting();
        }

        /// <summary>
        /// Удалить текущую настройку по ключу.
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="settingName">Имя настройки</param>
        void RemoveCurrentSetting(string key, string settingName)
        {
            UserSettings userSettings = new UserSettings
            {
                name = settingName,
                key = key
            };
            int index = userSettings.FindCurrentSetting();
            userSettings.RemoveSetting(index);
        }

        /// <summary>
        /// Заполнить поля из настройки на форме.
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="settingName">Имя настройки</param>
        /// <param name="del">Делегат</param>
        void FillSettingOnTheForm(string key, string settingName, FillSetting del)
        {
            UserSettings userSettings = new UserSettings
            {
                name = settingName,
                key = key
            };

            foreach (var item in userSettings.GetContent().Split('\n'))
            {
                if (string.IsNullOrEmpty(item)) continue;

                string[] a = item.Split('=');
                string name = a[0];
                string value = a[1];

                del.Invoke(name, value);
            }
        }

        #endregion

        #region AssembliesSettings

        /// <summary>
        /// Добавить сборку.
        /// </summary>
        /// <param name="assemblyName"></param>
        void AddAssembly(string assemblyName)
        {
            UserSettings userSettings = new UserSettings
            {
                name = "Assemblies",
                key = assemblyName,
                addOnlyKey = true
            };
            userSettings.SaveSetting();
        }

        #endregion

        #region RouteSettings
        
        /// <summary>
        /// Заполнение в настройке маршрута по-умолчанию.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns></returns>
        string ContentForRouteConstructor(string assemblyName)
        {
            return new Route(assemblyName).ContentForSettings();
        }

        /// <summary>
        /// Заполнение в настройке маршрута из формы. 
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns></returns>
        string ContentForRoute(string assemblyName)
        {
            string str = string.Empty;
            for (int i = 0; i < clbRoute.Items.Count; i++)
            {
                str += $"{clbRoute.Items[i]}={clbRoute.GetItemChecked(i)}\n";
            }
            return str;
        }

        /// <summary>
        /// Заполнить маршрут на форме.
        /// </summary>
        /// <param name="name">Имя поля</param>
        /// <param name="value">Значение</param>
        void FillRoute(string name, string value)
        {
            clbRoute.Items.Add(name, bool.Parse(value));
        }

        #endregion

        #region AtributesSettings

        /// <summary>
        /// Заполнение в настройке атрибутов по-умолчанию.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns></returns>
        string ContentForAtributesConstructor(string assemblyName)
        {
            return new Atributes(assemblyName).ContentForSettings();
        }

        /// <summary>
        /// Заполнение в настройке атрибутов из формы.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns></returns>
        string ContentForAtributes(string assemblyName)
        {
            string previousRelease = string.Empty;
            foreach (var pr in tbPreviousRelease.Text.Split(','))
                previousRelease += pr.Trim() + ',';

            return $"platform={tbPlatform.Text}\n" +
                    $"rootFolder={tbRootFolder.Text}\n" +
                    $"release={tbRelease.Text}\n" +
                    $"previousRelease={previousRelease.Remove(previousRelease.Length - 1)}\n" +
                    $"nameDemoForUpload={tbNameDemoForUpload.Text}\n" +
                    $"nameMainForUpload={tbNameMainForUpload.Text}\n" +
                    $"serverLicense={tbServerLicense.Text}\n" +
                    $"prefix={tbPrefix.Text}\n" +
                    $"folderForTest={tbFolderForTest.Text}\n" +
                    $"mainBaseName={cbMainBase.Text}\n" +
                    $"demoBaseName={cbDemoBase.Text}\n" +
                    $"emptyBaseName={cbEmptyBase.Text}\n";
        }

        /// <summary>
        /// Заполнить атрибуты на форме.
        /// </summary>
        /// <param name="name">Имя поля</param>
        /// <param name="value">Значение</param>
        void FillAtributes(string name, string value)
        {
            switch (name)
            {
                case "platform":
                    tbPlatform.Text = value;
                    break;
                case "rootFolder":
                    tbRootFolder.Text = value;
                    break;
                case "release":
                    tbRelease.Text = value;
                    break;
                case "previousRelease":
                    tbPreviousRelease.Text = value;
                    break;
                case "nameDemoForUpload":
                    tbNameDemoForUpload.Text = value;
                    break;
                case "nameMainForUpload":
                    tbNameMainForUpload.Text = value;
                    break;
                case "serverLicense":
                    tbServerLicense.Text = value;
                    break;
                case "prefix":
                    tbPrefix.Text = value;
                    break;
                case "folderForTest":
                    tbFolderForTest.Text = value;
                    break;
                case "mainBaseName":
                    cbMainBase.Text = value;
                    break;
                case "demoBaseName":
                    cbDemoBase.Text = value;
                    break;
                case "emptyBaseName":
                    cbEmptyBase.Text = value;
                    break;
            }
        }

        #endregion

        #region BasesSettings

        /// <summary>
        /// Заполнение в настройке базы из формы.
        /// </summary>
        /// <param name="key">Для универсальности. Не используется.</param>
        /// <returns></returns>
        string ContentForBase(string key)
        {
            return $"serverBase={cbServerBase.Checked.ToString()}\n" +
                   $"baseFolder={tbBaseFolder.Text}\n" +
                   $"baseUser={tbBaseUser.Text}\n" +
                   $"repositoryBase={cbRepositoryBase.Checked.ToString()}\n" +
                   $"repository={tbRepository.Text}\n" +
                   $"repositoryUser={tbRepositoryUser.Text}\n" +
                   $"repositoryPass={tbRepositoryPass.Text}\n";
        }

        /// <summary>
        /// Заполнить поля базы на форме.
        /// </summary>
        /// <param name="name">Имя поля</param>
        /// <param name="value">Значение</param>
        void FillBases(string name, string value)
        {
            switch (name)
            {
                case "serverBase":
                    cbServerBase.Checked = Boolean.Parse(value);
                    break;
                case "baseFolder":
                    tbBaseFolder.Text = value;
                    break;
                case "baseUser":
                    tbBaseUser.Text = value;
                    break;
                case "repositoryBase":
                    cbRepositoryBase.Checked = Boolean.Parse(value);
                    break;
                case "repository":
                    tbRepository.Text = value;
                    break;
                case "repositoryUser":
                    tbRepositoryUser.Text = value;
                    break;
                case "repositoryPass":
                    tbRepositoryPass.Text = value;
                    break;
            }
        }

        #endregion

        #region FolderPatternsSettings

        /// <summary>
        /// Заполнение в настройке шаблонов по-умолчанию.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns></returns>
        string ContentForFolderPatternsConstructor(string assemblyName)
        {
            return new FolderPattern(assemblyName).ContentForSettings();
        }

        /// <summary>
        /// Заполнение в настройке шаблонов из формы.
        /// </summary>
        /// <param name="assemblyName">Имя сборки</param>
        /// <returns></returns>
        string ContentForFolderPatterns(string assemblyName)
        {
            return $"archive={tbArchive.Text}\n" +
                   $"package={tbPackage.Text}\n" +
                   $"result={tbResult.Text}\n" +
                   $"resultUpdate={tbResultUpdate.Text}\n" +
                   $"resultFull={tbResultFull.Text}\n" +
                   $"delivery={tbDelivery.Text}\n" +
                   $"patterns={tbPatterns.Text}\n" +
                   $"patternUpdate={tbPatternUpdate.Text}\n" +
                   $"patternFull={tbPatternFull.Text}\n";
        }

        /// <summary>
        /// Заполнить поля шаблонов на форме.
        /// </summary>
        /// <param name="name">Имя поля</param>
        /// <param name="value">Значение</param>
        void FillFolderPatterns(string name, string value)
        {
            switch (name)
            {
                case "archive":
                    tbArchive.Text = value;
                    break;
                case "package":
                    tbPackage.Text = value;
                    break;
                case "result":
                    tbResult.Text = value;
                    break;
                case "resultUpdate":
                    tbResultUpdate.Text = value;
                    break;
                case "resultFull":
                    tbResultFull.Text = value;
                    break;
                case "delivery":
                    tbDelivery.Text = value;
                    break;
                case "patterns":
                    tbPatterns.Text = value;
                    break;
                case "patternUpdate":
                    tbPatternUpdate.Text = value;
                    break;
                case "patternFull":
                    tbPatternFull.Text = value;
                    break;
            }
        }

        #endregion

    }
}
