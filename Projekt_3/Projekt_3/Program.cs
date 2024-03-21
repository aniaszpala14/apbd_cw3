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
CoolingContainer.LoadList(products);
///////////////////////////////////

Container con1=new LiquidContainer(true);
Container con2=new LiquidContainer(false);
Container con3 = new GasContainer(120);
Container con4 = new GasContainer(400);
Container con5 = new CoolingContainer(PossibleProducts.Bananas, 13.3);

Console.WriteLine(con1.SeriesNumber);
Console.WriteLine(con2.SeriesNumber);
Console.WriteLine(con3.SeriesNumber);
Console.WriteLine(con4.SeriesNumber);
Console.WriteLine(con5.SeriesNumber);



con1.Load(3000); // --notify ze za duzo plynu
con2.Load(1230);

//con3.Load(2300); //--blad overfill masa gazu > max masa gazu
con4.Load(1000);
con4.UnLoad();
Console.WriteLine(con4.CargoWeight);

//Container con6 = new CoolingContainer(PossibleProducts.Cheese, 1.3); //--rzuca blad za niskiej temperatury
Container con7 = new CoolingContainer( PossibleProducts.Cheese, 19.0);



ContainerShip statek = new ContainerShip(20, 20, 4);

Container cons1=new LiquidContainer(true);
Container cons2=new LiquidContainer(false);
Container cons3 = new GasContainer(1013);
Container cons4= new GasContainer(1013);
Container cons5 = new CoolingContainer(PossibleProducts.Chocolate, 18.0);
cons1.Load(2000);
cons2.Load(3000);
cons3.Load(2000);
cons4.Load(2000);


statek.Load(cons1);
statek.Load(cons2);
statek.Load(cons3); 
statek.Load(cons4); //nie doda sie bo waga za duza
//statek.Load(cons512);

Console.WriteLine(cons3.SeriesNumber);
statek.Remove("KON-G-9");
statek.Replace(cons1.SeriesNumber,cons5);

Console.WriteLine(con5);
Console.WriteLine(statek); // dobrze bo usunieto con3

ContainerShip statek2 = new ContainerShip(15, 50, 9);
//statek2.Load(statek.AllContainers); // dodanie lista - to nie przeniesienie
//Console.WriteLine(statek2);

statek2.Move(statek,cons2);
Console.WriteLine(statek2);


