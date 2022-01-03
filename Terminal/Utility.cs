using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    internal class Utility
    {
        static public bool IsPrintableCharacter(char candidate)
        {
            return !(candidate < 0x20 || candidate > 126);
        }
    }
}
