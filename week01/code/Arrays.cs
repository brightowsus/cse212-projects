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
    // Step 1: Create an array of doubles with size 'length'
    double[] multiples = new double[length];

    // Step 2: Loop from 0 to length-1
    for (int i = 0; i < length; i++)
    {
        // Step 3: Each element is number multiplied by (i + 1)
        multiples[i] = number * (i + 1);
    }

    // Step 4: Return the resulting array
    return multiples;
}


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
public static void RotateListRight(List<int> data, int amount)
{
    // Step 1: Get the last 'amount' elements using GetRange
    List<int> lastElements = data.GetRange(data.Count - amount, amount);

    // Step 2: Remove the last 'amount' elements
    data.RemoveRange(data.Count - amount, amount);

    // Step 3: Insert the removed elements at the beginning of the list
    data.InsertRange(0, lastElements);
}
}
