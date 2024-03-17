using Projekt_3.Interfaces;
using Projekt_3.Exceptions;
namespace Projekt_3;

public class GasContainer : Container,IHazardNotifier
{
    public double AirPressure { get; set; }
    
    static GasContainer() { Type = "G"; }
    public GasContainer(double cargoWeight,double cargoMaxWeight,double airPressure) : base(cargoWeight,cargoMaxWeight)
    {
       AirPressure=airPressure;
    }
    public override void UnLoad()
    {
        CargoWeight=CargoWeight*0.05;
    }

    public override void Load(double cargoWeight)
    {
        if(cargoWeight > CargoMaxWeight)
        {
            SendNotification();
            throw new OverfillException();
        }
      CargoWeight = cargoWeight;
    }
    public void SendNotification()
    {
        Console.WriteLine("Kontener " +SeriesNumber +" w niebezpiecznym stanie - przekroczona dopuszczalna ilość gazu ");    
    }
}