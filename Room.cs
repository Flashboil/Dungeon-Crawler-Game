namespace DungeonCrawler;

public class Room
{
    private string _name;
    private string _description;
    private (int x, int y) _coordinates;

    public static readonly int[] roomTypes =
    {
        1, 2, 3, 4, 5,
        6, 7, 8, 9, 10,
        11, 12, 13, 14, 15
        
    }
        
    public static readonly string[] typeVisuals =
    {
        
    }

    public Room(string name, string description, int x, int y, )
    {
        _name = name;
        _description = description;
        _coordinates = (x, y);
        
        _roomType
        
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