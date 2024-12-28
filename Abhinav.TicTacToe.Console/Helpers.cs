namespace TicTacToe
{
    class Helpers
    {
        public static Dictionary<int, string> PlayerSymbols = new()
        {
            { 0, "   " },
            { 1, " O " },
            { 2, " X " }
        };

        public static int ValidateInput(string? input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            return -1;
        }

    }
}
