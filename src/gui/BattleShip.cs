#region Imports
using System;
using ComponentFactory.Krypton.Toolkit;
using Battleship.Core;
#endregion

namespace Battleship.Gui
{

	public partial class MainForm : KryptonForm
	{
		#region Variable Declarations
		private GameManager gameManager;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			gameManager = new GameManager();
		}

		#region Method Definition
		/// <summary>
		/// Opens SetPlayerForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PreparationBtn_Click( object sender, EventArgs e )
		{
			this.Hide();
			new SetPlayerForm(gameManager).Show();
		}
		#endregion

	}

}