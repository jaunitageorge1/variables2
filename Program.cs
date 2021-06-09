using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Info");
            string yourName = Console.ReadLine();
            int yourAge = 5;
            bool isFriend = true;
            char myFav = '@';
            decimal num1 = 21.5m;
            double num2 = 21.5; 

            Console.WriteLine($"Your Name is {yourName}. Your Age is {yourAge}. It is {isFriend} that you are a friend. Your favorite special character is the {myFav} symbol. You have a favorite number too, and in C#, that's written in decimal form like this: {num1}, and in double form like {num2}.");
        }
    }
}
