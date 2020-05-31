using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing__Machine
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();         
            Application.SetCompatibleTextRenderingDefault(false);
            menu = new MainMenu();
            Application.Run(menu);
        }

        public static MainMenu menu;
    }
}
