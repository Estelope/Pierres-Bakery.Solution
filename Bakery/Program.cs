using System;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Bread bread = new Bread(5, 3);
            Pastry pastry = new Pastry(2, 4);
            Console.Write("Enter the number of loaves of Bread: ");
                if (int.TryParse(Console.ReadLine(), out int breadQuantity))   //TryParse lets input validation happen wihtout exiting conosole
            {
                int breadCost = bread.CalculateBreadCost(breadQuantity);

            Console.Write("Enter the number of Pastries: ");
                if (int.TryParse(Console.ReadLine(), out int pastryQuantity))
                {
                    int pastryCost = pastry.CalculatePastryCost(pastryQuantity);
                    int totalCost = BakeryUtility.CalculateTotalCost(breadCost, pastryCost);

                    Console.WriteLine($"Total cost for Bread: ${breadCost}");
                    Console.WriteLine($"Total cost for Pastries: ${pastryCost}");
                    Console.WriteLine($"Total cost for the order: ${totalCost}");
                }
                else
                {
                    Console.WriteLine("Invalid input for Pastries. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for Bread. Please enter a valid number.");
            }
        }
    }
}
