// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Text;


//A program that produces an array of all of the characters that appear more than once in a string
Console.WriteLine("Please enter words:");
string? str1 = Console.ReadLine();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < str1.Length; i++)
{
    string strRemoved = str1.Remove(str1.IndexOf(str1[i]), 1);
    if (strRemoved.ToLower().Contains(str1[i].ToString().ToLower()))
    {
        sb.Append(str1[i].ToString().ToLower());
        str1 = strRemoved;
    }
}
Console.WriteLine("Result: " + sb.ToString());

//A program returns an array of strings that are unique words found in the argument
Console.WriteLine("Please enter words:");
string? str2 = Console.ReadLine();
string[] strArr = str2.Split(" ");
ArrayList arrList = new ArrayList();
foreach (var item in strArr)
{
    if (!arrList.Contains(item))
        arrList.Add(item);
}
Console.WriteLine("Unique string result: " + string.Join(",", arrList.ToArray()));

//A program that reverses a provided string 
Console.WriteLine("Please enter words:");
string? str3 = Console.ReadLine();
ArrayList arrList3 = new ArrayList();
for (int i = 0; i < str3.Length; i++)
{
    arrList3.Add(str3[i]);
}
Console.WriteLine("Reverse result: " + arrList3.ToArray().Reverse());

//A program that finds the longest unbroken word in a string and prints it
Console.WriteLine("Please enter words:");
string? str4 = Console.ReadLine();
string[]? strArr4 = str4.Split(" ");
string strResult = string.Empty;
for (int i = 0; i < strArr4.Length; i++)
{
    if (strResult.Length < strArr4[i].Length)
        {
            strResult = strArr4[i];
        }
}
Console.WriteLine("Maxlength string is " + strResult);
