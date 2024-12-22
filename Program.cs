namespace Clicker;

class Program
{
    public static void Main(string[] args)
    {
        Clicker _clicker = new Clicker();
        Console.WriteLine("Welcome to Clicker!");
        _clicker.initItems();
        _clicker.Click();
    }
}