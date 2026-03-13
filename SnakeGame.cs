using System;
using System.Collections.Generic;

namespace SnakeProGame;


public class SnakeGame
{
    public Coord GridDimension { get; }
    public Coord SnakePos { get; private set; }
    public Coord ApplePos { get; private set; }
    public List<Coord> SnakeHistory { get;} = new();
    public int TailLength { get; private set; }
    public int Score { get; private set; } = 0;
    public bool IsGameOver { get; private set; } = false;
    
    private readonly Random _random = new();
    
    public SnakeGame(int width, int height, int startLength=3)
    {
        GridDimension = new Coord(width, height);
        SnakePos = new Coord(10, 5);
        TailLength = startLength;

        for (int i = 0; i < TailLength; i++)
        {
            SnakeHistory.Add(new Coord(SnakePos.X,SnakePos.Y));
        }
        
        SpawnApple();
    }

    private void SpawnApple()
    {
        Coord newApple;
        do
        {
            newApple = new Coord(_random.Next(1,GridDimension.X-1),_random.Next(1,GridDimension.Y-1));
        } while (SnakeHistory.Any(p=>p.Equals(newApple) || SnakePos.Equals(newApple)));
        ApplePos = newApple;
    }

    public void Update(Direction direction)
    {
        if (IsGameOver) return;
        SnakeHistory.Add(new Coord(SnakePos.X,SnakePos.Y));
        SnakePos.ApplyMovementDirection(direction);

        if (SnakePos.X <= 0 || SnakePos.X >= GridDimension.X-1 || SnakePos.Y <= 0 || SnakePos.Y >= GridDimension.Y)
        {
            IsGameOver = true;
            return;
        }

        if (SnakePos.Equals(ApplePos))
        {
            Score++;
            TailLength++;
            SpawnApple();
        }

        while (SnakeHistory.Count > TailLength)
        {
            SnakeHistory.RemoveAt(0);
        }
    }
}