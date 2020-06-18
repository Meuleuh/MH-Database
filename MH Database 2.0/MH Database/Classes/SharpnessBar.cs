using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Database.Classes
{
    class SharpnessBar
    {
        //Variables
        internal int 
            red,
            orange,
            yellow,
            green,
            blue,
            white,
            purple;

        //Constructor
        internal SharpnessBar(int redToSet = 0, int orangeToSet = 0, int yellowToSet = 0, int greenToSet = 0, int blueToSet = 0, int whiteToSet = 0, int purpleToSet = 0)
        {
            red = redToSet;
            orange = orangeToSet;
            yellow = yellowToSet;
            green = greenToSet;
            blue = blueToSet;
            white = whiteToSet;
            purple = purpleToSet;
        }
    }
}
