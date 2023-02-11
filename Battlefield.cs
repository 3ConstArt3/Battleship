#region Imports
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Workspace;
#endregion

namespace Battleship
{

	public partial class BattleFieldForm : KryptonForm
	{

		#region Variable Declarations
		private GameManager gameManager;
		private List<PictureBox> player1FleetPboxes;
		private List<PictureBox> player2FleetPboxes;
		#endregion

		/// <summary>
		/// Constructor Definition.
		/// </summary>
		public BattleFieldForm(GameManager gameManager, List<PictureBox> fleetPboxes)
		{
			InitializeComponent();
			this.gameManager = gameManager;

            player1FleetPboxes = fleetPboxes.ToList();
            player2FleetPboxes = fleetPboxes.ConvertAll(
                pBox => new PictureBox()
                {
					Height = pBox.Height,
					Width = pBox.Width,
					Image = (Image)pBox.Image.Clone(),
					Tag = pBox.Tag,
					SizeMode = pBox.SizeMode,
                });

            placePlayerFleet(true);
            placePlayerFleet(false);
        }

		#region Method Definition

		/// <summary>
		///  Closes BattleFieldForm UI & invokes HighScoreForm UI.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BattleFieldForm_FormClosed( object sender, FormClosedEventArgs e )
		{
			// new HighScoresForm().Show();
			// this.Close();
		}

		private void PosA1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosA10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosB1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosC10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosD1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosE10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosF1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosG10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosH1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosI10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ10Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ9Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ8Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ7Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ6Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ5Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ4Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ3Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ2Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

		private void PosJ1Pnl_MouseClick( object sender, MouseEventArgs e )
		{

		}

        #endregion

        private Point getCoordsFromCell(Location cell)
        {
            int cellDist = panel2.Left - panel1.Left;

			int cellX = (int)(cell.column * cellDist + panel1.Location.X);
			int cellY = (int)(cell.row * cellDist + panel1.Location.Y);

            return new Point(cellX, cellY);
        }

		private void placePlayerFleet(bool isPlayer1)
		{
			List<IDrawShip> fleet = gameManager.GameState.GetPlayerFleet( isPlayer1 );
			List<PictureBox> fleetPboxes = isPlayer1 ? player1FleetPboxes : player2FleetPboxes;
			KryptonGroupBox selectedGbox = isPlayer1 ? Player1GridGbox : Player2GridGbox;

			foreach ( var ship in fleet ) 
			{
				Point coords = getCoordsFromCell(ship.InitCell);
				PictureBox shipPbox = fleetPboxes.Single(pbox => (string)pbox.Tag == ship.Name);
                shipPbox.Location = new Point(selectedGbox.Location.X + coords.X + 6,
                                              selectedGbox.Location.Y + coords.Y + panel1.Height + 2);
				Controls.Add(shipPbox);
				shipPbox.BringToFront();

				if (!isPlayer1)
				{
					bool shipPboxIsVertical = shipPbox.Width < shipPbox.Height;
					if (shipPboxIsVertical != ship.IsVertical) 
					{
                        Image img = shipPbox.Image;
                        shipPbox.Size = new Size(shipPbox.Size.Height, shipPbox.Size.Width);
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        shipPbox.Image = img;
                    }
				}
            }
		}

        private void enemyGridClick(object sender, System.EventArgs e)
        {

        }
    }

}