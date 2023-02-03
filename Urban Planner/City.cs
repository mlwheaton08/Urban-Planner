namespace Urban_Planner;

public class City
{
    public string Mayor;
    public DateTime YearEstablished;
    public string Name;
    public List<Building> Buildings = new List<Building>();

    public City(string name)
    {
        Name = name;
    }

    public void AddBuildings(params Building[] buildings)
    {
        foreach (Building building in buildings)
        {
            Buildings.Add(building);
        }
    }
}