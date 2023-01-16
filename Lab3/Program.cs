
using System.Collections;

int[] intArr = new int[] { 1, 2, 3, 4, 2, 4 };
ArrayList arrResult = new ArrayList();
foreach (var item in intArr)
{
    List<int> tempArr = intArr.ToList<int>();
    tempArr.Remove(item);

    foreach (var itemNew in tempArr)
    {
        if (itemNew == item)
        {
            arrResult.Add(item);
        }
    }
}
Console.WriteLine(arrResult);