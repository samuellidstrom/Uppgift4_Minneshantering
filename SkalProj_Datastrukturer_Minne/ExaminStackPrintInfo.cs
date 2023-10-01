using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExaminStackPrintInfo
    {
        public ExaminStackPrintInfo(Stack<char> theStack)
        {
            Console.Clear();
            Console.WriteLine(".: Examine a Stack :.");
            Console.WriteLine("\n Type anything and I will use magic to reverse what you wrote.");
            Console.WriteLine(" ..Except for Q which will bring you back to the main menu.");

            
            if (theStack.Count > 0)
            {
                Console.SetCursorPosition(1, 7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Your message in reverse is: ");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in theStack)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                theStack.Clear();
            }
            else
            {
                Console.SetCursorPosition(1, 7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("The stack is currently empty. ");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}