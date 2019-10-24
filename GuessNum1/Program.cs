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
            int result = -1;
            while (true)
            {
                string input_str = Console.ReadLine();

                if (int.TryParse(input_str, out result))
                {

                    result = int.Parse(input_str);

                    break;
                }
                else
                {
                    Console.WriteLine("您輸入的不是數字，請重新輸入一個數字");
                }
            }

            return result;

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
