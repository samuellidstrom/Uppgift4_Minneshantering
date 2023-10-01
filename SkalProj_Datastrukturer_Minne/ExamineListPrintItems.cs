using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineListPrintItems
    {
        public ExamineListPrintItems(List<string> theList)
        {
            Console.SetCursorPosition(1, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Current list capacity: {theList.Capacity}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Items currently in the list:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in theList)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {item}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}