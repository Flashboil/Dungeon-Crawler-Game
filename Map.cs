using System.Net;

namespace DungeonCrawler;

public class Map
{
    private Dictionary<(int, int), Room> _rooms;
    private (int player_x, int player_y) _playerLocation;

    public Map()
    {
        _rooms = new Dictionary<(int, int), Room>();
        _playerLocation = (0, 0);

        _rooms![(0, 0)] = new Room(
            "The Entryway", 
            "You find yourself in dimly lit chamber. Before you is a door leading into a dark hallway.", 
            0, 0, 
            11
            );
    }

    public void PlayGame()
    {
        // Display the room name, description, and movement options.
        Console.WriteLine($"{GetRoom(_playerLocation).GetName()}\n");
        Console.WriteLine($"{GetRoom(_playerLocation).GetDescription()}\n");
        Console.WriteLine("Enter the direction you want to go. Type 'n' for north, 's' for south, etc.");

        // Find valid movements based on current room type.
        int roomType = GetRoom(_playerLocation).GetRoomType();
        List<string> options = GetValidMoves(roomType);

        Console.Write("Your options are:\n(");

        foreach (string option in options)
        {
            Console.Write($" {option} ");
        }

        Console.WriteLine(")");

        // Prompt player for movement, update player location.
        string move_direction = GetMovementResponse(options);

        MovePlayer(move_direction);
    }

    public List<string> GetValidMoves(int type)
    {
        List<string> options = new List<string>();

        HashSet<int> north = new(){0, 2, 3, 6, 7, 9, 10, 11};
        HashSet<int> east = new(){1, 2, 3, 4, 7, 8, 10, 12};
        HashSet<int> south = new(){0, 2, 4, 5, 7, 8, 9, 13};
        HashSet<int> west = new(){1, 2, 5, 6, 8, 9, 10, 14};

        if (north.Contains(type))
        {
            options.Add("n");
        }

        if (east.Contains(type))
        {
            options.Add("e");
        }

        if (south.Contains(type))
        {
            options.Add("s");
        }

        if (west.Contains(type))
        {
            options.Add("w");
        }

        return options;
    }

    public string GetMovementResponse(List<string> options)
    {
        string response = Console.ReadLine()!;

        while (!options.Contains(response)){
            Console.WriteLine("That is not a valid movement option.");

            response = Console.ReadLine()!;
        }

        return response;
    }

    public void MovePlayer(string movement)
    {
        if (movement == "n")
        {
            _playerLocation.player_y += 1;
        }
        else if (movement == "e")
        {
            _playerLocation.player_x += 1;
        }
        else if (movement == "s")
        {
            _playerLocation.player_y -= 1;
        }
        else if (movement == "w")
        {
            _playerLocation.player_x -= 1;
        }
    }
    
    public void AddRoom((int, int) coordinates, Room newroom)
    {
        _rooms[coordinates] = newroom;
    }

    public Room GetRoom((int, int) coordinates)
    {
        return _rooms[coordinates];
    }

    public void DisplayMap()
    {
        
    }
}