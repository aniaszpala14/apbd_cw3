using Projekt_3.Interfaces;
using Projekt_3.Exceptions;
namespace Projekt_3;

public class GasContainer : Container,IHazardNotifier
{
    public double AirPressure { get; set; }
    
    public GasContainer(double airPressure) : base(2000,4,4,3000,"G")
    {
       AirPressure=airPressure;
    }
    public override void UnLoad()
    {
        CargoWeight*=0.05;
        AirPressure = 1013;
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        if(cargoWeight > CargoMaxWeight)
        {
            SendNotification();
            throw new OverfillException();
        }
      CargoWeight += cargoWeight;
      AirPressure *= 6;
    }
    public void SendNotification()
    {
        Console.WriteLine("Kontener " +SeriesNumber +" w niebezpiecznym stanie - przekroczona dopuszczalna ilość gazu ");    
    }
}