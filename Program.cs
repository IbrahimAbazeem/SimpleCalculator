using System;
using System.ComponentModel.Design;

class Myclass
{


    //************************  overloading *****************************
    public static void PrintAdd(float x, float y)
    {
        Console.WriteLine($"{x}+{y}={x + y}");
    }
    public static void PrintAdd(float x, float y, float q)
    {
        Console.WriteLine($"{x}+{y}+{q}={x + y + q}");
    }

    //===================================================================




    public static void PrintSubtract(float x, float y)
    {
        Console.WriteLine($"{x}-{y}={x - y}");
    }
    public static void PrintMultiply(float x, float y)
    {
        Console.WriteLine($"{x}x{y}={x * y}");
    }
    public static void PrintDivide(float x, float y)
    {
        Console.WriteLine($"{x}/{y}={x / y}");
    }






    public static void Main(string[] args)
    {
        float x;
        float y;
        float q;
        float k;
        int l;
        int r;
        String F;

        do
        {
            Console.WriteLine("Please choose the corresponding number for your desired operaton.\n 1) Add \n 2) Subtract \n 3) Multiply \n 4) Divide");

            l = int.Parse(Console.ReadLine());
            Console.WriteLine("===================================================");


            switch (l)
            {
                case 1:


                    Console.WriteLine("How many numbers do you have? (2 or 3)");
                    r = int.Parse(Console.ReadLine());


                    switch (r)
                    {
                        case 2:


                            Console.WriteLine("Please enter your two numbers.");
                            Console.Write("Num1 = ");
                            x = int.Parse(Console.ReadLine());
                            Console.Write("Num2 = ");
                            y = int.Parse(Console.ReadLine());
                            Console.WriteLine("===================================================");


                            PrintAdd(x, y);


                            break;

                        case 3:

                            Console.WriteLine("Please enter your three numbers.");
                            Console.Write("Num1 = ");
                            x = int.Parse(Console.ReadLine());
                            Console.Write("Num2 = ");
                            y = int.Parse(Console.ReadLine());
                            Console.Write("Num3 = ");
                            q = int.Parse(Console.ReadLine());
                            Console.WriteLine("===================================================");


                            PrintAdd(x, y, q);

                            break;

                        default:

                            Console.WriteLine("Sorry it is not valid.");

                            break;

                    }
                    break;

                case 2:

                    Console.WriteLine("Please enter your two numbers.");
                    Console.Write("Num1 = ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Num2 = ");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("===================================================");


                    PrintSubtract(x, y);

                    break;


                case 3:

                    Console.WriteLine("Please enter your two numbers.");
                    Console.Write("Num1 = ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Num2 = ");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("===================================================");


                    PrintMultiply(x, y);

                    break;


                case 4:

                    Console.WriteLine("Please enter your two numbers.");
                    Console.Write("Num1 = ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Num2 = ");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("===================================================");


                    if (y == 0)
                    {
                        Console.WriteLine("Divition by zero is not valid.");
                    }
                    else
                    {
                        PrintDivide(x, y);
                    }

                    break;


                default:

                    Console.WriteLine("===================================================");

                    Console.WriteLine("Not valid");

                    break;


            }
            Console.WriteLine("===================================================");

            Console.WriteLine("Do you want to perform another operation?");
            Console.WriteLine("Please enter yes or no.");
            F = Console.ReadLine();

            Console.WriteLine("===================================================");


        }

        while (F == "YES" || F == "yes");

    }
}
