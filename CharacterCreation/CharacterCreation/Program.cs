using System;
using CharacterCreation.ConsoleUI;

namespace CharacterCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and show the interface
            Character myCharacter = new Character();
            CharacterCreationFileSystem fileSystem = new CharacterCreationFileSystem();

            CharacterCreationDisplay Display = new CharacterCreationDisplay(myCharacter, fileSystem);
            Display.MainMenu();
        }
    }
}
