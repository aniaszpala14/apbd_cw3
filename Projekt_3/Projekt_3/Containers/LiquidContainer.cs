using Projekt_3.Interfaces;
using Projekt_3.Exceptions;
namespace Projekt_3;

public class LiquidContainer : Container,IHazardNotifier
{
    private bool IsSave { get; set; }
    public LiquidContainer(bool isSave) : base(3000,4,4,3000,"L")
    {
        IsSave = isSave;
    }

    public override void Load(double cargoWeight)
    { 
        base.Load(cargoWeight);
        if(cargoWeight > CargoMaxWeight){ throw new OverfillException();}
        if (cargoWeight>(CargoMaxWeight*0.9) || (!IsSave &&  cargoWeight>(CargoMaxWeight*0.5))) { SendNotification(); }
        CargoWeight += cargoWeight;
    }
    public void SendNotification()
    {
    Console.WriteLine("Kontener " +SeriesNumber +" w niebezpiecznym stanie - przekroczona dopuszczalna ilość płynu ");    
    }
    public override string ToString()
    {
        return base.ToString() + " -> przewozi "+(IsSave?" bezpieczny ładunek":"niebezpieczny ładunek");
    }
}