#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
using Battleship.Core;
using System.Windows.Forms;
#endregion

namespace Battleship.Gui
{

	public partial class MainForm : KryptonForm
	{
		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			setAndStartMediaPlayer();
		}

		#region Method Definition
		private void setAndStartMediaPlayer()
		{
			mediaPlayer.URL = @"BattleShipAnthem.mp3";
			mediaPlayer.Ctlcontrols.play();
			mediaPlayer.settings.setMode("loop", true);
			mediaPlayer.settings.volume = 10;
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
			new SetPlayerForm(new GameManager()).Show();
		}
        #endregion

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.OpenForms[0].Show();
        }
    }

}