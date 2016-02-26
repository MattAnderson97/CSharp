using System;

namespace CharacterCreation.ConsoleUI
{
    class CreateCharacter
    {
        Character myCharacter;
        CharacterCreationFileSystem fileSystem;
        char chosenClass;
        char primaryWeapon;
        char secondaryWeapon;
        char isCorrect;
        bool complete = false;
        string[] weapons = new string[2];

        public CreateCharacter(Character character, CharacterCreationFileSystem characterFileSystem)
        {
            myCharacter = character;
            fileSystem = characterFileSystem;
        }

        /// <summary>
        /// Create the character
        /// </summary>
        public void Create()
        {
            bool isCorrectValid = false;
            do
            {
                bool validClass = false;
                bool validWeapons = false;

                //Get character name
                ChooseName();

                //Get character class
                do
                {
                    ChooseClass();
                    //validate chosen class
                    validClass = ValidateClass();
                } while (!validClass);

                //Get chosen weapons
                do
                {
                    ChooseWeapons();
                    //validate chosen weapons
                    validWeapons = ValidateWeapons();
                } while (!validWeapons);

                do
                {
                    isCorrectValid = true;
                    ConfirmChoices();

                    switch (isCorrect.ToString())
                    {
                        case "y":
                            complete = true;
                            break;
                        case "Y":
                            complete = true;
                            break;
                        case "n":
                            break;
                        case "N":
                            break;
                        default:
                            Console.WriteLine("Please enter Y/N");
                            isCorrectValid = false;
                            Utils.PressToContinue();
                            break;
                    }
                } while (!isCorrectValid);

                SaveChoices();
                
                Utils.PressToContinue();
            } while (!complete);
            Console.Clear();
        }

        public void ChooseName()
        {
            Console.Clear();
            Console.WriteLine("Please enter your character's name");
            myCharacter.Name = Console.ReadLine();
        }

        /// <summary>
        /// Get the class from the user
        /// </summary>
        public void ChooseClass()
        {
            Console.Clear();
            DisplayClasses();
            Console.WriteLine("Please choose your character's class");
            chosenClass = Console.ReadKey().KeyChar;
            Console.WriteLine(Environment.NewLine + "");
        }

        /// <summary>
        /// Show the available classes to the user
        /// </summary>
        public void DisplayClasses()
        {
            Console.WriteLine("Character Classes:");
            Console.WriteLine();
            Console.WriteLine("1) Warrior");
            Console.WriteLine("2) Archer");
            Console.WriteLine("3) Mage");
            Console.WriteLine();
        }

        /// <summary>
        /// Validate the input from the user for the chosen class
        /// </summary>
        /// <returns>Boolean for valid input</returns>
        public bool ValidateClass()
        {
            bool valid = true;
            int classNumber = 0;

            //check if the input was an integer
            try
            {
                classNumber = Int32.Parse(chosenClass.ToString());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please provide an integer value");
                valid = false;
                Utils.PressToContinue();
            }

            //check if the input matches one of the menu options
            if (valid)
            {
                switch (classNumber)
                {
                    case 1:
                        myCharacter.CharacterClass = "warrior";
                        break;
                    case 2:
                        myCharacter.CharacterClass = "archer";
                        break;
                    case 3:
                        myCharacter.CharacterClass = "mage";
                        break;
                    default:
                        Console.WriteLine("Please choose one of the available classes (1-3)");
                        valid = false;
                        Utils.PressToContinue();
                        break;
                }
            }        
            return valid;
        }

