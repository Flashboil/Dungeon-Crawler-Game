using DungeonCrawler;

Map map = new Map();

map.AddRoom((0,1), new Room("hall", "It's a hallway", 0, 1, 4));
map.AddRoom((1,1), new Room("fork", "fork", 1, 1, 10));
map.AddRoom((2,1), new Room("end", "it's the end", 2, 1, 14));
map.AddRoom((1,2), new Room("end", "it's the other end", 2, 2, 13));

while (true)
{
    map.PlayGame();
}