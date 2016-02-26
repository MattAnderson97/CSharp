using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Character
    {
        private string name = " ";
        private string characterClass = " ";
        private string[] weapons = new string[2];

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string CharacterClass
        {
            get
            {
                return characterClass;
            }

            set
            {
                characterClass = value;
            }
        }

        public string[] Weapons
        {
            get
            {
                return weapons;
            }

            set
            {
                weapons = value;
            }
        }

    }
}
