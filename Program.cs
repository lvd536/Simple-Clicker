namespace Clicker;

class Program
{
    public static void Main(string[] args)
    {
        Clicker _clicker = new Clicker();
        Clicker.clickDamage = 1;
        string welcomeMessage = "Welcome to Clicker!\n";
        for (int i = 0; i < welcomeMessage.Length; i++)
        {
            Console.Write(welcomeMessage[i]);
            Thread.Sleep(100);
        }
        _clicker.initItems();
        Thread.Sleep(200);
        _clicker.Click();
    }
}