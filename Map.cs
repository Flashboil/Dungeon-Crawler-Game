namespace DungeonCrawler;

public class Map
{
    private List<Room> _rooms;

    public Map()
    {
        _rooms = new List<Room> { new Room("Root", "The entryway", 0, 0) };
    }

    public void GenerateMap()
    {
        
    }
    
    public void AddRoom(Room newroom)
    {
        _rooms.Add(newroom);
    }

    public Room GetRoom(int index)
    {
        return _rooms[index];
    }

    public void DisplayMap()
    {
        
    }
}