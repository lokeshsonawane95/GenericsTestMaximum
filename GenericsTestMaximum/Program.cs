using System;
namespace GenericsTestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Find maximum among three integers");
                Console.WriteLine("2. Find maximum among three floats");

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MaxAmongThree maxAmongThree = new MaxAmongThree();

                        //Test case 1 : Max Number in First position
                        Console.WriteLine("Maximum integer is : " + maxAmongThree.MaxAmongThreeInt(3, 2, 1));

                        //Test case 2 : Max Number in Second position
                        Console.WriteLine("Maximum integer is : " + maxAmongThree.MaxAmongThreeInt(1, 3, 2));

                        //Test case 3 : Max Number in Third position
                        Console.WriteLine("Maximum integer is : " + maxAmongThree.MaxAmongThreeInt(1, 2, 3));
                        break;
                    case 2:
                        MaxAmongThree maxAmongThree1 = new MaxAmongThree();

                        //Test case 1 : Max Number in First position
                        Console.WriteLine("Maximum float number is : " + maxAmongThree1.MaxAmongThreeFloat(3.1f, 2.1f, 1.1f));

                        //Test case 2 : Max Number in Second position
                        Console.WriteLine("Maximum float number is : " + maxAmongThree1.MaxAmongThreeFloat(1.1f, 3.1f, 2.1f));

                        //Test case 3 : Max Number in Third position
                        Console.WriteLine("Maximum float number is : " + maxAmongThree1.MaxAmongThreeFloat(1.1f, 2.1f, 3.1f));
                        break;
                    default:
                        Console.WriteLine("Please choose correct option from the list");
                        break;
                }
            } while (choice != 0);
        }
    }
}