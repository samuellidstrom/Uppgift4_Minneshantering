namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineQueuePrintPersons
    {
        public ExamineQueuePrintPersons(Queue<string> theLine)
        {
            Console.SetCursorPosition(1, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Persions standing in line at ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ICA");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(".");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in theLine)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"  {item}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}