namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineList
    {
        public ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            while (true)
            {
                ExamineListPrintInfo examineListMenu = new ExamineListPrintInfo(theList);
                ExamineListPrintItems examineListPrintItems = new ExamineListPrintItems(theList);

                Console.SetCursorPosition(0, 8);
                Console.Write("Your input: ");
                string input;
                char nav;

                do
                {
                    Console.SetCursorPosition(0, 8);
                    Console.Write("Your input: ");
                    input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("  You need to write something..\n  Press any key...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 9);
                        Console.Write("                                                \n                  ");
                        //Console.Clear();
                    }
                    else { nav = input[0]; break; }

                } while (true);

                switch (nav)
                {
                    case 'q' or 'Q':
                        Console.Clear();
                        MainMenu mainMenu = new MainMenu();
                        break;
                    case '+':
                        if (input.Length < 2)
                        {
                            ExamineListErrorMsgs examineListErrorMsg2 = new ExamineListErrorMsgs(nav);
                            break;
                        }
                        string item = input.Substring(1);
                        theList.Add(item);
                        break;

                    case '-':
                        if (input.Length < 2)
                        {
                            ExamineListErrorMsgs examineListErrorMsg2 = new ExamineListErrorMsgs(nav);
                            break;
                        }
                        else if (theList.Contains(input.Substring(1)) != true)
                        {
                            string msg = input.Substring(1);
                            ExamineListErrorMsgs examineListErrorMsg3 = new ExamineListErrorMsgs(msg);
                        }
                        string itemRemove = input.Substring(1);
                        theList.Remove(itemRemove);
                        break;
                    default:
                        if (input != null)
                        {
                            ExamineListErrorMsgs examinListErrorMsg = new ExamineListErrorMsgs();
                        }
                        break;
                }
            }
        }
    }
}