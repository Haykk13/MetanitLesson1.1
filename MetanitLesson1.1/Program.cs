using System;

namespace MetanitLesson1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int second = int.Parse(Console.ReadLine());

            if(first > second)
            {
                Console.WriteLine($"{first} > {second}");
            }
            else if(first < second)
            {
                Console.WriteLine($"{first} < {second}");
            }
            else
            {
                Console.WriteLine($"{first} = {second}");
            }

            Console.ReadLine();
        }
    }
}
