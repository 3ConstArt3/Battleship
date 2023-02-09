#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class SetPlayerForm : KryptonForm
	{

		#region Constructor Definition
		public SetPlayerForm() => InitializeComponent();
		#endregion

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
			new FleetDeployment().Show();
			this.Close();
		}
		#endregion

	}

}