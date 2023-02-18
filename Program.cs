// Testing
// Kata.MoveZeroesToRight(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });


public class Kata
{
    public static int[] MoveZeroesToRight(int[] array)
    {
        // 1.-Convert the arr into a List (because i want to use List methods)
        List<int> list = array.ToList();
        // 2.-Get rid of the zeros in the original list and create a new list without them
        var listWithoutZeros = list.FindAll(s => s > 0);
        // 3.-Get all the zeros in the original list and create a new list with them
        var listOfZeros = list.FindAll(s => s < 1);
        // 4.-Combine this 2 Lists and save the result List into a new List
        List<int> solutionList = new List<int>(listWithoutZeros);
        solutionList.AddRange(listOfZeros);
        // 5.-Convert the List back to an array (step1)
        int[] solutionArray = solutionList.ToArray();
        // 6.-Return an array with all the zeros moved to the right
        return solutionArray;
    }
}
//TODO LOOK AT THE METHOD ".WHERE()", COULD BE BETTER THAN ".FINDALL()"