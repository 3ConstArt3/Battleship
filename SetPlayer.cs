// Necessary imports
using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Battleship
{

	public partial class SetPlayerForm : KryptonForm
	{

		#region Variable Declaration
		bool mouse_is_down = false;
		int form_coord_x = 0, form_coord_y = 0;
		#endregion

		#region Constructor Definition
		public SetPlayerForm() { InitializeComponent(); }
		#endregion

		#region Function Definition
		private void FleetDeployBtn_Click( object sender, EventArgs e )
		{
			this.Visible = false;
			new Fleet_Deployment().Show();
		}

		private void RegisterBtn_Click( object sender, EventArgs e )
		{

		}

		private void SetCommanderExitBtn_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void SetPlayerForm_MouseDown( object sender, MouseEventArgs e )
		{
			UpdateMouseState( false );
			(form_coord_x, form_coord_y) = (e.X, e.Y);
		}

		private void SetPlayerForm_MouseUp( object sender, MouseEventArgs e )
		{
			UpdateMouseState( true );
		}

		private void SetPlayerForm_MouseMove( object sender, MouseEventArgs e )
		{
			if( mouse_is_down )
			{
				this.SetDesktopLocation( MousePosition.X - form_coord_x,
										 MousePosition.Y - form_coord_y );
			}
		}

		private void UpdateMouseState( bool mouse_state ) { mouse_is_down = mouse_state; }
		#endregion

	}

}