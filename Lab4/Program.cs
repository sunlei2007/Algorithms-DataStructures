// Program 1
using System;

List<int>  MaxNumbersInLists(List<List<int>> lst)
{
    List<int> lstResult=new List<int>();
    foreach(var item in lst)
    {
        lstResult.Add(item.Max());
    }
    return lstResult;
}
List<List<int>> lstMain = new List<List<int>>();
List<int> lstChild = new List<int>();
lstChild.AddRange(new int[] { 1, 2, 3, 4, 5 });
lstMain.Add(lstChild);

List<int> lstChild1 = new List<int>();
lstChild1.AddRange(new int[] { 1, 2, 3, 4, 6 });
lstMain.Add(lstChild1);

List<int> lstChild2 = new List<int>();
lstChild2.AddRange(new int[] { 1, 2, 3, 4, 7 });
lstMain.Add(lstChild2);

List<int> lstNew = MaxNumbersInLists(lstMain);

Console.WriteLine($"List 1 has a maximum of {lstNew[0]}, List 2 has a maximum of {lstNew[1]}, List 3 has a maximum of {lstNew[2]}");

// Program 2
string HighestGrade(List<List<int>> lst)
{
    List<int> lstResult = new List<int>();
    foreach (var item in lst)
    {
        lstResult.Add(item.Max());
    }

    int maxValue=lstResult.Max();
    int indexOfValue = lstResult.IndexOf(maxValue);

    return $"The highest grade is {maxValue}. This grade was found in class(es) {indexOfValue+1}";
}

List<List<int>> lstMain1 = new List<List<int>>();
List<int> lstChild11 = new List<int>();
lstChild11.AddRange(new int[] { 85, 86, 87, 84, 89 });
lstMain1.Add(lstChild11);

List<int> lstChild12 = new List<int>();
lstChild12.AddRange(new int[] { 81, 82, 83, 84, 86 });
lstMain1.Add(lstChild12);

List<int> lstChild13 = new List<int>();
lstChild13.AddRange(new int[] { 81, 82, 83, 84, 87 });
lstMain1.Add(lstChild13);

string str= HighestGrade(lstMain1);

Console.WriteLine(str);

// Program 3
List<int> OrderByLooping(List<int> lst)
{
    int temp = 0;
    for (int i = 0; i < lst.Count - 1; i++)
    {
        for (int j = i + 1; j < lst.Count; j++)
        {
            if (lst[j] < lst[i])
            {
                temp = lst[i];
                lst[i] = lst[j];
                lst[j] = temp;
            }
        }
    }
    return lst;
}

List<int> lstMain3 = new List<int>();
lstMain3.AddRange(new int[]{ 6, 3, 4, 5 });

List<int>  lstNew3=OrderByLooping(lstMain3);
Console.WriteLine(String.Join(",",lstNew3));