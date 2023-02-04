// Necessary imports
using System;
using System.Windows.Forms;

namespace Battleship
{

    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        // Main function
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new Battlefield() );
        }

    }

}