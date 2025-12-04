public static class Trees
{
    /// <summary>
    /// Given a sorted list (sorted_list), create a balanced BST.
    /// </summary>
    public static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers)
    {
        var bst = new BinarySearchTree();
        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);
        return bst;
    }

    /// <summary>
    /// Recursively insert the middle element of the subarray to create a balanced BST
    /// </summary>
    private static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst)
    {
        // Problem 5: Create Tree from Sorted List
        if (first > last)
            return;

        int middle = first + (last - first) / 2;
        bst.Insert(sortedNumbers[middle]);

        // Recursively insert left and right halves
        InsertMiddle(sortedNumbers, first, middle - 1, bst);
        InsertMiddle(sortedNumbers, middle + 1, last, bst);
    }
}