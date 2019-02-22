using System;
using System.Threading;

namespace TETRIS
{
    class Program
    {
        // Setings
        static int TetrisRows = 20;
        static int TetrisCols = 10;
        static int InfoCols = 10;
        static int ConsoleRows = 1 + TetrisRows + 1;
        static int ConsoleCols = 1 + TetrisCols + 1 + InfoCols + 1;

        // State
        static int Score = 0;
        static void Main(string[] args)
        {
            Console.Title = "Tetris v1.0";
            Console.WindowHeight = ConsoleRows + 1;
            Console.WindowWidth = ConsoleCols;
            Console.BufferHeight = ConsoleRows + 1;
            Console.BufferWidth = ConsoleCols;
            Console.CursorVisible = false;
            DrawBorder();
            DrawInfo();
            while (true)
            {
                Score++;
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        //Environment.Exit(0);
                        return; //Because of Main()
                    }
                }
                //user input
                //change state
                //redraw UI
                DrawBorder();
                DrawInfo();
                Thread.Sleep(40);
            }
        }
        static void DrawBorder()
        {
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            for (int i = 0; i < TetrisCols; i++)
            {
                line += "═";
            }
            line += "╦";
            for (int i = 0; i < InfoCols; i++)
            {
                line += "═";
            }
            line += "╗";
            Console.Write(line);

            for (int i = 0; i < TetrisRows; i++)
            {
                string middleLine = "║";
                for (int j = 0; j < TetrisCols; j++)
                {
                    middleLine += " ";
                }
                middleLine += "║";
                for (int j = 0; j < InfoCols; j++)
                {
                    middleLine += " ";
                }
                middleLine += "║";
                Console.Write(middleLine);
            }

            string endline = "╚";
            endline += new string('═', TetrisCols);
            endline += "╩";
            endline += new string('═', InfoCols);
            endline += "╝";
            Console.Write(endline);
        }
        static void Write(string text, int row = 0, int col = 0, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.ResetColor();
        }
        static void DrawInfo()
        {
            Write("Score:", 1, 3 + TetrisCols);
            Write(Score.ToString(), 2, 3 + TetrisCols);
        }
    }
}
