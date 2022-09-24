using System;

namespace Deliverable2
{
    class Progam
    {
        static void Main(string[] args)
        {
            int numPeople, totalWater = 0, totalCoffee = 0;
            decimal totalPrice;
            const decimal BUFFET_PRICE = 9.99M, COFFEE_PRICE = 2.00M;

            string drinkName;

            Console.WriteLine("Hi. Welcome to our Buffet.  All you can eat for $9.99!  We only charge extra for coffee.\n");
            Console.WriteLine("How many people are in your group?  Please, parties of 6 or lower.");
            numPeople = int.Parse(Console.ReadLine());

            if (numPeople > 0 && numPeople < 7)
            {
                Console.WriteLine("\nA table for " + numPeople + "!  Please follow me and take a seat.");
                Console.WriteLine("Let's get everyone started with some drinks.  We've got water or coffee.\n");

                for (int i = 1; i <= numPeople; i++)
                {
                    Console.Write("Alright, person number " + i + ", water or coffee? ");
                    drinkName = Console.ReadLine();

                    if (drinkName == "water")
                    {
                        Console.WriteLine("Water, good choice!\n");
                        totalWater++;
                    }

                    else if (drinkName == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!\n");
                        totalCoffee++;
                    }

                    else
                        Console.WriteLine("We don't have that.  No drink for you!\n");
                }

                Console.WriteLine("Okay, so that's " + totalCoffee + " coffees and " + totalWater + " waters.  I'll be right back.");
                Console.WriteLine("Feel free to grab your food!\n");

                totalPrice = BUFFET_PRICE * numPeople + COFFEE_PRICE * totalCoffee;
                Console.WriteLine("Here's your bill!  Total price: $" + totalPrice + "\n");
                Console.WriteLine("Order details:");
                Console.WriteLine(numPeople + " buffets = " + numPeople + " x 9.99 = " + numPeople * BUFFET_PRICE);
                Console.WriteLine(totalCoffee + " coffees = " + totalCoffee + " x " + COFFEE_PRICE + " = " + totalCoffee * COFFEE_PRICE);
                Console.WriteLine(totalWater + " waters = free");
                Console.WriteLine("total = " + totalPrice);
            }

            else
                Console.WriteLine("Oh, sorry, can only seat parties up to 6.  Have a nice day.");
        }
    }
}