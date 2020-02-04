using System;
using System.Collections.Generic;
using System.Text;

namespace usingStatement
{
    class Tester
    {
        public static void Main()
        {
            using (Font theFont = new Font("Arial", 10.0f))
            {

            }

            Font anotherFont = new Font("Courier", 12.0f);

            using (anotherFont)
            {

            }
        }
    }
}