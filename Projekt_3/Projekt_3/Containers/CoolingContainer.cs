using Projekt_3.Exceptions;

namespace Projekt_3;

public class CoolingContainer : Container
{
    public PossibleProducts Product;
    public double Temperature;
    public static Dictionary<PossibleProducts, double>Products;
  
 
    public CoolingContainer(PossibleProducts product,double temperature) : base(5000,4,4,4000,"C")
    {
        Product = product;
        Temperature = temperature;
        if (temperature < Products[product])
        {
            Console.WriteLine("Produkt wymaga wyższej temperatury niz ta ktora ma kontener");
            throw new TooLowTemperatureException();
        }
    }

    public static void LoadList(Dictionary<PossibleProducts, double> products)
    {
        Products = products;
    }
    
    
    
}