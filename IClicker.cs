using System.Drawing;

namespace Clicker;

public interface IClicker
{
    public void Click();
    public void Upgrade();
    public void Shop();
    
    public void initItems();
    
    public int clickDamage { get; set; }
    
    public int upgrades { get; set; }
    
    public int clicks { get; set; }
}