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
                Console.WriteLine("3. Find maximum among three strings");
                Console.WriteLine("4. Find maximum among int, float, string using generic method");
                Console.WriteLine("5. Find max among three using generic class");
                Console.WriteLine("6. Find max from more than three parameters using generic class");

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
                    case 3:
                        MaxAmongThree maxAmongThree2 = new MaxAmongThree();

                        //Test case 1 : Max String in First position
                        Console.WriteLine("Maximum string is : " + maxAmongThree2.MaxAmongThreeString("3", "2", "1"));

                        //Test case 2 : Max String in Second position
                        Console.WriteLine("Maximum string is : " + maxAmongThree2.MaxAmongThreeString("1", "3", "2"));

                        //Test case 3 : Max String in Third position
                        Console.WriteLine("Maximum string is : " + maxAmongThree2.MaxAmongThreeString("1", "2", "3"));
                        break;
                    case 4:
                        MaxAmongThreeGeneric maxAmongThreeGeneric = new MaxAmongThreeGeneric();

                        //Test case for integer
                        Console.WriteLine("Maximum integer is : " + maxAmongThreeGeneric.MaxAmongThree(3, 2, 1));
                        Console.WriteLine("Maximum integer is : " + maxAmongThreeGeneric.MaxAmongThree(1, 3, 2));
                        Console.WriteLine("Maximum integer is : " + maxAmongThreeGeneric.MaxAmongThree(1, 2, 3));

                        //Test case for float
                        Console.WriteLine("Maximum float number is : " + maxAmongThreeGeneric.MaxAmongThree(3.1f, 2.1f, 1.1f));
                        Console.WriteLine("Maximum float number is : " + maxAmongThreeGeneric.MaxAmongThree(1.1f, 3.1f, 2.1f));
                        Console.WriteLine("Maximum float number is : " + maxAmongThreeGeneric.MaxAmongThree(1.1f, 2.1f, 3.1f));

                        //Test case for string
                        Console.WriteLine("Maximum string is : " + maxAmongThreeGeneric.MaxAmongThree("3", "2", "1"));
                        Console.WriteLine("Maximum string is : " + maxAmongThreeGeneric.MaxAmongThree("1", "3", "2"));
                        Console.WriteLine("Maximum string is : " + maxAmongThreeGeneric.MaxAmongThree("1", "2", "3"));
                        break;
                    case 5:
                        //Test case for Integer
                        MaxAmongThreeGenericClass<int> maxInt = new MaxAmongThreeGenericClass<int>(1, 2, 3);
                        Console.WriteLine("Maximum integer is : " + maxInt.TestMaximum());

                        //Test case for Float
                        MaxAmongThreeGenericClass<float> maxFloat = new MaxAmongThreeGenericClass<float>(1.1f, 2.1f, 3.1f);
                        Console.WriteLine("Maximum float is : " + maxFloat.TestMaximum());

                        //Test case for String
                        MaxAmongThreeGenericClass<string> maxString = new MaxAmongThreeGenericClass<string>("a", "aa", "aaa");
                        Console.WriteLine("Maximum string is : " + maxString.TestMaximum());
                        break;
                    case 6:
                        //Test case for Integer
                        int[] intArray = { 1, 2, 5, 3, 4 };
                        MaxAmongMoreThanThree<int> moreThanThreeInt = new MaxAmongMoreThanThree<int>(intArray);
                        Console.WriteLine("Maximum value is : " + moreThanThreeInt.FindMaxMethod());

                        //Test case for Float
                        float[] floatArray = { 1.1f, 2.2f, 5.5f, 3.3f, 4.4f };
                        MaxAmongMoreThanThree<float> moreThanThreeFloat = new MaxAmongMoreThanThree<float>(floatArray);
                        Console.WriteLine("Maximum value is : " + moreThanThreeFloat.FindMaxMethod());

                        //Test case for String
                        string[] stringArray = { "a", "aa", "aaaaa", "aaa", "aaaa" };
                        MaxAmongMoreThanThree<string> moreThanThreeString = new MaxAmongMoreThanThree<string>(stringArray);
                        Console.WriteLine("Maximum value is : " + moreThanThreeString.FindMaxMethod());
                        break;
                    default:
                        Console.WriteLine("Please choose correct option from the list");
                        break;
                }
            } while (choice != 0);
        }
    }
}