using System.Drawing;

namespace Clicker;

public interface IClicker
{
    public void Click();
    public void Shop();
    
    public void initItems();
    
    public static int clickDamage { get; set; }
    
    public int clicks { get; set; }
}