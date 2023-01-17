Console.WriteLine("Please enter a number:");
int arrLength = Int32.Parse(Console.ReadLine());

while (arrLength <= 0)
{
    Console.WriteLine("Sorry,please enter a positive value.");
    arrLength = Int32.Parse(Console.ReadLine());
}
string[] arr = new string[arrLength];

for (int i = 0; i < arr.Length; i++)
{
    string inputWord = "";
    while (inputWord.Length < 1)
    {
        Console.WriteLine($"Please enter word {i + 1}");
        inputWord = Console.ReadLine();

    }
    while (inputWord.Contains(" "))
    {
        Console.WriteLine($"The word cannot contain whitespace!");
        inputWord = Console.ReadLine();
    }
    arr[i] = inputWord;
}

//
Console.WriteLine("Please enter a character:");
char searchChar = Console.ReadKey().KeyChar;
while (!char.IsLetter(searchChar))
{
    Console.WriteLine();
    Console.WriteLine("Cannot enter number or symbol , please enter again:");
    searchChar = Console.ReadKey().KeyChar;
}

Console.WriteLine();
char[] newStr = string.Join("", arr).ToCharArray();
int count = 0;
for (int i = 0; i < newStr.Length; i++)
{
    if (char.ToLower(newStr[i]) == char.ToLower(searchChar))
    {
        count++;
    }
}
///
Console.WriteLine($"The letter ‘{searchChar}’ appears {count} times in the array.");

double ratio = Math.Round((double)count / (double)newStr.Length, 2) * 100;
if (ratio > 25)
{
    Console.WriteLine($"This letter makes up more than 25% of the total number of characters.");

}