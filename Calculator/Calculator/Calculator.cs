using System;
using System.Collections.Generic;

namespace Calculator
{
    class MainInterface
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Calculator");
            Console.WriteLine();

            bool valid = false;
            while (!valid)
            {
                valid = true;
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiplication");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Square");
                Console.WriteLine("6) Square root");
                Console.WriteLine("0) Quit");
                Console.WriteLine();

                ConsoleKeyInfo menuChoice = GetMenuInput();

                switch (menuChoice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        DisplayAddition();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        DisplaySubtraction();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        DisplayMultiplication();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        DisplayDivision();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        DisplaySquare();
                        valid = true;
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        DisplaySquareRoot();
                        valid = true;
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        valid = true;
                        break;

                    default:
                        valid = false;
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid menu choice (1-6 or 0 to quit)");
                        Console.WriteLine();
                        break;
                }
            }
            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadLine();
        }

        private static void DisplaySquare()
        {
            throw new NotImplementedException();
        }

        private static void DisplaySquareRoot()
        {
            throw new NotImplementedException();
        }

        private static void DisplayDivision()
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                List<String> inputs = GetCalcInput();
                if (inputs.Count == 1)
                {
                    quit = true;
                }

                if (!quit)
                {
                    Console.WriteLine("> {0} / {1} = {2}", inputs[0], inputs[1], (Int32.Parse(inputs[0]) / Int32.Parse(inputs[1])));
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue");
                Console.ReadLine();
                Console.WriteLine();
            }
            Main();
        }

        private static void DisplayMultiplication()
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                List<String> inputs = GetCalcInput();
                if (inputs.Count == 1)
                {
                    quit = true;
                }

                if (!quit)
                {
                    Console.WriteLine("> {0} * {1} = {2}", inputs[0], inputs[1], (Int32.Parse(inputs[0]) * Int32.Parse(inputs[1])));
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue");
                Console.ReadLine();
                Console.WriteLine();
            }
            Main();
        }

        private static void DisplaySubtraction()
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                List<String> inputs = GetCalcInput();
                if (inputs.Count == 1)
                {
                    quit = true;
                }

                if (!quit)
                {
                    Console.WriteLine("> {0} - {1} = {2}", inputs[0], inputs[1], (Int32.Parse(inputs[0]) - Int32.Parse(inputs[1])));
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue");
                Console.ReadLine();
                Console.WriteLine();
            }
            Main();
        }

        private static void DisplayAddition()
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                List<String> inputs = GetCalcInput();
                if (inputs.Count == 1)
                {
                    quit = true;
                }

                if (!quit)
                {
                    Console.WriteLine("> {0} + {1} = {2}", inputs[0], inputs[1], (float.Parse(inputs[0]) + float.Parse(inputs[1])));
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue");
                Console.ReadLine();
                Console.WriteLine();
            }
            Main();
        }

        private static List<String> GetCalcInput()
        {
            int counter = 0;
            float tempNum = 0.0f;
            bool valid = false;
            bool done = false;

            List<String> numbers = new List<String>();

            while (!done)
            {
                do
                {
                    valid = true;
                    Console.WriteLine("Please enter a number, or enter b to go back");
                    Console.Write("> ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine();
                    if (float.TryParse(userInput, out tempNum) == true)
                    {
                        numbers.Add(userInput);

                        if (counter == 0)
                            counter += 1;

                        else if (counter == 1)
                            done = true;
                    }

                    else if (userInput == "b" || userInput == "B")
                    {
                        numbers.Add(userInput);
                        done = true;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number or b to go back");
                        Console.WriteLine();
                        valid = false;
                    }
                } while (!valid);
            }

            return numbers;
        }

        private static ConsoleKeyInfo GetMenuInput()
        {
            ConsoleKeyInfo menuChoice;

            Console.WriteLine("Please enter a choice from the menu");
            Console.Write("> ");
            menuChoice = Console.ReadKey();
            Console.WriteLine();

            return menuChoice;
        }
    }
}
