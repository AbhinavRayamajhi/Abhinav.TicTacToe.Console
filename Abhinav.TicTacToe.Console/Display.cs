using System;
using System.Reflection.Metadata.Ecma335;

namespace TicTacToe;

internal class Display
{

    public static void Menu()
    {
        int input = 0;
        int exitCode = 0;

        Console.WriteLine("Welcome to Tic Tac Toe!");
        Console.WriteLine("Press 1 to start the game");
        Console.WriteLine("Press 2 to exit the game");
        Console.WriteLine();

        input = Helpers.ValidateInput(Console.ReadLine());
        do
        {
            
            if (input == 1)
            {
                GameEngine.StartGame();
                exitCode = Continue();
            }
            else if (input == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.\n");
                Menu();
            }
        } while (exitCode == 0);
    }

    public static void Board(List<int> squares)
    {
        string board = "";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board += Helpers.PlayerSymbols[squares[i * 3 + j]];
                if (j < 2)
                {
                    board += "|";
                }
            }
            if (i < 2)
            {
                board += "\n---+---+---\n";
            }
        }
        Console.WriteLine(board);
        Console.WriteLine();
    }

    public static int Continue()
    {
        Console.WriteLine("Press C to continue, any other key to Exit.");
        if (Console.ReadLine()?.ToUpper() == "C")
        {
            return 0;
        }
        return 1;
    }
}
