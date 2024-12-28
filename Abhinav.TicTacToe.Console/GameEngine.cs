namespace TicTacToe;

class GameEngine
{
    public static List<int> list = new();
    
    public static void StartGame()
    {
        list = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int currentPlayer = 1;
        int winner = 0;
        int moves = 0;

        Console.Clear();
        Console.WriteLine("Player 1 is O, Player 2 is X");

        while (winner == 0 && moves < 9)
        {
            Console.WriteLine();
            Display.Board(list);
            Console.WriteLine($"Player {currentPlayer}'s turn");
            int move = Helpers.ValidateInput(Console.ReadLine());
            if (move < 0 || move > 8 || list[move] != 0)
            {
                Console.WriteLine("Invalid move. Please try again.\n");
                continue;
            }
            list[move] = currentPlayer;
            winner = CheckWinner(list);
            currentPlayer = currentPlayer == 1 ? 2 : 1;
            moves++;
        }
        Display.Board(list);
        if (winner == 0)
        {
            Console.WriteLine("It's a draw!");
        }
        else
        {
            Console.WriteLine($"Player {winner} wins!");
        }
    }
    public static int CheckWinner(List<int> squares)
    {
        for (int i = 0; i < 3; i++)
        {
            if (squares[i] == squares[i + 3] && squares[i + 3] == squares[i + 6] && squares[i] != 0)
            {
                return squares[i];
            }
            if (squares[i * 3] == squares[i * 3 + 1] && squares[i * 3 + 1] == squares[i * 3 + 2] && squares[i] != 0)
            {
                return squares[i * 3];
            }
        }
        if (squares[0] == squares[4] && squares[4] == squares[8] && squares[0] != 0)
        {
            return squares[0];
        }
        if (squares[2] == squares[4] && squares[4] == squares[6] && squares[2] != 0)
        {
            return squares[2];
        }
        return 0;
    }
}
