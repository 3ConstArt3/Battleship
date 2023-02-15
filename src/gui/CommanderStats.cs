#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battleship.Core;
using Battleship.Gui;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship.src.gui
{

	public partial class CommanderStatsForm : KryptonForm
	{
		private GameManager gameManager;
		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public CommanderStatsForm(GameManager gameManager)
		{
			InitializeComponent();

			this.gameManager = gameManager;
            setLabelVals();
			saveGameData();
		}

		private void saveGameData()
		{
			DatabaseManager database = new DatabaseManager();
			database.AddGameData(
				gameManager.GameState.GetPlayerName(true),
				gameManager.GameState.GetPlayerName(false),
				gameManager.GameState.IsPlayer1Winner(),
				gameManager.GameState.GetGameDuration()
			);
		}

		private void setLabelVals()
		{
			AttemptsLbl.Text += $" {gameManager.GameState.GetPlayerAttempts(true)}";
			WarDurationLbl.Text += $" {gameManager.GameState.GetGameDuration().TotalSeconds.ToString().Substring(0, 4)}";
			WarsWonLbl.Text += $" {Player.UserWins}";
			WarsLostLbl.Text += $" {Player.UserDefeats}";
		}

        private void NewBattleBtn_Click(object sender, EventArgs e)
        {
			string playerName = gameManager.GameState.GetPlayerName(true);
			gameManager.StartNewGame(playerName);
			new FleetDeploymentForm(gameManager).Show();
			Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void CommanderStatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.OpenForms[0].Show();
        }
    }

}