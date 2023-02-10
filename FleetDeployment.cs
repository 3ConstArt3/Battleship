#region Imports
using System;
using System.Windows.Forms;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Collections.Generic;

#endregion

namespace Battleship
{

	public partial class FleetDeploymentForm : KryptonForm
	{
		#region Variable Declarations
		private GameManager gameManager;
		private PictureBox selectedShipPBox;
		private readonly Dictionary<ShipType, Point> initShipPBoxLocations;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public FleetDeploymentForm(GameManager gameManager)
		{
			InitializeComponent();
            this.gameManager = gameManager;
			initShipPBoxLocations = new Dictionary<ShipType, Point>()
			{
				{ ShipType.Carrier, CarrierPbx.Location },
				{ ShipType.Battleship, BattleShipPbx.Location },
				{ ShipType.Cruiser, CruiserPbx.Location },
				{ ShipType.Submarine, SubmarinePbx.Location },
				{ ShipType.Destroyer, DestroyerPbx.Location }
            };
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

			gameManager.GameState.PlayerLockSetup(true);
			gameManager.GameState.PlayerRandomFleetPlacement(false);

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
			CarrierPbx.Size = new Size(CarrierPbx.Size.Height , CarrierPbx.Size.Width);
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
			gameManager.GameState.PlayerResetShip(ShipType.Carrier, true);
            CarrierPbx.Parent = CarrierGBox;
            CarrierPbx.Location = initShipPBoxLocations[ ShipType.Carrier ];
		}

		/// <summary>
		/// Prompts BattleShip's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateBattleShipBtn_Click( object sender, System.EventArgs e )
		{
            try
            {
                gameManager.GameState.PlayerRotateShip(ShipType.Battleship, true);
            }
            catch (InvalidShipPlacementException) { return; }

            Image img = BattleShipPbx.Image;
            BattleShipPbx.Size = new Size(BattleShipPbx.Size.Height, BattleShipPbx.Size.Width);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            BattleShipPbx.Image = img;
        }

		/// <summary>
		/// Prompts BattleShip's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetBattleShipBtn_Click( object sender, System.EventArgs e )
		{
            gameManager.GameState.PlayerResetShip(ShipType.Battleship, true);
            BattleShipPbx.Parent = BattleshipGBox;
            BattleShipPbx.Location = initShipPBoxLocations[ ShipType.Battleship ];
        }

		/// <summary>
		/// Prompts Cruiser's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateCruiserBtn_Click( object sender, System.EventArgs e )
		{
            try
            {
                gameManager.GameState.PlayerRotateShip(ShipType.Cruiser, true);
            }
            catch (InvalidShipPlacementException) { return; }

            Image img = CruiserPbx.Image;
            CruiserPbx.Size = new Size(CruiserPbx.Size.Height, CruiserPbx.Size.Width);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            CruiserPbx.Image = img;
        }

		/// <summary>
		/// Prompts Cruiser's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetCruiserBtn_Click( object sender, System.EventArgs e )
		{
			gameManager.GameState.PlayerResetShip(ShipType.Cruiser, true);
            CruiserPbx.Parent = CruiserGBox;
            CruiserPbx.Location = initShipPBoxLocations[ShipType.Cruiser];
        }

		/// <summary>
		/// Prompts Submarine's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateSubmarineBtn_Click( object sender, System.EventArgs e )
		{
            try
            {
                gameManager.GameState.PlayerRotateShip(ShipType.Submarine, true);
            }
            catch (InvalidShipPlacementException) { return; }

            Image img = SubmarinePbx.Image;
            SubmarinePbx.Size = new Size(SubmarinePbx.Size.Height, SubmarinePbx.Size.Width);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SubmarinePbx.Image = img;
        }

		/// <summary>
		/// Prompts Submarine's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetSubmarineBtn_Click( object sender, System.EventArgs e )
		{	
			gameManager.GameState.PlayerResetShip(ShipType.Submarine, true);
            SubmarinePbx.Parent = SubmarineGBox;
            SubmarinePbx.Location = initShipPBoxLocations[ShipType.Submarine];
        }

		/// <summary>
		/// Prompts Destroyer's PictureBox rotation
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RotateDestroyerBtn_Click( object sender, System.EventArgs e )
		{
            try
            {
                gameManager.GameState.PlayerRotateShip(ShipType.Destroyer, true);
            }
            catch (InvalidShipPlacementException) { return; }

            Image img = DestroyerPbx.Image;
            DestroyerPbx.Size = new Size(DestroyerPbx.Size.Height, DestroyerPbx.Size.Width);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            DestroyerPbx.Image = img;
        }

		/// <summary>
		/// Prompts Destroyer's PictureBox angle reset
		/// on the BattleField grid preview.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetDestroyerBtn_Click( object sender, System.EventArgs e )
		{	
			gameManager.GameState.PlayerResetShip(ShipType.Destroyer, true);
            DestroyerPbx.Parent = DestroyerGBox;
            DestroyerPbx.Location = initShipPBoxLocations[ShipType.Destroyer];
        }
		#endregion

		private Location getCellFromCoords(Point p)
		{
			//int cellMargin = panel2.Left - panel1.Left - panel1.Width;
			int cellDist = panel2.Left - panel1.Left;

			int cellIndexColumn = (int)Math.Round((float)((p.X - panel1.Location.X) / cellDist));
			int cellIndexRow = (int)Math.Round((float)((p.Y - panel1.Location.Y) / cellDist));

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
			newShip.BackColor = Color.Transparent;
			
			Panel targetPanel = (Panel)sender;
            Location placedLoc = getCellFromCoords(targetPanel.Location);
            //MessageBox.Show($"row:{placedLoc.row}, column:{placedLoc.column}");

            try
			{  
                gameManager.GameState.PlayerPlaceShip(placedLoc, true, getTypeFromPBox((string)newShip.Tag));
			}
			catch (InvalidShipPlacementException) { return; }

            newShip.Location = new Point(PreviewGrbx.Location.X + targetPanel.Location.X + 6,
			PreviewGrbx.Location.Y + targetPanel.Location.Y + targetPanel.Height + 2);
		}
    }

}