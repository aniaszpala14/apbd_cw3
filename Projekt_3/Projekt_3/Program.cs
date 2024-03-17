// See https://aka.ms/new-console-template for more information

using Projekt_3;


///LISTA PRODUKTOW I TEMPERATUR///
Dictionary<PossibleProducts, double>products=new Dictionary<PossibleProducts, double>();
products.Add(PossibleProducts.Bananas,13.3);
products.Add(PossibleProducts.Chocolate,18.0);
products.Add(PossibleProducts.Fish,2);
products.Add(PossibleProducts.Meat,-15);
products.Add(PossibleProducts.Ice_cream,-18);
products.Add(PossibleProducts.Frozen_pizza,-30);
products.Add(PossibleProducts.Cheese,7.2);
products.Add(PossibleProducts.Sausages,5.0);
products.Add(PossibleProducts.Butter,20.5);
products.Add(PossibleProducts.Eggs,19.0);
///////////////////////////////////

Container con1=new LiquidContainer(120.0,123.5,true);
Console.WriteLine(con1.SeriesNumber);