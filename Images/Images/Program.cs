using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
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
            IView View = new Form1();
            Model Model = new Model();

            FileSelectorPresenter PLeft = new FileSelectorPresenter(View.PanelLeft, Model);
            //Presenter PRight = new TCPresenter(View.PanelRight, Model);

            Presenter Presenter = new Presenter(View, Model);
            Application.Run((Form)View);
        }
    }
}
