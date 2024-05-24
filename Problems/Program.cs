using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Problems
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("MS-Testing");
        }
        public static bool Armstrong(int num)
        {
            string number = num.ToString();
            double sum = 0;
            int temp=num;
            while(temp > 0)
            {
                sum += Math.Pow(temp % 10, number.Length);
                temp /= 10;
                Console.WriteLine(sum);
            }
            return num==(int)sum;
        }
        public static List<int> EvenNumberOnly(int[] nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 == 0) { result.Add(num); }
            }
            return result;
        }
        public static string CharacterCheckMethod(string str)
        {

            if (str is not null && str.IndexOf('a') != -1 && str.IndexOf('e') != -1 && str.IndexOf('p') != -1)
            {
                return "All Present";
            }
            else if (str is not null && (str.IndexOf('a') != -1 || str.IndexOf('e') != -1 || str.IndexOf('p') != -1))
            {
                return "One or More - Present";
            }
            else
            {
                return "None Present";
            }
        }
        public static bool Prime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        public static long Factorial(int num)
        {
            try
            {
                if (num < 0) throw new NegativeNumberException();
                if (num == 0) return 1;
                return num * Factorial(num - 1);
            }
            catch (NegativeNumberException)
            {
                return -1;
            }
        }

    }
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
            Console.WriteLine("Negative number not applicable for this method");
        }
    }
}