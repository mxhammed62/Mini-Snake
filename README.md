# Mini-Snake
C# Console Snake - An arcade clone featuring a decoupled OOP architecture, real-time collision detection via LINQ, and flicker-free rendering. Built with .NET and C# Switch Expressions for robust state management without external engines.

Key Features:
  - This project is strictly divided into Game Logic, Data Structures and Rendering. This separation ensures that the game engine is independent of the display method.
  - Instead of using Console.Clear(), which causes flickering, the engine uses Console.SetCursorPosition() to perform targeted buffer, resulting in a smooth 10 FPS gameplay experience.
  - Features a reactive tail-length system. When the snake consumes an apple, the TailLength property increments, and the pruning of the SnakeHistory list is momentarily paused to simulate growth.
