using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineQueue
    {
        public ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> lineAtIca = new Queue<string>();
            while (true)
            {
                ExamineQueuePrintInfo examineListMenu = new ExamineQueuePrintInfo(lineAtIca);
                ExamineQueuePrintPersons examineQueuePrintPersons = new ExamineQueuePrintPersons(lineAtIca);

                string input;
                char nav = ' ';

                do
                {
                    
                    Console.SetCursorPosition(0, 8);
                    Console.Write("Your input: ");
                    input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        ExamineQueueErrorMsgs examineQueueErrorMsgs = new ExamineQueueErrorMsgs(); 
                    }
                    else
                    {
                        nav = input[0];
                        break;
                    }
                } while (true);

                switch (nav)
                {
                    case 'q' or 'Q':
                        Console.Clear();
                        MainMenu mainMenu = new MainMenu();
                        break;
                    case '+':
                        if (input!.Length < 2)
                        {
                            ExamineQueueErrorMsgs examineQueueErrorMsgs = new ExamineQueueErrorMsgs(nav);
                            break;
                        }
                        string item = input.Substring(1);
                        lineAtIca.Enqueue(item);
                        break;

                    case '-':
                        if (input!.Length > 2)
                        {
                            ExamineQueueErrorMsgs examineQueueErrorMsgs = new ExamineQueueErrorMsgs(nav);
                            break;
                        }
                        else
                        {
                            if (lineAtIca.Count < 1)
                            {
                                nav = '0';
                                ExamineQueueErrorMsgs examineQueueErrorMsgs = new ExamineQueueErrorMsgs(nav);
                            }
                            else
                            {
                                lineAtIca.Dequeue();
                            }
                        }
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