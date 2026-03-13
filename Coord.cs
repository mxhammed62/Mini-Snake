namespace SnakeProGame;

public class Coord
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public Coord(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Coord other) return false;
        return X == other.X && Y == other.Y;
    }
    
    public override int GetHashCode()=>HashCode.Combine(X, Y);

    public void ApplyMovementDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                Y--;
                break;
            case Direction.Down:
                Y++;
                break;
            case Direction.Left:
                X--;
                break;
            case Direction.Right:
                X++;
                break;
        }
        {
            
        }
    }
}