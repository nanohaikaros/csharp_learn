#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace OverloadedIndexer
{
    public class ListBoxTest
    {
        public ListBoxTest(params string[] initialStrings)
        {
            StringSplitOptions = new String[256];

            foreach (string s in initialStrings)
            {
                strings[ctr++] = s;
            }
        }

        public void Add(string theString)
        {
            strings[ctr] = theString;
            ctr++;
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
                strings[index] = value;
            }
        }

        private int findString(string searchString)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].StartsWith(searchString))
                {
                    return i;
                }
            }
            return -1;
        }

        public string this[string index]
        {
            get
            {
                if (index.Length == 0)
                {

                }
                return this[findString(index)];
            }
            set
            {
                strings[findString(index)] = value;
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
            lbt["Hel"] = "GoodBye";

            for (int i = 0; i < lbt.GetNumEntries(); i++)
            {
                Console.WriteLine("lbt[{0}]: {1}", i, lbt[i]);
            }
        }
    }
}