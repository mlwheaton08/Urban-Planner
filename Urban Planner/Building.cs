namespace Urban_Planner;

public class Building
{
    private string _designer = "Mason Wheaton";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    //public double Volume { get { return Width * Depth * (3 * Stories); } } //essentially makes it readonly, bc can't set it
    public double Volume => Width * Depth * (3 * Stories); //shorthand way to write the above

    public Building(string address)
    {
        _address = address;
    }

    public void Construct()
    {
        _dateConstructed = DateTime.Now;
    }

    public void Purchase(string name)
    {
        _owner = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($@"{_address}---------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space
");
    }
}
