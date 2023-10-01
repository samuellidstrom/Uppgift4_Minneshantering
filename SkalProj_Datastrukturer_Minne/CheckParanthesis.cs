using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Windows.Markup;

namespace SkalProj_Datastrukturer_Minne
{
    internal class CheckParanthesis
    {
        /*
        * Use this method to check if the paranthesis in a string is Correct or incorrect.
        * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
        * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
        */
        public CheckParanthesis()
        {
            Console.Clear();
            CheckParanthesisInfo checkParanthesisInfo = new CheckParanthesisInfo();
            var specCharacters = new List<char>();
            string userInput = "";           

            while (true)
            {
                specCharacters.Clear();
                bool success = true;
                CheckParanthesisClearInput clearUserInput = new CheckParanthesisClearInput(userInput);                
                
                do
                {
                    Console.SetCursorPosition(12, 5);
                    userInput = Console.ReadLine();
                    Console.SetCursorPosition(12, 5);
                
                    if (string.IsNullOrEmpty(userInput))
                    {
                        Console.SetCursorPosition(0, 7);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Du måste skriva något.\n                                               ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (userInput == "q" || userInput == "Q")
                    {
                        Console.Clear();
                        MainMenu mainMenu = new MainMenu();
                    }
                    else
                    {
                        Console.SetCursorPosition(1, 7);
                        Console.WriteLine("                            ");
                        break;
                    }

                } while (true);

                for (int i = 0; i < userInput.Length; i++)
                {
                    var currentChar = userInput[i];
                    if (currentChar == '(' || currentChar == '[' || currentChar == '{')
                    {
                        specCharacters.Add(currentChar);
                    }
                    else if (currentChar == ')' || currentChar == ']' || currentChar == '}')
                    {
                        if (specCharacters.Count > 0)
                        {
                            var lastOpenedChar = specCharacters[specCharacters.Count - 1];
                            if (currentChar == ')' && lastOpenedChar == '(')
                            {
                                specCharacters.RemoveAt(specCharacters.Count - 1);

                            }
                            else if (currentChar == '}' && lastOpenedChar == '{')
                            {
                                specCharacters.RemoveAt(specCharacters.Count - 1);

                            }
                            else if (currentChar == ']' && lastOpenedChar == '[')
                            {
                                specCharacters.RemoveAt(specCharacters.Count - 1);

                            }
                            else
                            {
                                success = false;
                            }
                        }
                        else
                        {
                            success = false;
                        }

                        

                    }
                }
                CheckParanthesisMsg checkParanthesisMsg = new CheckParanthesisMsg(success, specCharacters, userInput);
            }
        }
    }
}