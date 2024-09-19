


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
    Console.WriteLine("4. Slots");
    Console.WriteLine("8. Tamagotchi List");
    Console.WriteLine("9. New Tamagotchi");
    Console.WriteLine("0. Kill Tamagotchi");
    friend.Hi();
    string action = Console.ReadLine();

    if (action == "1") {friend.Teach();}
    if (action == "2") {friend.Feed();}
    if (action == "3") {friend.Hi();}
    if (action == "4") {friend.slots();}
    // if (action == "8") {friend.List()}
    if (action == "9") 
    {

    }
    if (action == "0") {friend.death();}

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


 
 