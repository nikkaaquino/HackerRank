using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int secondInt;
        double secondDouble = 0.0;
        string secondString;
              
        // Read and save an integer, double, and String to your variables.
        secondInt = int.Parse(Console.ReadLine());
        secondDouble = double.Parse(Console.ReadLine());
        secondString = Console.ReadLine();       
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + secondInt);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine($"{d + secondDouble:0.0}");
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + secondString);

    }
}
