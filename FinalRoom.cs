namespace DungeonCrawler;

public class FinalRoom : Room
{
    public FinalRoom(string name, string description, int x, int y, int type) : base(name, description, x, y, type)
    {
        
    }

    public override bool PromptPassword()
    {
        // Prompt for password
        Console.WriteLine("Enter the first key.");
        string first_key = Console.ReadLine()!;

        Console.WriteLine("Enter the second key.");
        string second_key = Console.ReadLine()!;

        Console.WriteLine("Enter the third key.");
        string third_key = Console.ReadLine()!;

        // Check if password entered is '754'
        if (first_key == "7")
        {
            if (second_key == "5")
            {
                if (third_key == "4")
                {
                    return true;
                }
            }
        }

        Console.WriteLine("The door doesn't budge. That isn't the password.\nMaybe you should explore more to discover the password.");

        return false;
    }

}