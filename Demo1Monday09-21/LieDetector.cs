using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Monday09_21
{
    internal class LieDetector
    {
        public bool CheckLie()
        {
            Random random = new Random();
            int resultat = random.Next(0,2);

            return resultat == 1;
        }
    }
}
