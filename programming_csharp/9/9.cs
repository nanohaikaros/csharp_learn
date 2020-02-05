#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace SimpleIndexer
{
    public class ListBoxTest
    {
        public ListBoxTest(params string[] initialStrings)
        {
            strings = new String[256];

            foreach (string s in initialStrings)
            {
                strings[ctr++] = s;
            }
        }

        public void Add(string theString)
        {
            if (ctr >= strings.Length)
            {

            }
            else
                StringSplitOptions[ctr++] = theString;
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strings.Length)
                {

                }
                return strings[index];
            }
            set
            {
                if (index >= ctr)
                {

                }
                else
                    strings[index] = value;
            }
        }

        public int GetNumEntries()
        {
            return ctr;
        }

        private string[] strings;
        private int ctr = 0;
    }

    public class Tester
    {
        static void Main()
        {
            ListBoxTest lbt = new ListBoxTest("Hello", "World");

            lbt.Add("Who");
            lbt.Add("Is");
            lbt.Add("John");
            lbt.Add("Galt");

            string subst = "Universe";
            lbt[1] = subst;

            for (int i = 0; i < lbt.GetNumEntries(); i++)
            {
                Console.WriteLine("lbt[{0}]: {1}", i, lbt[i]);
            }
        }
    }
}