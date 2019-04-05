using PowerGrid.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerGrid
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Index index = new Index();
            Application.Run(index);
            //判断是否返回父窗体的
            //if (index.getJumpToMainForm() == true)
            //{
            //在线程中打开主窗体
            //     Application.Run(new MainForm());
            // }

        }
    } 
}