// System namespace nedded to use Console class.
using System;

// my collection of classes for this project.
namespace Variables_Sadler_Madison
{
    //Main class for the program
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
            // Declares an integer named favoriteNumber
            int favoriteNumber;
            // Bools named isJumping and isRunning are initialized to false
            bool isJumping = false, isRunning = false;
            // Declares a random float variable named floatVariable
            float floatVariable;
            // Assigns favoriteNumber to 13
            favoriteNumber = 13;
            // Assigns floatVariable to 17.32
            floatVariable = 17.32f;
            //Initializes a constant double named finalGrade and sets to 90
            const double finalGrade = 90.0;

            // Prints all variables to Console
            Console.WriteLine(favoriteNumber);
            Console.WriteLine(isJumping);
            Console.WriteLine(isRunning);
            Console.WriteLine(floatVariable);
            Console.WriteLine(finalGrade);
        }
    }
}
