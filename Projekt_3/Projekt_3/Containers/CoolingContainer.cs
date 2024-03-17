namespace Projekt_3;

public class CoolingContainer : Container
{
    public string Product;
    public double Temperature;
    Dictionary<string,int> dict = new Dictionary<string,int>();
    Dictionary<PossibleProducts, double>products;
    
    static CoolingContainer() { Type = "C"; }
    public CoolingContainer(double cargoWeight,double cargoMaxWeight,string product,double temperature) : base(cargoWeight,cargoMaxWeight)
    {
        Product = product;
        Temperature = temperature;
    }
    
    
}