#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class SetPlayerForm : KryptonForm
	{

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public SetPlayerForm() => InitializeComponent();

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
			new FleetDeploymentForm().Show();
			this.Close();
		}
		#endregion

	}

}