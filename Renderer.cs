namespace SnakeProGame;

public static class Renderer
{
    public static void Render(SnakeGame game)
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Score: {game.Score} ");

        for (int y = 0; y < game.GridDimension.Y; y++)
        { 
            for (int x = 0; x < game.GridDimension.X; x++)
            {
                Coord current = new Coord(x, y);

                if (game.SnakePos.Equals(current) || game.SnakeHistory.Contains(current))
                {
                    Console.Write("0");
                }else if(game.ApplePos.Equals(current)) {
                    Console.Write("a");
                }else if (x == 0 || y == 0 || x == game.GridDimension.X - 1 || y == game.GridDimension.Y - 1)
                {
                    Console.Write("#");
                }else
                {
                 Console.Write(" ");   
                } 
            }
            Console.WriteLine();
        }
    }
}