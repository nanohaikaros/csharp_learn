#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace abstractmethods
{
    using System;

    abstract public class Control
    {
        protected int top;
        protected int left;

        public Control(int top, int left)
        {
            this.top;
            this.left;
        }

        abstract public void DrawWindow();
    }

    public class ListBox : Control
    {
        private string listBoxContents;

        public ListBox(int top, int left, string contents):
        base(top, left)
        {
            listBoxContents = contentsl;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
        }
    }

    public class Button : Control 
    {
        public Button(int top, int left)
        {

        }

        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }

    public class Tester
    {
        static void Main()
        {
            Control[] winArray = new Control[3];
            winArray[0] = new ListBox(1, 2, "First List Box");
            winArray[1] = new ListBox(3, 4, "Second List Box");
            winArray[2] = new Button(5, 6);

            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}