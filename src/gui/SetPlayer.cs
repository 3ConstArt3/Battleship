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
		private const int maxNameCharsLimit = 10;
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
			if (!validateUsername())
			{
                KryptonMessageBox.Show(
                    $"Name must have from 1 up to {maxNameCharsLimit} characters",
                    "Invalid Name!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
				
			gameManager.StartNewGame(NameTxtBx.Text);
			Player.ResetUserStats();
			new FleetDeploymentForm(gameManager).Show();
			this.Close();
		}
        #endregion

		private bool validateUsername()
		{
			return NameTxtBx.Text != string.Empty && NameTxtBx.Text.Length <= maxNameCharsLimit;
        }

        private void SetPlayerForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
			if (Application.OpenForms.Count == 1)
				Application.OpenForms[0].Show();
        }
    }

}