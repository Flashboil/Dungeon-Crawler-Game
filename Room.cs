namespace DungeonCrawler;

public class Room
{
    private string _name;
    private string _description;
    private (int x, int y) _coordinates;

    public Room(string name, string description, int x, int y)
    {
        _name = name;
        _description = description;
        _coordinates = (x, y);
    }
    
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public (int, int) GetCoordinates()
    {
        return _coordinates;
    }

}