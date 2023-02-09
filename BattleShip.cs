#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class MainForm : KryptonForm
	{

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public MainForm() => InitializeComponent();

		#region Method Definition
		/// <summary>
		/// Opens SetPlayerForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PreparationBtn_Click( object sender, EventArgs e )
		{
			this.Hide();
			new SetPlayerForm().Show();
		}
		#endregion

	}

}