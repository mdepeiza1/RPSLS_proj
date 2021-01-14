using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Gesture
    {
        public string name;
        public int identifier; // how could I validate a string choice?
        // when the user inputs a string, we have to make it into something
        // we can run comparison/validation logic
        public Gesture()
        {

        }
    }
}
