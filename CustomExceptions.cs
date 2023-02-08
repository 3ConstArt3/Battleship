﻿using System;

namespace Battleship
{
    public class InvalidShipPlacementException : Exception
    {
        public InvalidShipPlacementException(string message) : base(message) { }
        public InvalidShipPlacementException() : base() { }
    }

    public class InvalidCellException : Exception
    {
        public InvalidCellException(string message) : base(message) { }
        public InvalidCellException() : base() { }
    }

    public class InvalidShotException : Exception
    {
        public InvalidShotException(string message) : base(message) { }
        public InvalidShotException() : base() { }
    }
}
