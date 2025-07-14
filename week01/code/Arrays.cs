public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To solve the problem, we will:
        // 1. Create an array of doubles with the specified length. 
        // 2. Use a loop to fill the array with multiples of the given number.
        // 3. Each element in the array will be the product of the number and its   
        //    index (starting from 1 to length).
        // 4. Return the filled array.
        // The comments will be included with the code to explain each step.

        // Create an array of doubles with the specified length
        double[] multiples = new double[length];

        // Fill the array with multiples of the given number
        for (int i = 0; i < length; i++)
        {
            // Each element is the product of the number and (i + 1) to get multiples starting from 1
            multiples[i] = number * (i + 1);
        }
        // Return the filled array
        // This will give us an array where the first element is 'number', the second is 'number * 2', and so on.
        return multiples;
    }
}

public static void Main()
{
    // Example usage of MultiplesOf
    double[] result = Arrays.MultiplesOf(7, 5);
    Console.WriteLine("Multiples of 7: " + string.Join(", ", result));
}






///    <summary> 
/// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
/// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
/// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
///
/// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
/// </summary>
// Example usage of RotateListRight
// List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Rotate right by 3 positions
// RotateListRight(data, 3);

// Display the rotated list
// Console.WriteLine("Rotated List: " + string.Join(", ", data));

/// <summary>
/// Rotates the given list to the right by the specified amount.
/// Modifies the list in place
/// </summary>
/// <param name="data">The list to rotate</param>
/// <param name="amount">The number of positions to rotate</param>

public static void RotateListRight(List<int> data, int amount)
{
    // Step 1: Validate the input 'amount'
    if (data == null || data.Count == 0)
    {
        Console.WriteLine("The list is empty or null. No rotation performed.");
        return;
    }

    // Step 2: Normalize the amount
    amount = amount % data.Count;
    if (amount == 0)
        return;

    // Step 3: Rearrange the elements using GetRange and AddRange
    // Split the list into two parts: last 'amount' elements, and the rest
    List<int> rotated = data.GetRange(data.Count - amount, amount); // tail
    rotated.AddRange(data.GetRange(0, data.Count - amount));

    // Step 4:  Modify the original list in place
    data.Clear();
    data.AddRange(rotated);
}

