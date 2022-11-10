using System;

namespace ITMO.CSCourse2022.Lab1.Ex4
{
    internal class DivideIt
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);

            Console.WriteLine("Please enter the second integer");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);
            try
            {
                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k); ;
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
        }
    }
}
