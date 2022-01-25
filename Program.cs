using System;

namespace Intro
{
    public class Program
    {
         
        public static void Main(string[] args)
        {
            //make a random number to guess
            int secretNumber = new Random().Next(1, 100);
            //Ask user for users name
            Console.Write("What is your name? ");
            //Save users name as "name"
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! I'm glad to meet you.");
            //Ask user how difficult they want the game to be
            Console.WriteLine("How difficult do you want this to be? easy, medieum, hard, or cheater?");
            //Save answer as "difficulty" with lower case letter
            string? difficulty = Console.ReadLine().ToLower();
            
            if (difficulty == "easy"){
                Console.WriteLine("You have 8 guesses to figure out what your luck number is! What is your first guess?");
                
                //while loop while(i<4)...in conditional i++

                for (int i = 0; i < 8; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                //could also be number = int.Parse(Console.Readline())
                if (number == secretNumber){
                    Console.WriteLine($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (i < 7 ) {
                    if (number > secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too high. Attempts left: {7 - i}:");
                    }
                    if (number < secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too low. Attempts left: {7 - i}:");
                    }
                    } else {
                        Console.WriteLine($"Sorry {name}, the number was {secretNumber}. Please try again");
                    }
                    
                }
                }
            }
            else if (difficulty == "medium"){
                Console.WriteLine("You have 6 guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i < 6; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.WriteLine($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (i < 5 ) {
                    if (number > secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too high. Attempts left: {5 - i}:");
                    }
                    if (number < secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too low. Attempts left: {5 - i}:");
                    }
                    } else {
                        Console.WriteLine($"Sorry {name}, the number was {secretNumber}. Please try again");
                    }
                    
                }
                }
            }
            else if (difficulty == "hard"){
                Console.WriteLine("You have 4 guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i < 4; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.WriteLine($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (i < 3 ) {
                    if (number > secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too high. Attempts left: {3 - i}:");
                    }
                    if (number < secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too low. Attempts left: {3 - i}:");
                    }
                    } else {
                        Console.WriteLine($"Sorry {name}, the number was {secretNumber}. Please try again");
                    }
                }
                }
            }
            else if (difficulty == "cheater") {
                Console.WriteLine("You have unlimited guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i == i; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.WriteLine($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (number > secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too high. Attempts {i + 1}. Guess again:");
                    }
                    if (number < secretNumber) {
                    Console.WriteLine($"Sorry {name}, that number is too low. Attempts: {i + 1}. Guess again:");
                    } 
                    
                }
                }
            }
            else {
                Console.WriteLine("You did not pick a real difficulty level");
            }
        }
       
    }
}

