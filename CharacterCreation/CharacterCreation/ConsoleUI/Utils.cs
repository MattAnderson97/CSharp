using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation.ConsoleUI
{
    /// <summary>
    /// A group of methods that are used throughout the Console UI
    /// </summary>
    static class Utils
    {
        /// <summary>
        /// Method to make the program wait for a keypress to proceed with operations
        /// </summary>
        public static void PressToContinue()
        {
            Console.WriteLine(Environment.NewLine + "Press any key to continue");
            Console.ReadKey();
        }
    }
}
