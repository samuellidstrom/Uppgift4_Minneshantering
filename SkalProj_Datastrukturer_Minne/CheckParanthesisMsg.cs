namespace SkalProj_Datastrukturer_Minne
{
    internal class CheckParanthesisMsg
    {
        public CheckParanthesisMsg(bool success, List<char> specCharacters, string userInput)
        {
            if (specCharacters.Count == 0 && success == true)
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine($"Your input: {userInput}                             ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"CORRECT FORMULATION!      ");
                Console.ForegroundColor = ConsoleColor.White;

            }

            else
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine($"Your input: {userInput}                             ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"INCORRECT FORMULATION!      ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}