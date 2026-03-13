using SnakeProGame;

var game = new SnakeGame(100,15,3);
Direction currentDir = Direction.Down;
Console.CursorVisible = false;
Console.Clear();

while (!game.IsGameOver)
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true).Key;
        currentDir = key switch
        {
            ConsoleKey.UpArrow when currentDir != Direction.Down => Direction.Up,
            ConsoleKey.DownArrow when currentDir != Direction.Up => Direction.Down,
            ConsoleKey.LeftArrow when currentDir != Direction.Right => Direction.Left,
            ConsoleKey.RightArrow when currentDir != Direction.Left => Direction.Right,
            _ => currentDir
        };
    }
    
    game.Update(currentDir);
    Renderer.Render(game);
    Thread.Sleep(100);
}
Console.SetCursorPosition(0, game.GridDimension.Y + 2);
Console.WriteLine($"Game Over! Dein Endstand: {game.Score}");
Console.CursorVisible = true;