        /// <summary>
        /// Get the user's primary and secondary weapon of choice
        /// </summary>
        public void ChooseWeapons()
        {
            Console.Clear();
            DisplayPrimaryWeapons();
            Console.WriteLine("Please choose your primary weapon");
            primaryWeapon = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            DisplaySecondaryWeapons();
            Console.WriteLine("Please choose your secondary weapon");
            secondaryWeapon = Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Show the primary weapons that are available to the user
        /// </summary>
        public void DisplayPrimaryWeapons()
        {
            Console.WriteLine("Primary Weapons");
            Console.WriteLine();
            switch (myCharacter.CharacterClass)
            {
                case "warrior":
                    DisplayWarriorPrimaryWeapons();
                    break;
                case "archer":
                    DisplayArcherPrimaryWeapons();
                    break;
                case "mage":
                    DisplayMagePrimaryWeapons();
                    break;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Show the secondary weapons that are available to the user
        /// </summary>
        public void DisplaySecondaryWeapons()
        {
            Console.WriteLine();
            Console.WriteLine("Secondary Weapons");
            Console.WriteLine();
            switch (myCharacter.CharacterClass)
            {
                case "warrior":
                    DisplayWarriorSecondaryWeapons();
                    break;
                case "archer":
                    DisplayArcherSecondaryWeapons();
                    break;
                case "mage":
                    DisplayMageSecondaryWeapons();
                    break;
            }
            Console.WriteLine();
        }

        public void DisplayWarriorPrimaryWeapons()
        {
            Console.WriteLine("1) Primary 1");
            Console.WriteLine("2) Primary 2");
            Console.WriteLine("3) Primary 3");
        }

        public void DisplayWarriorSecondaryWeapons()
        {
            Console.WriteLine("1) Secondary 1");
            Console.WriteLine("2) Secondary 2");
            Console.WriteLine("3) Secondary 3");
        }

        public void DisplayArcherPrimaryWeapons()
        {
            Console.WriteLine("1) Primary 1");
            Console.WriteLine("2) Primary 2");
            Console.WriteLine("3) Primary 3");
        }

        public void DisplayArcherSecondaryWeapons()
        {
            Console.WriteLine("1) Secondary 1");
            Console.WriteLine("2) Secondary 2");
            Console.WriteLine("3) Secondary 3");
        }

        public void DisplayMagePrimaryWeapons()
        {
            Console.WriteLine("1) Primary 1");
            Console.WriteLine("2) Primary 2");
            Console.WriteLine("3) Primary 3");
        }

        public void DisplayMageSecondaryWeapons()
        {
            Console.WriteLine("1) Secondary 1");
            Console.WriteLine("2) Secondary 2");
            Console.WriteLine("3) Secondary 3");
        }

        public bool ValidateWeapons()
        {
            bool valid = true;
            int primaryWeaponChoice;
            int secondaryWeaponChoice;

            switch (Int32.TryParse(primaryWeapon.ToString(), out primaryWeaponChoice))
            {
                case true:
                    primaryWeaponChoice = Int32.Parse(primaryWeapon.ToString());
                    switch (primaryWeaponChoice)
                    {
                        case 1:
                            weapons[0] = "Primary 1";
                            break;
                        case 2:
                            weapons[0] = "Primary 2";
                            break;
                        case 3:
                            weapons[0] = "Primary 3";
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Please enter a valid menu option for the primary weapon");
                            valid = false;
                            Utils.PressToContinue();
                            break;
                    }
                    
                    if (valid)
                    {
                        switch (Int32.TryParse(secondaryWeapon.ToString(), out secondaryWeaponChoice))
                        {
                            case true:
                                secondaryWeaponChoice = Int32.Parse(secondaryWeapon.ToString());
                                switch (secondaryWeaponChoice)
                                {
                                    case 1:
                                        weapons[1] = "Secondary 1";
                                        break;
                                    case 2:
                                        weapons[1] = "Secondary 2";
                                        break;
                                    case 3:
                                        weapons[1] = "Secondary 3";
                                        break;
                                    default:
                                        Console.WriteLine("");
                                        Console.WriteLine("Please enter a valid menu option for the secondary weapon");
                                        valid = false;
                                        Utils.PressToContinue();
                                        break;
                                }

                                if (valid)
                                {
                                    myCharacter.Weapons = weapons;
                                }
                                break;
                            case false:
                                Console.WriteLine("Please enter an integer value for the secondary weapon choice");
                                Utils.PressToContinue();
                                break;
                        }
                    }
                    break;
                case false:
                    Console.WriteLine("Please provide an integer value for the primary weapon menu choice");
                    valid = false;
                    Utils.PressToContinue();
                    break;
            }

            return valid;
        }

        public void ConfirmChoices()
        {
            Console.Clear();
            Console.WriteLine("Name: {0}", myCharacter.Name);
            Console.WriteLine("Class: {0}", myCharacter.CharacterClass);
            Console.WriteLine("Primary Weapon: {0}", myCharacter.Weapons[0]);
            Console.WriteLine("Secondary Weapon: {0}", myCharacter.Weapons[1]);

            Console.WriteLine("Is this correct? (y/n)");
            isCorrect = Console.ReadKey().KeyChar;
            Console.WriteLine("");
        }

        public void SaveChoices()
        {
            string userInput;
            string path;

            Console.Clear();
            Console.WriteLine("Please enter the path for the save location");
            userInput = Console.ReadLine();
            path = @userInput;

            string[] data = new string[] { myCharacter.Name, myCharacter.CharacterClass, myCharacter.Weapons[0], myCharacter.Weapons[1] };
            string[] successfullySaved = fileSystem.SaveData(path, data);

            if (successfullySaved[1] == "-")
            {
                Console.WriteLine("{0}", successfullySaved[0]);
            }
            else
            {
                Console.WriteLine("{0} {1}", successfullySaved[0], successfullySaved[1]); 
            }
        }
    }
}
