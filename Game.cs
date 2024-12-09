using OOPAssessment2V2;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Menu = true;
        while (Menu == true)
        {
            Menu = MainMenu();
        }

        static bool MainMenu()
        {
            Console.WriteLine("Please select your option:");
            Console.WriteLine("1) Sevens Out");
            Console.WriteLine("2) Three or More");
            Console.WriteLine("3) View statstics data");
            Console.WriteLine("4) Perform tests");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    var SevensOut = new SevensOut();
                    SevensOut.start();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            return MainMenu();
        }
    }
        public class SevensOut

        {
        public void start()
        {

            Console.WriteLine("Sevens Out will now begin...");

            Die roll1 = new Die();
            Die roll2 = new Die();

            Console.WriteLine($"\nOne dice rolled a {roll1}");
            Console.WriteLine($"\nOne dice rolled a {roll2}");



        }

    }

}
    


