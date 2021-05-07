using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "John";
            string lastName = "Doe";
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);
            int myNum = 15;
            Console.WriteLine(myNum);
            myNum = 20; // my number is now 20
            Console.WriteLine(myNum);
            Console.WriteLine("Hello " + fullName);
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
            int minutesperhour = 60;
            Console.WriteLine(minutesperhour);
            int newNum = 100000;
            Console.WriteLine(newNum);
            long newerNum = 15000000000L;
            Console.WriteLine(newerNum);
            float decimalNum = 34.56F;
            Console.WriteLine(decimalNum);
            double newDecimalNum = 2.65748957;
            Console.WriteLine(newDecimalNum);
            float f1 = 34e6F;
            double d2 = 54E5;
            Console.WriteLine(f1);
            Console.WriteLine(d2);
            bool sushiIsGood = true;
            bool shrimpIsGood = false;
            Console.WriteLine(sushiIsGood);
            Console.WriteLine(shrimpIsGood);
            Console.WriteLine("Sushi is good " + sushiIsGood.ToString().ToLower());
            Console.WriteLine("Shrimp is good " + shrimpIsGood.ToString().ToLower());
            Console.WriteLine("Sushi is " + IsGood(sushiIsGood));
            Console.WriteLine("Shrimp is " + IsGood(shrimpIsGood));

            char myGrade = 'A';
            Console.WriteLine(myGrade);
            string sentence = ("One day I will make a mod for the Sims 4.");
            Console.WriteLine(sentence);
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
        }

        private static string IsGood(bool value)
        {
            if (value == true)
            {
                return "good";
            }
            return "bad";
        }


    }
}