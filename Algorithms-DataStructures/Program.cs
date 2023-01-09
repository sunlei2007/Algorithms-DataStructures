Console.WriteLine("Please enter a number:");
int arrLength = Int32.Parse(Console.ReadLine());
string[] arr = new string[arrLength];

Console.WriteLine("Please enter 3 words:");
for (int i = 0; i<arr.Length ;i++)
{
    string inputWord = Console.ReadLine();
    if (inputWord.Contains(" "))
    {
        break;
    }
    arr[i] = inputWord;
}


Console.WriteLine("Please enter a character:");
char searchChar;
enterSearchChar();

Console.WriteLine();
char[] newStr = string.Join("", arr).ToCharArray();
int count = 0;
for(int i=0;i<newStr.Length;i++)
{
    if (newStr[i]==searchChar)
    {
        count++;
    }
}
 
double ratio = Math.Round((double)count/(double)newStr.Length, 2) * 100;

Console.WriteLine($"The letter ‘{searchChar}’ appears {count} times in the array. This letter makes up more than {ratio}% of the total number of characters.");

 void enterSearchChar()
{
    
    char newSearchChar= Console.ReadKey().KeyChar;
    if (!char.IsLetter(newSearchChar))
    {
        Console.WriteLine();
        Console.WriteLine("Cannot enter number or symbol , Please enter again:");
        enterSearchChar();
    }
    else
    {
        searchChar = newSearchChar;
    }
   
}