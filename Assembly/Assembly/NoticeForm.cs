using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Assembly
{
    public partial class NoticeForm : Form
    {
        public NoticeForm(string name, List<string> checkedCollection)
        {
            InitializeComponent();

            lblAssembly.Text = name;
            notifyIcon.BalloonTipTitle = $"Сборка {name}:";

            Assembly assembly = new Assembly(name, checkedCollection);
            ThreadPool.QueueUserWorkItem(delegate { StartAssembly(assembly); });
        }

        void StartAssembly(Assembly assembly)
        {
            Iteration iteration = new Iteration(assembly.CreateAtributes(assembly.Name));

            foreach (var item in assembly.checkedCollection)
            {
                ThreadPool.QueueUserWorkItem(delegate { ShowNotification(item); });
                iteration.iterationColl[item].DynamicInvoke();
            }
            ThreadPool.QueueUserWorkItem(delegate { ShowNotification("Сборка завершена!"); });
        }

        void ShowNotification(string text)
        {
            try
            {
                tbProtocol.Text += $"{DateTime.Now}: {text}" + Environment.NewLine;
                notifyIcon.BalloonTipText = text;
                notifyIcon.ShowBalloonTip(10);
            }
            catch { }
        }
    }

}
