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
            Console.ReadKey();
        }

        private static void Show()
        {
            int n = 256;
            int pad = 8;

            int[] set = new int[pad];
            Random random = new Random();
            for (int j = 0; j < pad; j++)
                set[j] = random.Next(100);

            for (int i = 0; i < n; i++)
            {
                ShowPad(i, pad, set);
            }


        }

        private static void ShowPad(int i, int pad, int[] set)
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

            for (int j = 0; j < pad; j++)
            {
                if (stack.Pop() == 1)
                {
                    Console.Write("{0} ", set[j]);
                }
            }
            Console.WriteLine();
            


            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}
            //Console.WriteLine();
        }
    }
}
