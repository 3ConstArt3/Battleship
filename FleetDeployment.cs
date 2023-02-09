#region Imports
using System;
using System.Windows.Forms;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
#endregion

namespace Battleship
{

	public partial class FleetDeploymentForm : KryptonForm
	{
		#region Variable Declarations
		private GameManager gameManager;
		private PictureBox selectedShipPBox;
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

		private void ShipPBox_Click(object sender, System.EventArgs e)
		{
			if (selectedShipPBox != null)
				selectedShipPBox.BackColor = Color.FromArgb(0, 0, 0, 0);
			selectedShipPBox = (PictureBox)sender;
			selectedShipPBox.BackColor = Color.FromArgb(255, 230, 230, 230);
		}

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

		private Location getCellFromCoords(Point p)
		{
			//int cellMargin = panel2.Left - panel1.Left - panel1.Width;
			int cellDist = panel2.Left - panel1.Left;

			int cellIndexX = (p.X - panel1.Location.X) / cellDist;
			int cellIndexY = (p.Y - panel1.Location.Y) / cellDist;

			return new Location((uint)cellIndexX, (uint)cellIndexY);
		}

		private ShipType getTypeFromPBox(Image image)
		{
			if (image == Properties.Resources.CarrierBattleS)
				return ShipType.Carrier;
			else if (image == Properties.Resources.CruiserBattleS)
				return ShipType.Cruiser;
			else if (image == Properties.Resources.DestroyerBattleS)
				return ShipType.Destroyer;
			else if (image == Properties.Resources.SubmarineBattleS)
				return ShipType.Submarine;
			else if (image == Properties.Resources.BattleShipBattleS)
				return ShipType.Battleship;
			else
				throw new ArgumentException();
		}

		private void panel1_Click(object sender, System.EventArgs e)
		{
			Controls.Remove(selectedShipPBox);
			PictureBox newShip = selectedShipPBox;
			Controls.Add(newShip);
			newShip.BringToFront();
			newShip.Location = new Point(PreviewGrbx.Location.X + panel1.Location.X,
				PreviewGrbx.Location.Y + panel1.Location.Y + panel1.Height);

			Location placedLoc = getCellFromCoords(((Panel)sender).Location);
			gameManager.GameState.PlayerPlaceShip(placedLoc, true, getTypeFromPBox(newShip.Image));
		}
	}

}