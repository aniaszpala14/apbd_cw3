using Projekt_3.Interfaces;

namespace Projekt_3;

public class LiquidContainer : Container,IHazardNotifier
{
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
        
    }

    public override void UnLoad()
    {
        
    }
    public override void Load(double cargoWeight)
    {
        
    }

    public void SendNotification()
    {
    }
}