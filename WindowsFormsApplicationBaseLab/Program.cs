using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationBaseLab
{
    //http://tlcheng.wordpress.com/2008/02/10/vb2005%E5%9C%A8-sub-main-%E7%9A%84-console-%E6%88%96-window-%E6%87%89%E7%94%A8%E7%A8%8B%E5%BC%8F%E9%99%90%E5%AE%9A%E7%82%BA%E5%96%AE%E4%B8%80%E5%9F%B7%E8%A1%8C%E5%80%8B%E9%AB%94%E6%87%89%E7%94%A8/
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyApp app = new MyApp();
            app.Run(args);
        }
    }

    public class MyApp : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public MyApp()
        {
            base.IsSingleInstance = true;
         
        }

        protected override void OnStartupNextInstance(Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs eventArgs)
        {
           
            base.OnStartupNextInstance(eventArgs);
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.BringToFront();
        }
        Form1 mainForm = null;
        protected override void OnRun()
        {
             mainForm = new Form1();
            Application.Run(mainForm);
          
        }
    }
}
