using System;

namespace Lab4TriangleDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 to display full triangle.");
                Console.WriteLine("Enter 2 to display partial triangle.");
                Console.WriteLine("Enter 3 to display full pyramid.");
                Console.WriteLine("Enter 4 to display partial pyramid.");
                Console.WriteLine("Enter 5 to exit.");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    GetFull();
                }
                else if (choice == 2)
                {
                    GetPartial();
                }
                else if (choice == 3)
                {
                    GetPyramid();
                }
                else if (choice == 4)
                {
                    GetPartialPyramid();
                }
                else if (choice == 5)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void GetFull()
        {
            Random rnd = new Random();
            int rows = rnd.Next(3, 10);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("O ");
                }
                Console.WriteLine();
            }
        }

        static void GetPartial()
        {
            Random rnd = new Random();
            int rows = rnd.Next(3, 10);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int number = rnd.Next(2);
                    if (number == 0)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void GetPyramid()
        {
            Random rnd = new Random();
            int rows = rnd.Next(3, 10);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                Console.Write("O ");
                }
            Console.WriteLine();
            }
        }

        static void GetPartialPyramid()
        {
            Random rnd = new Random();
            int rows = rnd.Next(3, 10);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (rnd.Next (0,2) == 1)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();  
            }   
        }
    }
}