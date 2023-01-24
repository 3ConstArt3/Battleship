// Necessary imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Battleship
{
	public partial class BattleShipForm : KryptonForm
	{

		#region Constructor Definition
		public BattleShipForm() { InitializeComponent(); }
		#endregion

		#region Function Definition
		// Event handler for Preparation button
		private void PreparationBtn_Click( object sender, EventArgs e )
		{
			// Hide BattleShip Form
			this.Visible = false;
			// Open SetPlayer Form
			new SetPlayerForm().Show();
		}
		#endregion
	}

}