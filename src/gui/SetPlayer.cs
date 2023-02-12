﻿#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class SetPlayerForm : KryptonForm
	{

		#region Variable Declarations
		private GameManager gameManager;
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
		/// Prompts registrations of user's name.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RegisterNameBtn_Click( object sender, EventArgs e )
		{

		}

		/// <summary>
		/// Closes SetPlayerForm UI & invokes FleetDeploymentForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DelpoyFleetBtn_Click( object sender, EventArgs e )
		{
			gameManager.StartNewGame(NameTxtBx.Text);
			new FleetDeploymentForm(gameManager).Show();
			this.Close();
		}
		#endregion

	}

}