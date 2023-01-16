
using System.Collections;

int[] intArr = new int[] { 1, 2, 3, 4, 2, 4 };
ArrayList arrResult = new ArrayList();

foreach (var item in intArr)
{
    List<int> tempArr = intArr.ToList<int>();
    tempArr.Remove(item);

    foreach (var itemNew in tempArr)
    {
        if (itemNew == item&&!arrResult.Contains(item))
        {
            arrResult.Add(item);
        }
    }
}
Console.WriteLine("1.We have a list of integers where elements appear either once or twice:");
foreach(var item in arrResult)
{
    Console.Write(item+ "，");
}

Console.WriteLine();

int[,] intArr2 = new int[,] 
{ {1,2,3,4,2,4 },
  {5,7,7,8,7,6 }
};

int[] intArrNew = new int[intArr2.GetLength(1) * 2];
int temp1 = 0;
foreach(var item in intArr2)
{
    intArrNew[temp1] = item;
    temp1++;
}

int temp = 0;
for (int i = 0; i < intArrNew.Length - 1; i++)   
{
    for (int j = i + 1; j < intArrNew.Length; j++)     
    {
        if (intArrNew[j] < intArrNew[i])
        {
            temp = intArrNew[i];
            intArrNew[i] = intArrNew[j];
            intArrNew[j] = temp;
        }
    }
}
Console.WriteLine("2.We have two sorted int arrays which could be with different sizes. We need to merge them in a third array while keeping this result array sorted. ");

foreach (var item in intArrNew)
{
    Console.Write(item + "，");
}
Console.WriteLine();


int[] intArr3 = new int[] { 3,4,1,5 };
int[] intResult3 = new int[intArr3.Length];
int temp3 = 0;
for(int i=intArr3.Length-1;i>=0;i--)
{
    intResult3[temp3] = intArr3[i];
    temp3++;
}
Console.WriteLine("3.Given an integer, reverse the digits of that integer. ");

foreach (var item in intResult3)
{
    Console.Write(item + "，");
}