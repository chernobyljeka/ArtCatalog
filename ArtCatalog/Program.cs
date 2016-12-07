using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtCatalog
{
    static class Program
    {

        private static employee emp;
        private static bool input = true;
        public static bool Input
        {
            get { return input; }
            set { input = value;  }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            emp = new employee();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var login = new Login();
            login.ShowDialog();
            login.Dispose();

            if (input)
            Application.Run(new MainForm());
        }
    }
}
