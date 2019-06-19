using System;

namespace Task1
{
    class Program
    {
        static int func(int number)
        {
            int num = 0;
            if (number <= 9)
                return number;
            
            if(number > 9)
            {
                int qanordyMnacordov = number % 10;
                number = number / 10;
                num = number + qanordyMnacordov;
                
            }
            return func(num);
        }
        static void Main(string[] args)
        {
            for (;;)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int result = func(number);
                Console.WriteLine(result);
            }
            
        }
    }
}
