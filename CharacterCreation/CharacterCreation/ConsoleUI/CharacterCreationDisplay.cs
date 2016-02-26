using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.ConsoleUI
{
    class CharacterCreationDisplay
    {
        Character myCharacter;
        CharacterCreationFileSystem fileSystem;

        public CharacterCreationDisplay(Character character, CharacterCreationFileSystem characterFileSystem)
        {
            myCharacter = character;
            fileSystem = characterFileSystem;
        }

        public void MainMenu()
        {
            char userKey;
            int menuChoice;
            bool validInput = false;

                do
                {
                    //Clear the console
                    Console.Clear();

                    //Show main menu
                    DisplayMenu();
                    //Get user's menu choice
                    userKey = GetUserInput();

                    //Convert user input
                    try
                    {
                        menuChoice = Int32.Parse(userKey.ToString());
                        /*
                        To do:
                        - Actions based on input
                        - Interfaces for character creation and saving/loading
                        */
                        switch (menuChoice)
                        {
                            //Actions based on input go here
                            case 1:
                                //create character
                                validInput = true;
                                CreateCharacter CreateCharacter = new CreateCharacter(myCharacter, fileSystem);
                                CreateCharacter.Create();
                                break;
                            case 2:
                                //load character
                                validInput = true;
                                Utils.PressToContinue();
                                break;
                            case 3:
                                //quit
                                validInput = true;
                                break;
                            default:
                                Console.WriteLine("Please enter a valid menu option");
                                Utils.PressToContinue();
                                break;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid format - Please provide input as an integer");
                        Utils.PressToContinue();
                    }
                } while (!validInput);

            Utils.PressToContinue();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Character Creation System");
            Console.WriteLine();
            Console.WriteLine("1) Create a character");
            Console.WriteLine("2) Load a character");
            Console.WriteLine("3) Exit");
            Console.WriteLine();
        }

        public char GetUserInput()
        {
            Console.WriteLine("Please enter a value from the above menu");
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.WriteLine(Environment.NewLine + "");
            return userInput.KeyChar;
        }
    }
}
