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
			AutoScaleMode= AutoScaleMode.None;
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
			foreach( var ship in gameManager.GameState.GetPlayerFleet(true) )
				if (ship.InitCell == null)
					return;

			new BattleFieldForm(gameManager).Show();
			Close();
		}

		/// <summary>
		/// Prompts Carrier's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateCarrierBtn_Click( object sender, System.EventArgs e )
		{
			try
			{
				gameManager.GameState.PlayerRotateShip(ShipType.Carrier, true);
			}
			catch (InvalidShipPlacementException) { return; }

			Image img = CarrierPbx.Image;
			CarrierPbx.Size = new Size(CarrierPbx.Size.Height, CarrierPbx.Size.Width);
			img.RotateFlip(RotateFlipType.Rotate90FlipNone);
			CarrierPbx.Image = img;
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

			int cellIndexColumn = (int)Math.Round((float)(p.X - panel1.Location.X) / (float)cellDist);
			int cellIndexRow = (int)Math.Round((float)(p.Y - panel1.Location.Y) / (float)cellDist);

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
			newShip.BackColor = Color.LimeGreen;
			Panel targetPanel = (Panel)sender;

			try
			{
				Location placedLoc = getCellFromCoords(targetPanel.Location);
				gameManager.GameState.PlayerPlaceShip(placedLoc, true, getTypeFromPBox((string)newShip.Tag));
			}
			catch (InvalidShipPlacementException) { return; }

			newShip.Location = new Point(PreviewGrbx.Location.X + targetPanel.Location.X + 4,
			PreviewGrbx.Location.Y + targetPanel.Location.Y + targetPanel.Height + 2);
		}

        private void panel48_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel60_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel59_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel50_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel52_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel53_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel54_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel55_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel56_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel57_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel58_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}