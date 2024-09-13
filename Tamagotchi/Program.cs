

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Its time for you to get a freind!");

Tamagotchi friend = new Tamagotchi();

Console.WriteLine("What do you want to name your friend?");
friend.name = Console.ReadLine();
Console.WriteLine($"Okay your friend is called {friend.name}");

while (friend.getAlive() == true)
{

    Console.Clear();
    friend.printStats();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1. Teach words");
    Console.WriteLine("2. Feed");
    Console.WriteLine("3. Talk");
    Console.WriteLine("4 Slots");
    friend.Hi();
    string action = Console.ReadLine();

    if (action == "1")
    {
        Console.WriteLine($"What do you want to teach {friend.name}?");
        string toTeach = Console.ReadLine();
        friend.Teach(toTeach); 
    }
    if (action == "2") {friend.Feed();}
    if (action == "3") {friend.Hi();}
    if (action == "4") {friend.slotSound(); friend.slots();}
    else
    {
        Console.WriteLine("...");
    }
    friend.tick();
    Console.WriteLine("...[Enter]");
    Console.ReadLine();


}

Console.WriteLine($"you killed {friend.name}! You bastard!");
Console.ReadLine();
 