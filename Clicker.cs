using System.Drawing;

namespace Clicker;

public class Clicker : IClicker
{
    public int clickDamage { get; set; }
    public int clicks { get; set; }
    
    public int upgrades { get; set; }
    
    private List<string> people = new List<string>();
    public void Click()
    {
        clickDamage = 1;
        Console.Clear();
        Console.WriteLine("Click Me!");
        while (true)
        {
            if (people[0].Contains("both") && !people[0].Contains("applyed"))
            {
                Console.WriteLine("\nBuyed clicker +2");
                clickDamage += 2;
                //people.Insert(0, people[0]+ " applyed");
                people[0] += " applyed";
            }
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.W:
                    clicks += clickDamage;
                    Console.Clear();
                    Console.WriteLine($"------------------------------------------------");
                    Console.WriteLine($"Total money: {clicks} | Current: Clicker | Leave - END");
                    Console.WriteLine($"------------------------------------------------");
                    break;
                
                case ConsoleKey.End:
                    Console.Clear();
                    Console.WriteLine($"--------------------------------");
                    Console.WriteLine($"Total money: {clicks} | Current: Leaved");
                    Console.WriteLine($"--------------------------------");
                    break;
                
                case ConsoleKey.S:
                    Shop();
                    break;
                
                default:
                    
                    break;
            }
        }
    }

    public void Upgrade()
    {
        Upgrade();
    }

    public void Shop()
    {
        Console.Clear();
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Total money: {clicks} | Current: Shop");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Choise item for buy:");
        
        for (int i = 0; i < people.Count; i++)
        {
            if (!people[i].Contains("both"))
            {
                Console.WriteLine($"{i}. {people[i]}");
            }
        }
        ConsoleKeyInfo input = Console.ReadKey();
        switch (input.Key)
        {
            case ConsoleKey.D0:
                if (clicks >= 100)
                {
                    clicks -= 100;
                    //people.Insert(0, people[0] + " both");
                    people[0] += " both";
                    Click();
                }
                else Console.WriteLine("Недостаточно средств");
                break;
        }
    }

    public void initItems()
    {
        people.Add("+2 click (100 coins)");
    }
}