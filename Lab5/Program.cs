using System.Collections.Generic;
using System.Net.Http.Headers;

Queue<string> playList = new Queue<string>();
int currentIndex = -1;
while (true)
{
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind");
    Console.WriteLine("5. Exit");
    int chosed=int.Parse(Console.ReadLine());

    if (chosed == 1)
    {
        string song = Console.ReadLine();
        playList.Enqueue(song);
        Console.WriteLine($"{song} added to your playlist");
    }
    if (chosed == 2)
    {
       
       List<string> lst= playList.ToList();
        if ((currentIndex+1) < lst.Count)
        {
            currentIndex++;
            Console.WriteLine($"Now playing \"{lst[currentIndex]}\"");
            if ((currentIndex + 1) < lst.Count)
            {
                Console.WriteLine($"Next song is \"{lst[currentIndex+1]}\"");
            }
            else
            {
                Console.WriteLine($"Next song is \"{"empty"}\"");
            }
        }
       
    }
    if (chosed == 3)
    {
        List<string> lst = playList.ToList();
        if ((currentIndex + 2) < lst.Count)
        {
            currentIndex = currentIndex + 2;
            Console.WriteLine($"Playing song is \"{lst[currentIndex]}\"");
        }
        else
        {
            Console.WriteLine($"Next song is \"{"empty"}\"");
        }
    }
    if (chosed == 4)
    {
        List<string> lst = playList.ToList();
        if ((currentIndex - 1) >=0)
        {
            currentIndex--;
            Console.WriteLine($"Playing song is \"{lst[currentIndex]}\"");
        }
        else
        {
            Console.WriteLine($"Next song is \"{"empty"}\"");
        }
    }

    if (chosed==5)
    {
        Console.WriteLine("Exit game!");
        break;
    }
    
}

