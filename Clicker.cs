using System.Drawing;

namespace Clicker;

public class Clicker : IClicker
{
    public static int clickDamage { get; set; }
    public int clicks { get; set; }
    
    private List<string> people = new List<string>();
    public void Click()
    {
        Console.Clear();
        Console.WriteLine("Click Me!");
        while (true)
        {
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
                    if (!people[0].Contains("both"))
                    {
                        clicks -= 100;
                        Console.WriteLine($"\nPaid: {people[0]}");
                        people[0] += " both";
                        clickDamage += 2;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\nВы уже покупали данный предмет");
                        Thread.Sleep(2000);
                    }
                    Click();
                }
                else Console.WriteLine("Недостаточно средств");
                break;
            case ConsoleKey.D1:
                if (clicks >= 100)
                {
                    if (!people[1].Contains("both"))
                    {
                        clicks -= 100;
                        Console.WriteLine($"\nPaid: {people[1]}");
                        people[1] += " both";
                        clickDamage += 2;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\nВы уже покупали данный предмет");
                        Thread.Sleep(2000);
                    }
                    Click();
                }
                else Console.WriteLine("Недостаточно средств");
                break;
            case ConsoleKey.D2:
                if (clicks >= 100)
                {
                    if (!people[2].Contains("both"))
                    {
                        clicks -= 100;
                        Console.WriteLine($"\nPaid: {people[2]}");
                        people[2] += " both";
                        clickDamage += 2;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\nВы уже покупали данный предмет");
                        Thread.Sleep(2000);
                    }
                    Click();
                }
                else Console.WriteLine("Недостаточно средств");
                break;
            case ConsoleKey.D3:
                if (clicks >= 100)
                {
                    if (!people[3].Contains("both"))
                    {
                        clicks -= 100;
                        Console.WriteLine($"\nPaid: {people[3]}");
                        people[3] += " both";
                        clickDamage += 2;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\nВы уже покупали данный предмет");
                        Thread.Sleep(2000);
                    }
                    Click();
                }
                else Console.WriteLine("Недостаточно средств");
                break;
        }
    }

    public void initItems()
    {
        people.Add("+2 click (100 coins)");
        people.Add("+4 click (600 coins)");
        people.Add("+6 click (1200 coins)");
        people.Add("+8 click (5000 coins)");
    }
}