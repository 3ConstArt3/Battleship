﻿#region Imports
using System;
using System.Windows.Forms;
#endregion

namespace Battleship
{

    internal static class Program
    {

        /// <summary>
        /// Main function.
        /// </summary>
        [STAThread]

        // Main function
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new BattleShip() );
        }

    }

}