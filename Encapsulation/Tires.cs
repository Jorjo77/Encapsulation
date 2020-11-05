using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Tires
    {
        private int kilometers;

        public void Drive(int km)
        {
            kilometers += km;
        }
        public bool IsRubbish()
        {
            if (kilometers>=20000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
