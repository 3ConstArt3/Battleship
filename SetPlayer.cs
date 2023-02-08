// Necessary imports
using System;
using ComponentFactory.Krypton.Toolkit;

namespace Battleship
{

	public partial class SetPlayer : KryptonForm
	{

		#region Variable Declaration

		#endregion

		#region Constructor Definition
		public SetPlayer() { InitializeComponent(); }
		#endregion

		#region Function Definition
		private void FleetDeployBtn_Click( object sender, EventArgs e )
		{
			this.Visible = false;
			new FleetDeployment().Show();
		}

		private void RegisterBtn_Click( object sender, EventArgs e )
		{

		}

		private void SetCommanderExitBtn_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		#endregion

	}

}