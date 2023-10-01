namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineListErrorMsgs
    {
        public ExamineListErrorMsgs()
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Follow the instructions above, please.\n  Press any key...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }

        public ExamineListErrorMsgs(char input)
        {
            string message;
            if (input == '+') { message = "added to"; }
            else { message = "removed from"; }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"  Since you didn not write anything after the {input} nothing will be {message} the list.\n  Press any key...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }

        public ExamineListErrorMsgs(string msg)
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