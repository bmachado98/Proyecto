using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Formularios;



namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormInicio());
            Application.Run(new Login());*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            



            bool estaLog = Properties.Settings.Default.estalogueado;
            if (estaLog == true)
            {
                //this.Close();
                


                FormInicio main = new FormInicio();
                main.Show();
                Application.Run(); // quítale el parámetro aquí


            }
            else
            {


                Login main = new Login();
                main.Show();
                Application.Run(); // quítale el parámetro aquí

            }







            //Application.Run(new FomularioLogin());
        }
    }
}
