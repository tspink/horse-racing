using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spink.HorseRacing
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main(string[] arguments)
        {
            // Instantiate the model and controller.
            var model = new Model.Model();
            var controller = new Controller.Controller(model);

            // Initialise the UI settings.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the main application form, and run the application.
            Application.Run(new MainForm(controller, model));

            // Return success.
            return 0;
        }
    }
}
