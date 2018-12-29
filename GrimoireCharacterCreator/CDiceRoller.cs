using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrimoireCharacterCreator
{
    class CDiceRoller
    {
        private static Random Rand = new Random();

        public static int RollD20()
        {
            return Rand.Next(1, 21);
        }
        public static int RollD12()
        {
            return Rand.Next(1, 13);
        }
        public static int RollD10()
        {
            return Rand.Next(1, 11);
        }
        public static int RollD8()
        {
            return Rand.Next(1, 9);
        }
        public static int RollD6()
        {
            return Rand.Next(1, 7);
        }
        public static int RollD4()
        {
            return Rand.Next(1, 5);
        }
    } 
}
