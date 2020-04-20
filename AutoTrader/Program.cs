using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxKHOpenAPILib;

namespace AutoTrader
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
            
            var mainView = new View.MainForm();
            var conditionView = new View.ConditionForm();
            var disclosureView = new View.DisclosureForm();
            var presenter = new Presenter.StockPresenter(mainView, conditionView, disclosureView);

            Application.Run(mainView);
        }
    }
}
