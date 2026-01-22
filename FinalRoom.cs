namespace DungeonCrawler;

public class FinalRoom : Room
{
    public FinalRoom(string name, string description, int x, int y, int type) : base(name, description, x, y, type)
    {
        
    }

    public bool PromptPassword()
    {
        Console.WriteLine("Enter the first key.");
        
        string first_key = Console.ReadLine()!;

        return true;
    }

}