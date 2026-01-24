namespace DungeonCrawler;

public class Room
{
    private string _name;
    private string _description;
    private (int x, int y) _coordinates;
    private int _roomType;

    public static readonly int[] roomTypes =
    {
        0, 1, 2,
        3, 4, 5, 6,
        7, 8, 9, 10,
        11, 12, 13, 14
    };

    public Room(string name, string description, int x, int y, int type)
    {
        _name = name;
        _description = description;
        _coordinates = (x, y);
        
        _roomType = type;
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

    public int GetRoomType()
    {
        return _roomType;
    }

    public virtual bool PromptPassword()
    {
        return false;
    }
}