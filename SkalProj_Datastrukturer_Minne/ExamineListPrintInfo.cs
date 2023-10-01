using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    public class ExamineListPrintInfo
    {
        public ExamineListPrintInfo(List<string> theList)
        {
            Console.Clear();
            Console.Write(".: Examine a List :.\n\nThere's a list.");
            
            if (theList.Count <= 0) 
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ..It's empty though..\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else { Console.WriteLine("\n"); }

            Console.WriteLine(" Add items: Type + followed by the item.");
            Console.WriteLine(" Remove items: Type - followed by the item.");
            Console.WriteLine(" Main Menu: Type Q to return to the main menu.");
        }
    }
}