// Necessary imports
using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Battleship
{

	public partial class BattleShipForm : KryptonForm
	{

		#region Variable Declaration
		bool mouse_is_down = false;
		int form_coord_x = 0, form_coord_y = 0;
		#endregion

		#region Constructor Definition
		public BattleShipForm() { InitializeComponent(); }
		#endregion

		#region Function Definition
		private void PreparationBtn_Click( object sender, EventArgs e )
		{
			this.Visible = false;
			new SetPlayerForm().Show();
		}

		private void BattleShipsExitBtn_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void BattleShipForm_MouseDown( object sender, MouseEventArgs e )
		{
			UpdateMouseState( false );
			(form_coord_x, form_coord_y) = (e.X, e.Y);
		}

		private void BattleShipForm_MouseUp( object sender, MouseEventArgs e ) 
		{
			UpdateMouseState( true );
		}

		private void BattleShipForm_MouseMove( object sender, MouseEventArgs e )
		{
			if (mouse_is_down)
			{
				this.SetDesktopLocation( MousePosition.X - form_coord_x, 
										 MousePosition.Y - form_coord_y);
			}
		}

		private void UpdateMouseState( bool mouse_state ) { mouse_is_down = mouse_state; } 
		#endregion

	}

}