using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int sumNum = 0;
            bool toe = false;
            for (int i = 1; i <= num; i++)
            {
                sumNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", sumNum, toe);
                sum = 0;
                i = sumNum;
            }




        }
    }
}
