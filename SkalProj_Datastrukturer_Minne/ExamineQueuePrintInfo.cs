namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineQueuePrintInfo
    {
        public ExamineQueuePrintInfo(Queue<string> theList)
        {
            Console.Clear();
            Console.Write(".: Examine a queue :.\n\nThere's a");

            if (theList.Count <= 0)
            {
                Console.Write("n empty queue at");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else { Console.Write(" queue at"); }
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ICA");
            Console.ResetColor();
            Console.WriteLine(".");

            Console.WriteLine("\n Add people: Type + followed by the person's name.");
            Console.WriteLine(" Type - when the person at the front of the queue is done and leaves.");
            Console.WriteLine(" Main Menu: Type Q to return to the main menu.");
        }
    }
}