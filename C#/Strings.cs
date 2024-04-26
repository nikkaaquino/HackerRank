using System;

class Solution {
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int loop = 0; loop < n; loop++){
        string inputString = Console.ReadLine();
        PrintEvenOddCharacters(inputString);
        
        }
    }

    static void PrintEvenOddCharacters(string input) {
        char[] charArray = input.ToCharArray();
        for (int a = 0; a < input.Length; a++) {
            if (a % 2 == 0) {
                Console.Write(charArray[a]);
            }
        }
        Console.Write(" ");
        for (int a = 0; a < input.Length; a++) {
            if (a % 2 == 1) {
                Console.Write(charArray[a]);
            }
        }
        Console.WriteLine();
    }
}
