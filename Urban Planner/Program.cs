using Urban_Planner;

Building building1 = new Building("101 First St") { Width = 500.8, Depth = 200.9, Stories = 3 };
Building building2 = new Building("102 First St") { Width = 300.8, Depth = 600.9, Stories = 1 };
Building building3 = new Building("103 First St") { Width = 200.8, Depth = 300.9, Stories = 5 };

building1.Construct();
building2.Construct();
building3.Construct();

building1.Purchase("Owen");
building2.Purchase("Greg");
building3.Purchase("Sandy");

City city1 = new City("First City");
city1.AddBuildings(building1, building2, building3);

Console.WriteLine($"{city1.Name} containes these buildings:\n");
city1.Buildings.ForEach(building => building.DisplayInfo());