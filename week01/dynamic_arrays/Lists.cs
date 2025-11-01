using System;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// This class contains methods for working with lists.
/// </summary>
public static class Lists
{
    /// <summary>
    /// Rotates a list to the right by the specified amount.
    /// </summary>
    /// <param name="data">The list to rotate</param>
    /// <param name="amount">The number of positions to rotate right (1 to data.Count)</param>
    /// <typeparam name="T">The type of elements in the list</typeparam>
    public static void RotateListRight<T>(List<T> data, int amount)
    {
        /*
        PLAN FOR ROTATELISTRIGHT FUNCTION:
        
        Step 1: Validate that the amount is within the valid range (1 to data.Count)
        Step 2: Calculate the split point - this is where the list will be divided
                The split point is at data.Count - amount, because we're rotating right
        Step 3: Get the right portion of the list (the last 'amount' elements)
        Step 4: Get the left portion of the list (the first 'data.Count - amount' elements)
        Step 5: Clear the original list
        Step 6: Add the right portion first (this becomes the new beginning)
        Step 7: Add the left portion after the right portion
        
        Example: data = [1,2,3,4,5,6,7,8,9], amount = 3
        - Split point = 9 - 3 = 6
        - Right portion = elements from index 6 to end: [7,8,9]
        - Left portion = elements from index 0 to 5: [1,2,3,4,5,6]
        - Result = right portion + left portion = [7,8,9,1,2,3,4,5,6]
        
        Alternative approach using list methods:
        */
        
        // Step 1: Validate input
        if (data == null)
            throw new ArgumentNullException(nameof(data));
            
        if (amount < 1 || amount > data.Count)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be between 1 and the list count inclusive");
        
        // If amount equals the list count, rotation results in the same list
        if (amount == data.Count)
            return;
        
        Debug.WriteLine($"Rotating list right by {amount} positions");
        Debug.WriteLine($"Original list: [{string.Join(", ", data)}]");
        
        // Step 2: Calculate the split point
        int splitIndex = data.Count - amount;
        
        // Step 3: Get the right portion (last 'amount' elements)
        List<T> rightPortion = data.GetRange(splitIndex, amount);
        
        // Step 4: Get the left portion (first 'splitIndex' elements)
        List<T> leftPortion = data.GetRange(0, splitIndex);
        
        Debug.WriteLine($"Left portion: [{string.Join(", ", leftPortion)}]");
        Debug.WriteLine($"Right portion: [{string.Join(", ", rightPortion)}]");
        
        // Step 5: Clear the original list
        data.Clear();
        
        // Step 6: Add the right portion first
        data.AddRange(rightPortion);
        
        // Step 7: Add the left portion after
        data.AddRange(leftPortion);
        
        Debug.WriteLine($"Rotated list: [{string.Join(", ", data)}]");
    }
}