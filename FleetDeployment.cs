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

			int cellIndexColumn = (int)Math.Round((float)(p.X - panel1.Location.X) / cellDist);
			int cellIndexRow = (int)Math.Round((float)(p.Y - panel1.Location.Y) / cellDist);

			return new Location((uint)cellIndexRow, (uint)cellIndexColumn);
		}

		private ShipType getTypeFromPBox(string tag)
		{
			switch (tag)
			{
				case "Carrier":
					return ShipType.Carrier;
				case "Battleship":
					return ShipType.Battleship;
				case "Cruiser":
					return ShipType.Cruiser;
				case "Submarine":
					return ShipType.Submarine;
				case "Destroyer":
					return ShipType.Destroyer;
				default:
					throw new ArgumentException();
			}
		}

		private void panel_Click(object sender, EventArgs e)
		{
			Controls.Remove(selectedShipPBox);
			PictureBox newShip = selectedShipPBox;
			Controls.Add(newShip);
			newShip.BringToFront();
			Panel targetPanel = (Panel)sender;
			newShip.Location = new Point(PreviewGrbx.Location.X + targetPanel.Location.X,
				PreviewGrbx.Location.Y + targetPanel.Location.Y + targetPanel.Height);

			Location placedLoc = getCellFromCoords(((Panel)sender).Location);
			gameManager.GameState.PlayerPlaceShip(placedLoc, true, getTypeFromPBox((string)newShip.Tag));
		}
	}

}