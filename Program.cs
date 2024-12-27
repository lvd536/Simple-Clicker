namespace Clicker;

class Program
{
    public static void Main(string[] args)
    {
        string welcomeMessage = "Welcome to Clicker!\n";
        for (int i = 0; i < welcomeMessage.Length; i++)
        {
            Console.Write(welcomeMessage[i]);
            Thread.Sleep(100);
        }
        Clicker _clicker = new Clicker();
        _clicker.initItems();
        Thread.Sleep(200);
        _clicker.Click();
    }
}