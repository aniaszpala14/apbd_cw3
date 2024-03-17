namespace Projekt_3;

public class ContainerShip
{
    public double MaxSpeed { get; set; }
    public List<Container> AllContainers  { get; set; }
    public int MaxAmount { get; set; }
    public double MaxWeight { get; set; }
    public double CurrentWeight;

    public ContainerShip(double maxSpeed, double maxWeight, int maxAmount)
    {
        MaxSpeed = maxSpeed;
        MaxAmount = maxAmount;
        MaxWeight = maxWeight;
    }

    public void Load(Container con)
    {   
        if(MaxAmount<AllContainers.Count+1)
        { 
        Console.WriteLine("Maksymalna ilość kontenerów została przekroczona");
        return;
        }
        else if (MaxWeight*1000 < (con.CargoWeight + con.CargoItsWeight +CurrentWeight))
        {
        Console.WriteLine("Maksymalna waga statku została przekroczona");
        return;
        }
        else
        {
        AllContainers.Add(con);
        CurrentWeight += con.CargoItsWeight + con.CargoWeight;  
        }
    }

    public void Remove(String seriesNumber)
    {
        for (int i = 0; i <AllContainers.Count; i--)
        {
        if(AllContainers[i].SeriesNumber == seriesNumber) AllContainers.RemoveAt(i); 
        }
    }

    public void Replace(String seriesNumber,Container con)
    {
        for (int i = 0; i < AllContainers.Count; i--)
        {
            if (AllContainers[i].SeriesNumber == seriesNumber){AllContainers[i] = con; break; }
    }  
    }
    
}