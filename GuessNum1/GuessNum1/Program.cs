using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        public static int GetInput()
        {
            string input_str = Console.ReadLine();
            return int.Parse(input_str);
        }

        static void Main(string[] args)
        {
            int answer = new Random().Next(100);
            int guess = 0;
            int max = 100;
            int min = 1;
            Console.WriteLine(answer); //debug answer

            while (true)
            {

                Console.WriteLine(min + " 到 " + max);

                guess = GetInput();

                if (guess == answer)
                {
                    break;
                }

                if (guess > max || guess < min)
                {
                    Console.WriteLine("錯誤!\n");
                }

                else if (guess > answer)
                {
                    max = guess;
                    Console.WriteLine("答案更小!\n");
                }

                else if (guess < answer)
                {
                    min = guess;
                    Console.WriteLine("答案更大!\n");
                }

            }

            Console.WriteLine("答對了！");
            Console.ReadKey();

        }
    }

}
