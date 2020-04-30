using System;
using System.Linq;
using System.Threading;

namespace Lab_8_Get_to_Know_Your_CLassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jimmy", "Jane", "Jackie", "Jen", "Joseph" };
            string[] favoriteFoods = { "Lobster", "Crab", "Fish", "Clams", "Peanut Butter" };
            string[] hometown = { "Detroit", "Warren", "Ferndale", "Madison Heights", "Troy" };

            Console.WriteLine("Welcome to the Student Database!");
           
            names.ToList().ForEach(i => Console.WriteLine(i.ToString()));  

            bool loopAgain = true;
            while (loopAgain)
            {
            Console.WriteLine($"Please select a number from 0 to {names.Length-1}");
            string input= Console.ReadLine();
            int index = 0;
            string name = "";

            try
            {
                index = int.Parse(input);
                
                if(index >=0 &&  index < names.Length)
                {
                    name = names[index];
                }
                else
                {
                    throw new Exception($"That number is outside the range of 0 to {names.Length - 1}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid response, please try again!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (name != "")
            {
                Console.WriteLine($"You selected {name}!");

                Console.WriteLine($"To learn more about {name}, type 'ff' for favorite food or 'ht' for hometown.");
                    
                string response = Console.ReadLine();

                    
                    if (response == "ff")
                    {
                        Console.WriteLine($"The favorite food of {name} is {favoriteFoods[index]}");

                    }
                    else if (response == "ht")
                    {
                        Console.WriteLine($"The hometown of {name} is {hometown[index]}");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not a valid answer. Let's try again");
                        continue;
                    }
            }
                        

                Console.WriteLine("Would you like to learn about another student? (y to continue) or any other key to quit");
                string again = Console.ReadLine();

                if (again == "y")
                {
                    loopAgain = true;
                }
                else
                {
                    loopAgain = false;
                    
                }
            }
        }
    }
}
