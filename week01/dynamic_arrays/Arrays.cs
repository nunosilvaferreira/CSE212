using System;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// This class contains methods for working with arrays.
/// </summary>
public static class Arrays
{
    /// <summary>
    /// Creates and returns an array of multiples of a given number.
    /// </summary>
    /// <param name="number">The starting number to find multiples of</param>
    /// <param name="count">The number of multiples to generate</param>
    /// <returns>An array containing the multiples</returns>
    public static double[] MultiplesOf(double number, int count)
    {
        /*
        PLAN FOR MULTIPLESOF FUNCTION:
        
        Step 1: Create a new array of doubles with the specified count
        Step 2: Use a loop to iterate from 1 to count (inclusive)
        Step 3: For each iteration, calculate the multiple by multiplying the number by the current iteration index
        Step 4: Store each calculated multiple in the corresponding position in the array
        Step 5: Return the completed array containing all multiples
    
        */
        
        // Step 1: Create a new array with the specified length
        double[] multiples = new double[count];
        
        // Step 2 & 3: Loop through and calculate each multiple
        for (int i = 0; i < count; i++)
        {
            // Calculate the multiple: number multiplied by (i + 1)
            multiples[i] = number * (i + 1);
            
            // Debug output to verify calculations
            Debug.WriteLine($"Multiple {i + 1}: {number} × {i + 1} = {multiples[i]}");
        }
        
        // Step 5: Return the completed array
        return multiples;
    }
}