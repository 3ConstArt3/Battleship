namespace Battleship
{
    public interface IDrawShip
    {
        uint Size { get; }
        string Name { get; }
        ShipType Type { get; }
        Location InitCell { get; }
        bool IsVertical { get; }
    }
}
