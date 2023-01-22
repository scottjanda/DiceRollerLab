using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public static class DiceMethods
    {
        private static Random getRandom = new Random();
        public static int DiceRoll(int sides) {
            return getRandom.Next(1, sides);
            //return random.Next(1, sides);
        }
    }
}