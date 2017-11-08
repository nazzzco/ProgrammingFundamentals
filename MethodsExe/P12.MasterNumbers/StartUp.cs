using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.MasterNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (IsPalidrome(i) || IsDivisibleBy7(i) || HasEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasEvenDigit(int num)
        {
            string numb = num.ToString();
            for (int i = 0; i < numb.Length; i++)
            {
                if ((int.Parse(numb[i].ToString()) % 2) == 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
                
            }
            return false;
        }

        static bool IsDivisibleBy7(int num)
        {
            string numb = num.ToString();
            int sum = 0;
            for (int i = 0; i < numb.Length; i++)
            {

                sum += numb[i];
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPalidrome(int num)
        {
            int div = 1;
            while (num / div >= 10)
            {
                div *= 10;
            }
            while (num != 0)
            {
                int l = num / div;
                int r = num % 10;
                if (l != r)
                {
                    return false;
                }
                num = (num % div) / 10;
                div /= 100;
            }
            return true;
        }
    }
}
