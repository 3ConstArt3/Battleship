using System;

namespace Battleship
{
    public class InvalidShipPlacementException : Exception
    {
        public InvalidShipPlacementException(string message) : base(message) { }
        public InvalidShipPlacementException() : base() { }
    }
}
