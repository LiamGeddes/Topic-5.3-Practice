namespace Topic_5._3_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Console.WriteLine("What is your favourite pizza topping?");
            string topping = Console.ReadLine();

            if (topping == "pepperoni" || topping == "bacon")
            {
                Console.WriteLine("Yum!");
            }
            else
            {
                Console.WriteLine("That is not one of my favourite toppings.");
            }

            //task 1
            Console.WriteLine("How old are you?");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            if (age >= 60 ||  age <= 12)
            {
                Console.WriteLine("Your bus pass costs $2.00.");
            }
            else
            {
                Console.WriteLine("Your bus pass costs $3.50.");
            }

            //task 2
            Console.WriteLine("What is your favourite animal?");
            string animal = Console.ReadLine();

            if (animal == "cat" || animal == "dog")
            {
                Console.WriteLine("Me Too");
            }
            else
            {
                Console.WriteLine("To each their own");
            }


            //task 3
            Console.WriteLine("What is the tempature outside?");
            int tempature;
            int.TryParse (Console.ReadLine(), out tempature);

            Console.WriteLine(" Is it sunny or cloudy?");
            String weather = Console.ReadLine();

            if (weather == "sunny" || tempature > 25)
            {
                Console.WriteLine("Swim Time");
            }
            else
            {
                Console.WriteLine("Nap Time");
            }



            // Task 4
            Console.WriteLine("How much money do you have?");
            double money;
            double.TryParse(Console.ReadLine(), out money);

            Console.WriteLine("Are you working?");
            String working = Console.ReadLine();

            if (money >= 20 && working == "no")
            {
                Console.WriteLine("You can go to the movie.");
            }
            else
            {
                Console.WriteLine("You cannot go to the movie.");
            }

            //Task 5 
            Console.WriteLine("Enter the password:");
            string password = Console.ReadLine();

            Console.WriteLine("How many guesses did you take?");
            int guesses;
            int.TryParse(Console.ReadLine(), out guesses);

            if (password == "Santa" && guesses < 5)
            {
                Console.WriteLine("Open sesame");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            //Task 6
            Console.WriteLine(" How old are you?");
            int.TryParse(Console.ReadLine(), out age);

            if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }








        }
    }
}
