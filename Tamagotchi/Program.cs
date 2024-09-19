
List<Tamagotchi> tamagotchis = new();




Console.WriteLine("Its time for you to get a freind!");
Tamagotchi friend = new Tamagotchi();   
tamagotchis.Add(friend);     
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
    Console.WriteLine("5. Store");    
    Console.WriteLine("8. Tamagotchi List");
    Console.WriteLine("9. New Tamagotchi");
    Console.WriteLine("0. Kill Tamagotchi");
    string action = Console.ReadLine();

    if (action == "1") {friend.Teach();}
    if (action == "2") {friend.Feed();}
    if (action == "3") {friend.Hi();}
    if (action == "4") {friend.slots();}
    if (action == "5") {friend.store();}
    if (action == "8") 
    {
        // tamagotchis.ForEach(Console.WriteLine(friend.name));
    }
    if (action == "9") 
    {
        // Console.WriteLine("Its time for you to get a new freind!");
        // Tamagotchi friend = new Tamagotchi();  
        // tamagotchis.Add(friend);      
        // Console.WriteLine("What do you want to name your new friend?");
        // friend.name = Console.ReadLine();
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


 
 