#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
using Battleship.Core;
using System.Windows.Forms;
#endregion

namespace Battleship.Gui
{

	public partial class SetPlayerForm : KryptonForm
	{

		#region Variable Declarations
		private readonly GameManager gameManager;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public SetPlayerForm(GameManager gameManager)
		{
			InitializeComponent();
			this.gameManager = gameManager;
		}

		#region Function Definition
		/// <summary>
		/// Closes SetPlayerForm UI & invokes FleetDeploymentForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DelpoyFleetBtn_Click( object sender, EventArgs e )
		{
			// TODO: recycle the next two lines in their own method
			gameManager.StartNewGame(NameTxtBx.Text);
			Player.ResetUserStats();
			new FleetDeploymentForm(gameManager).Show();
			this.Close();
		}
        #endregion

        private void SetPlayerForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
			if (Application.OpenForms.Count == 1)
				Application.OpenForms[0].Show();
        }
    }

}