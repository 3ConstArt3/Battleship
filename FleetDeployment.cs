#region Imports
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class FleetDeploymentForm : KryptonForm
	{
		#region Variable Declarations
		private GameManager gameManager;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public FleetDeploymentForm(GameManager gameManager)
		{
			InitializeComponent();
			this.gameManager = gameManager;
		}

		#region Function Definition

		/// <summary>
		/// Closes FleetDeploymentForm UI & invokes BattleFieldForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AttackBtn_Click( object sender, System.EventArgs e )
		{
			new BattleFieldForm(gameManager).Show();
			this.Close();
		}

		/// <summary>
		/// Prompts Carrier's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateCarrierBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Carrier's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetCarrierBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts BattleShip's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateBattleShipBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts BattleShip's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetBattleShipBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Cruiser's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateCruiserBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Cruiser's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetCruiserBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Submarine's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateSubmarineBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Submarine's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetSubmarineBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Destroyer's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateDestroyerBtn_Click( object sender, System.EventArgs e )
		{

		}

		/// <summary>
		/// Prompts Destroyer's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetDestroyerBtn_Click( object sender, System.EventArgs e )
		{

		}
		#endregion

	}

}