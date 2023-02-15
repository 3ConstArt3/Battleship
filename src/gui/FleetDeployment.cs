#region Imports
using System;
using System.Windows.Forms;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using System.Linq;
using Battleship.Utils;
using Battleship.Core;

#endregion

namespace Battleship.Gui
{

	public partial class FleetDeploymentForm : KryptonForm
	{
		#region Variable Declarations
		private readonly GameManager gameManager;
		private PictureBox selectedShipPBox;
		private readonly List<PictureBox> fleetPBoxes;
        private readonly Dictionary<ShipType, Point> initShipPBoxLocations;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public FleetDeploymentForm(GameManager gameManager)
		{
			InitializeComponent();
            this.gameManager = gameManager;

			fleetPBoxes = new List<PictureBox>()
			{
				CarrierPbx,
				BattleShipPbx,
				CruiserPbx,
				SubmarinePbx,
				DestroyerPbx
			};

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
				selectedShipPBox.BackColor = Color.Transparent;
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
			gameManager.GameState.PlayerLockSetup(false);

			foreach (var shipPbox in fleetPBoxes)
				shipPbox.Click -= ShipPBox_Click;

            new BattleFieldForm(gameManager, fleetPBoxes).Show();
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
			if(CarrierPbx.Width < CarrierPbx.Height)
			{
                Image img = CarrierPbx.Image;
                CarrierPbx.Size = new Size(CarrierPbx.Size.Height, CarrierPbx.Size.Width);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                CarrierPbx.Image = img;
            }
			CarrierPbx.BackColor = Color.Transparent;
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
            if (BattleShipPbx.Width < BattleShipPbx.Height)
            {
                Image img = BattleShipPbx.Image;
                BattleShipPbx.Size = new Size(BattleShipPbx.Size.Height, BattleShipPbx.Size.Width);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                BattleShipPbx.Image = img;
            }
            BattleShipPbx.BackColor = Color.Transparent;
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
            if (CruiserPbx.Width < CruiserPbx.Height)
            {
                Image img = CruiserPbx.Image;
                CruiserPbx.Size = new Size(CruiserPbx.Size.Height, CruiserPbx.Size.Width);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                CruiserPbx.Image = img;
            }
            CruiserPbx.BackColor = Color.Transparent;
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
            if (SubmarinePbx.Width < SubmarinePbx.Height)
            {
                Image img = SubmarinePbx.Image;
                SubmarinePbx.Size = new Size(SubmarinePbx.Size.Height, SubmarinePbx.Size.Width);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SubmarinePbx.Image = img;
            }
            SubmarinePbx.BackColor = Color.Transparent;
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
            if (DestroyerPbx.Width < DestroyerPbx.Height)
            {
                Image img = DestroyerPbx.Image;
                DestroyerPbx.Size = new Size(DestroyerPbx.Size.Height, DestroyerPbx.Size.Width);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                DestroyerPbx.Image = img;
            }
            DestroyerPbx.BackColor = Color.Transparent;
        }

		private Location getCellFromCoords(Point p)
		{
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

        private Panel getGBoxFromShipType(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.Carrier:
                    return CarrierGBox;
                case ShipType.Battleship:
                    return BattleshipGBox;
                case ShipType.Cruiser:
                    return CruiserGBox;
                case ShipType.Submarine:
                    return SubmarineGBox;
                case ShipType.Destroyer:
                    return DestroyerGBox;
                default:
                    throw new ArgumentException();
            }
        }

        private void panel_Click(object sender, EventArgs e)
		{
			if (selectedShipPBox == null) 
				return;

            PictureBox newShip = selectedShipPBox;
			Controls.Add(newShip);
			newShip.BringToFront();
			newShip.BackColor = Color.Transparent;
			
			Panel targetPanel = (Panel)sender;
            Location placedLoc = getCellFromCoords(targetPanel.Location);

			ShipType pBoxShipType = getTypeFromPBox((string)newShip.Tag);

            try
			{  
                gameManager.GameState.PlayerPlaceShip(placedLoc, true, pBoxShipType);
			}
			catch (InvalidShipPlacementException) 
			{
				List<IDrawShip> fleet = gameManager.GameState.GetPlayerFleet(true);
				IDrawShip selectedShip = fleet.Single(sampleShip => sampleShip.Type == pBoxShipType);

                if (selectedShip.InitCell == null)
					newShip.Parent = getGBoxFromShipType(pBoxShipType);
				return; 
			}

            newShip.Location = new Point(BattleFieldPreviewGrbx.Location.X + targetPanel.Location.X + 6,
			BattleFieldPreviewGrbx.Location.Y + targetPanel.Location.Y + targetPanel.Height + 2);
		}

        #endregion

        private void FleetDeploymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.OpenForms[0].Show();
        }
    }

}