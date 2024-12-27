namespace Clicker;

class Program
{
    public static void Main(string[] args)
    {
        string[] welcomeMessage = new string[17] { "W", "e","l", "c", "o", "m", "e", " t", "o", " C", "l", "i", "c", "k", "e", "r", "!\n"};
        for (int i = 0; i < welcomeMessage.Length; i++)
        {
            Console.Write(welcomeMessage[i]);
            Thread.Sleep(100);
        }
        Clicker _clicker = new Clicker();
        _clicker.initItems();
        _clicker.Click();
    }
}