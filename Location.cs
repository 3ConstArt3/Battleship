namespace Battleship
{

    public class Location
    {

		#region Variable Declaration
		public readonly uint row, column;
        #endregion

        /// <summary>
        /// Constructor Definitiom.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public Location( uint row, uint column )
        {
            this.row = row;
            this.column = column;
        }

    }

}