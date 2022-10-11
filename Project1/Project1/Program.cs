using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Show();
        }

        private static void Show()
        {
            int n = 256;
            int pad = 8;

            for (int i = 0; i < n; i++)
            {
                ShowPad(i, pad);
            }


        }

        private static void ShowPad(int i, int pad)
        {
            Stack<int> stack = new Stack<int>();
            while (i > 0)
            {
                stack.Push(i % 2);
                i = i / 2;
            }

            int z = pad - stack.Count; 
            for (int j = 0; j < z; j++)
            {
                stack.Push(0);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
