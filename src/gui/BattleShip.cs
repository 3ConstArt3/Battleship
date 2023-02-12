#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
using Battleship.Core;
#endregion

namespace Battleship.Gui
{

	public partial class MainForm : KryptonForm
	{
		#region Variable Declarations
		private GameManager gameManager;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			gameManager = new GameManager();
			setAndStartMediaPlayer();
		}

		#region Method Definition
		private void setAndStartMediaPlayer()
		{
			mediaPlayer.URL = @"BattleShipAnthem.mp3";
			mediaPlayer.Ctlcontrols.play();
			mediaPlayer.settings.setMode("loop", true);
			mediaPlayer.settings.volume = 20;
			mediaPlayer.Visible = false;
		}

		/// <summary>
		/// Opens SetPlayerForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PreparationBtn_Click( object sender, EventArgs e )
		{
			this.Hide();
			new SetPlayerForm(gameManager).Show();
		}
		#endregion

	}

}