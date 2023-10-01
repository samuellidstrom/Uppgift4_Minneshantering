namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineStack
    {
        /*
        * Loop this method until the user inputs something to exit to main menue.
        * Create a switch with cases to push or pop items
        * Make sure to look at the stack after pushing and and poping to see how it behaves
        */
        public ExamineStack()
        {
            //Queue<string> lineAtIca = new Queue<string>();
            Stack<char> characterStack = new Stack<char>();

            while (true)
            {
                ExaminStackPrintInfo examineStackMenu = new ExaminStackPrintInfo(characterStack);

                Console.SetCursorPosition(0, 5);
                Console.Write("Write something: ");
                string input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    Console.Clear();
                    MainMenu mainMenu = new MainMenu();
                }
                foreach (char x in input)
                {
                    characterStack.Push(x);
                }

            }
        }
    }
}