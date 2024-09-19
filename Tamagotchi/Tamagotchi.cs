
public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private int slotsCount = 0;
    private float scratches = 0;
    private float currency = 1000;
    private float bet = 0;
    private List<string> words = new List<string>() {"LIMBUS COMPANY!!"};
    private bool isAlive = true;
    public String name;
    public string toTeach;
    public bool hyper = false;
    public bool gamblePity = false;
    public bool kibble = false;
    public Tamagotchi()
    {
        isAlive = true;
    }

    public void Teach()
    {
        Console.WriteLine($"What do you want to teach {name}?");
        toTeach = Console.ReadLine();
        Console.WriteLine($"{name} learns {toTeach} at a private school costing 30 bucks");
        words.Add(toTeach);
        boredomReduce();
        Console.WriteLine($"{name} says: {toTeach} {toTeach}!");
    }

    public void Feed()
    {
        if (kibble == true)
        {hunger -= Random.Shared.Next(2,3);}
        else{hunger -= Random.Shared.Next(2,5);}
        if (hunger <= 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        int wordnum = Random.Shared.Next(words.Count);
        Console.WriteLine($"{name} says: {words[wordnum]}");
        boredomReduce();
    }

    public void slots()
    {
        Console.WriteLine($"You have {currency} bucks. How much do you put in?");
        bet = Convert.ToInt32 (Console.ReadLine());
        if (bet > currency)
        {
            bet = 0;
            Console.WriteLine ($"{name} doesnt have that much to bet");
            Console.WriteLine ($"You get kicked out.");
        }
        else if (bet <= currency)
        {
        currency = currency - bet;
        Console.WriteLine($"SCRATCH THAT SH*T JOHNY!!");
        Console.WriteLine("Quickly spam ANYTHING!!!!");
        while (slotsCount < 20)
        {
            Console.ReadKey();
            scratches ++;
            slotsCount += Random.Shared.Next(1,4);
        }
        Console.WriteLine($"{name} scratched {scratches} times");
        slotsCount = 0;
        if (gamblePity == false)
        {
            if (scratches >= 10)
            {
                bet = bet * ((scratches/10) + 0.4f);
                currency = currency + bet;
                Console.WriteLine ($"{name} won {bet} bucks!");
                Console.WriteLine($"{name} now has {currency}");
                scratches = 0;
            }
        }
        else if  (gamblePity == true)
        {
            Console.WriteLine ("Coward");
            if (scratches >= 1)
            {
                bet = bet * ((scratches/10) + 123f);
                currency = currency + bet;
                Console.WriteLine ($"OMGGGG {name} WON A TAMAGAJILLION BUCKSSS!!!");
                Console.WriteLine($"{name} now has {currency}");
                scratches = 0;
            }   
        }

        else if (scratches < 10)
        {
            Console.WriteLine ($"{name} has lost!");
            scratches = 0;
        }
        }
    }

    public void store()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the store!!\n=========================");
        Console.WriteLine("1.[I suck at gamlbing] - 1 buck");
        Console.WriteLine("2.[High quality Kibble] - 200 bucks");
        Console.WriteLine("3.[Drugs] - 300");
        string toBuy = Console.ReadLine();
        if (toBuy == "1" && currency >= 1) 
        {gamblePity = true;
        currency -= 1;}
        if (toBuy == "2" && currency >= 300) 
        {kibble = true;
        currency -= 300;}
        if (toBuy == "3" && currency >= 300) 
        {hyper = true;
        currency -= 300;}
        Console.WriteLine("Thank you for your patronage!");
    }
    public void death()
    {
        isAlive = false;
    }
    // public void slotSound()
    // {
    //     System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
    //     player.Play();
    // }




    public bool getAlive()
    {
        return isAlive;
    }

    public void tick()
    {
        hunger += 2;
        boredom += 2;
        if (boredom > 90 || hunger > 90)
        {
            isAlive = false;
        }
    }

    public void printStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Words Learned: {words.Count} || Currency: {currency}");
    }








    private void boredomReduce()
    {
        if (hyper == true)
        {boredom -= Random.Shared.Next(5,10);}
        else{boredom -= Random.Shared.Next(3,5);}
        if (boredom <= 0)
        {
            boredom = 0;
        } 
    }

}
