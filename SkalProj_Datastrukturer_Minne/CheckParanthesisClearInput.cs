namespace SkalProj_Datastrukturer_Minne
{
    internal class CheckParanthesisClearInput
    {
        public CheckParanthesisClearInput(string userInput)
        {
            Console.SetCursorPosition(12, 5);
            foreach (char c in userInput)
            {
                Console.Write(" ");
            }
        }
    }
}