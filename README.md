# Connect 4

A two-player Connect Four game built with C# Windows Forms.

## Overview

Connect 4 is a classic two-player strategy game. Players take turns dropping coloured discs into a 7-column, 6-row grid. The first player to form a horizontal, vertical, or diagonal line of **four of their own discs** wins the round.

- **Player 1** plays with **Red** discs.
- **Player 2** plays with **Black** discs.

## Features

- **7 × 6 game board** rendered inside a yellow panel.
- **Turn indicator** in the sidebar always shows whose turn it is.
- **Score tracker** keeps a running tally of Player 1 wins, Player 2 wins, and Draws for the current session.
- **Win detection** — checks horizontal, vertical, and both diagonal directions after every move.
- **Draw detection** — automatically detects when the board is completely filled with no winner.
- **Reset button** — clears the board and starts a new round (scores are preserved).
- **File menu** — Save the current board state to a `.txt` file; Open a saved game file.

## How to Build

**Requirements**

- Windows OS
- Visual Studio 2017 or later (or any Visual Studio with .NET Framework 4.x support)

**Steps**

1. Clone or download the repository.
2. Open `final project/Connect4/Connect4.sln` in Visual Studio.
3. Select **Build → Build Solution** (or press `Ctrl+Shift+B`).
4. Run the application with **Debug → Start Debugging** (`F5`) or **Start Without Debugging** (`Ctrl+F5`).

## How to Play

1. Launch the application.
2. **Player 1 (Red)** clicks a column on the yellow board to drop their disc. The disc falls to the lowest available row in that column.
3. **Player 2 (Black)** then clicks a column.
4. Players alternate turns until one player connects **four discs in a row** (horizontal, vertical, or diagonal) or the board is full (Draw).
5. A message box announces the result and the board resets for the next round.
6. Use the **Reset** button on the left sidebar to start a fresh round at any time.

## Project Structure

```
final project/
└── Connect4/
    ├── Connect4.sln          # Visual Studio solution file
    └── Connect4/
        ├── Program.cs        # Application entry point
        ├── Form1.cs          # Main form — UI event handling & score tracking
        ├── Form1.Designer.cs # Auto-generated UI layout
        ├── Form1.resx        # Form resource file
        ├── Game.cs           # Game logic (board state, win/draw detection, rendering)
        ├── App.config        # Application configuration
        └── Properties/       # Assembly metadata
```

## Game Logic (`Game.cs`)

| Method | Description |
|---|---|
| `Game()` | Initialises a fresh board (7 cols × 6 rows), sets Player 1 as the starting player. |
| `Reset()` | Clears the board and resets turn to Player 1. |
| `drawBoard(e)` | Paints the yellow grid with white circles representing empty slots. |
| `drawGamePiece(e, f)` | Places a coloured disc in the clicked column and advances the turn. |
| `WinningPlayer()` | Checks all win directions and returns `Color.Red`, `Color.Black`, or `Color.Empty`. |
| `IsBoardFull()` | Returns `true` when every column is completely filled (draw condition). |
| `ToString()` | Serialises the current board state to a human-readable text format for saving. |

## Known Limitations

- The **Open** (load game) feature reads a saved file but does not yet fully restore a game in progress — the board is not reconstructed from the file, so opening a save starts a blank game.
- The window is fixed size and does not scale.

## License

This project was created as a student assignment (SODV course) and is provided for educational purposes.
