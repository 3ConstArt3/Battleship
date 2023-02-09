#region Imports
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class BattleFieldForm : KryptonForm
	{

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public BattleFieldForm() => InitializeComponent();

		#region Method Definition

		/// <summary>
		///  Closes BattleFieldForm UI & invokes HighScoreForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BattleFieldForm_FormClosed( object sender, FormClosedEventArgs e )
		{
			// new HighScoresForm().Show();
			this.Close();
		}


		#endregion

	}

}