public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

private static int[] ListSelector(int[] list1, int[] list2, int[] select)
{
    int[] result = new int[select.Length];
    int i = 0, j = 0;

    for (int k = 0; k < select.Length; k++)
    {
        if (select[k] == 1)
        {
            result[k] = list1[i++];
        }
        else if (select[k] == 2)
        {
            result[k] = list2[j++];
        }
        else
        {
            throw new ArgumentException("Selector array must only contain 1s and 2s.");
        }
    }

    return result;
}

}