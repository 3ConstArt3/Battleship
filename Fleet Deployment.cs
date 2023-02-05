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

	public partial class FleetDeployment : KryptonForm
	{

		#region Variable Declaration
		//bool mouse_is_down = false;
		//int form_coord_x = 0, form_coord_y = 0;
		#endregion

		#region Constructor Definition
		public FleetDeployment() { InitializeComponent(); }
		#endregion

		#region Function Definition
		private void FleetDeploymentExitBtn_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		#endregion

	}

}