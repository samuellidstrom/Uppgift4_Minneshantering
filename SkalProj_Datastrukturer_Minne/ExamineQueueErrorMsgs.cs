namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineQueueErrorMsgs
    {
        public ExamineQueueErrorMsgs()
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Follow the instructions above, please.\n  Press any key...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }
        public ExamineQueueErrorMsgs(char input)
        {
            if (input == '+')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Since you didn not write anything after the + nothing will be added to the list.\n  Press any key...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }

            if (input == '-')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  You can not choose a specific person to leave the line.");
                Console.WriteLine("  Just type - when the person at the front is done and leaves.");
                Console.Write("  Press any key...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }

            if (input == '0')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  You can not remove anyone, since the queue is empty.");
                Console.Write("  Press any key...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }

        }

        public ExamineQueueErrorMsgs(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"  There is no item called ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" in the list to remove.\n  Press any key...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }


    }
}