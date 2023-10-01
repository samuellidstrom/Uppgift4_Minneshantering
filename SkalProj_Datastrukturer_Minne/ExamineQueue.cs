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
                //ExamineListPrintItems examineListPrintItems = new ExamineListPrintItems(theList);
                ExamineQueuePrintPersons examineQueuePrintPersons = new ExamineQueuePrintPersons(lineAtIca);

                Console.SetCursorPosition(0, 8);
                Console.Write("Your input: ");
                string input = Console.ReadLine();
                char nav = ' ';

                //ToDo: Kolla varför översta if-satsen funkar men inte nedre gör det
                //----------------------------------------------------------
                if (input == null || input.Length < 1)
                {
                    //gör inget om den är null
                }
                else { nav = input[0]; }

                //if (input != null || input.Length < 1)
                //{
                //    nav = input[0];
                //}
                //----------------------------------------------------------
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
                        //else if (theList.Contains(input.Substring(1)) != true)
                        //{
                        //    string msg = input.Substring(1);
                        //    ExamineListErrorMsgs examineListErrorMsg3 = new ExamineListErrorMsgs(msg);
                        //}
                        //string itemRemove = input.Substring(1);
                        //theList.Remove(itemRemove);
                        break;
                    default:
                        if (input != null)
                        {
                            ExamineListErrorMsgs examinListErrorMsg = new ExamineListErrorMsgs();
                        }
                        break;
                }

            }




            /// <summary>
            /// Examines the datastructure Stack
            /// </summary>
        }
    }
}