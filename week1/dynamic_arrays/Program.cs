using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Test MultiplesOf function
        Console.WriteLine("Testing MultiplesOf function:");
        double[] multiples = Arrays.MultiplesOf(3, 5);
        Console.WriteLine($"MultiplesOf(3, 5): [{string.Join(", ", multiples)}]");
        
        // Test RotateListRight function
        Console.WriteLine("\nTesting RotateListRight function:");
        List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        Console.WriteLine($"Original: [{string.Join(", ", numbers)}]");
        
        Lists.RotateListRight(numbers, 3);
        Console.WriteLine($"After rotating right by 3: [{string.Join(", ", numbers)}]");
    }
}