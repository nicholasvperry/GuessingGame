using System;

namespace Intro
{
    public class Program
    {
         
        public static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            Console.Write("What is your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! I'm glad to meet you.");
            Console.Write("How difficult do you want this to be? easy, medieum, hard, or cheater?");
            string? difficulty = Console.ReadLine().ToLower();
            
            if (difficulty == "easy"){
                Console.Write("You have 8 guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i < 8; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.Write($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (number > secretNumber) {
                    Console.Write($"Sorry {name}, that number is too high. Attempts left: {7 - i}:");
                    }
                    if (number < secretNumber) {
                    Console.Write($"Sorry {name}, that number is too low. Attempts left: {7 - i}:");
                    }
                    
                }
                }
            }
            else if (difficulty == "medium"){
                Console.Write("You have 6 guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i < 6; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.Write($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (number > secretNumber) {
                    Console.Write($"Sorry {name}, that number is too high. Attempts left: {5 - i}:");
                    }
                    if (number < secretNumber) {
                    Console.Write($"Sorry {name}, that number is too low. Attempts left: {5 - i}:");
                    }
                    
                }
                }
            }
            else if (difficulty == "hard"){
                Console.Write("You have 4 guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i < 4; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.Write($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (number > secretNumber) {
                    Console.Write($"Sorry {name}, that number is too high. Attempts left: {3 - i}:");
                    }
                    if (number < secretNumber) {
                    Console.Write($"Sorry {name}, that number is too low. Attempts left: {3 - i}:");
                    }
                    
                }
                }
            }
            else if (difficulty == "cheater") {
                Console.Write("You have unlimited guesses to figure out what your luck number is! What is your first guess?");

                for (int i = 0; i == i; i++) {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secretNumber){
                    Console.Write($"Great job {name}, you guessed it!");
                    break;

                } else {
                    if (number > secretNumber) {
                    Console.Write($"Sorry {name}, that number is too high. Attempts {i + 1}. Guess again:");
                    }
                    if (number < secretNumber) {
                    Console.Write($"Sorry {name}, that number is too low. Attempts: {i + 1}. Guess again:");
                    }
                    
                }
                }
            }
            
        }
       
    }
}

