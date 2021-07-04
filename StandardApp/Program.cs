using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace com.DaHuotu
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isStart = Properties.Settings.Default.appIsStart;
            string isStartTime = Properties.Settings.Default.appIsStartTime;

            if (isStart == true && isStartTime == DateTime.Now.ToShortDateString())
            {
                //今日已启动
                Application.Run(new App());
            }
            else
            {
                //今日未启动，写入时间和启动状态
                Properties.Settings.Default.appIsStart = true;
                Properties.Settings.Default.appIsStartTime = DateTime.Now.ToShortDateString();
                Properties.Settings.Default.Save();
                Application.Run(new Checking());
            }
        }
    }
}
