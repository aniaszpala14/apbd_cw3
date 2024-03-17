using Projekt_3.Interfaces;
using Projekt_3.Exceptions;
namespace Projekt_3;

public class LiquidContainer : Container,IHazardNotifier
{
    public bool IsSave { get; set; }
    static LiquidContainer() { Type = "L"; }
    public LiquidContainer(double cargoWeight,double cargoMaxWeight,bool isSave) : base(cargoWeight,cargoMaxWeight)
    {
        IsSave = isSave;
    }

    public override void UnLoad()
    {
        base.UnLoad();
    }

    public override void Load(double cargoWeight)
    { 
        if(cargoWeight > CargoMaxWeight){ throw new OverfillException();}
        if (cargoWeight>(CargoMaxWeight*0.9) || (!IsSave &&  cargoWeight>(CargoMaxWeight*0.5))) { SendNotification(); }
        CargoWeight = cargoWeight;
    }

    public void SendNotification()
    {
    Console.WriteLine("Kontener " +SeriesNumber +" w niebezpiecznym stanie - przekroczona dopuszczalna ilość płynu ");    
    }
}