using System.Reflection;
using DungeonCrawler;

Map map = new Map();

// Initialize all rooms after root.
map.AddRoom((0,1), new Room(
"The Crossroads", 
"You come to a large stone chamber with doors going in every direction. A beam of light shines down in the center of the chamber, illuminating a small pool of water. To the North, you see a light illuminating some sort of mural in the next room.",
0, 1,
2));
map.AddRoom((0,2), new Room(
"The Mural",
"The floor of the small chamber is littered with candles. The Northern wall is completely covered by a mural.\n'COLLECT THE THREE KEYS OF KNOWLEDGE AND OFFER THEM AT THE VAULT'\nThe mural depicts a twisting bramble of branches with glowing keys at their ends. the Northmost branch has a lock.",
0, 2,
13
));
map.AddRoom((-1,1), new Room(
"The Western Corridor",
"You walk down the corridor to the West. The stonebound hall is lit by candles placed in alcoves along the walls.",
-1, 1,
1
));
map.AddRoom((-2,1), new Room(
"The Statue",
"At the end of the corridor stands a tall statue of robed figure.\nIn his left hand he holds an astrolabe with a dozen star charts tucked under his arm.\nIn his right he holds a crystal phial like those you've seen used by alchemists.\nTo the left (South) is a staircase leading upward. To the right (North) is a corridor lined with pipes.",
-2, 1,
7
));
map.AddRoom((-2,2), new Room(
"The Pipelines",
"The corridor to the North is lined with pipes of all sizes. A few drip a dark viscous liquid, forming puddles on the floors. Others leak clouds of vapor, obscuring your vision. You make your way through the fog and arrive at a door labeled 'LABORATORY'.",
-2, 2,
0
));
map.AddRoom((-2,3), new Room(
"The Laboratory",
"You enter a humid room full of pipes, beakers, and alchemical instruments fo every kind. All the pipes converge at a raised platform at the center. Valves and levers on the platforms seem to control the flow of the pipes' contents into the various machinery. A large tome is open on the table by the controls.\n'LET THE FIRST KEY BE FOUND IN THE ATOMIC NUMBER OF NIRTOGEN.'",
-2, 3,
13
));
map.AddRoom((-2,0), new Room(
"The Ascent",
"You ascend a spiral staircase lined with glittering gems and inscriptions of celestial bodies. At the base of the stairs is the Sun, and the planets follow in order: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, and Neptune.",
-2, 0,
3
));
map.AddRoom((-2,-1), new Room(
"The Observatory",
"You reach the top of the stairs and enter a glittering observatory. The ceiling above is a stone dome embedded with glowing stones, laid out to resemble the starry sky. A semicircle of desks implies that this was once a place where astronomy was taught. At the teacher's desk is a large tome.\n'LET THE SECOND KEY BE FOUND IN THE NUMBER OF THE PLANET BETWEEN MARS AND SATURN.'",
-2, -1,
11
));
map.AddRoom((1,1), new Room(
"The Eastern Corridor",
"You walk down the corridor to the East. The candles that line the walls illuminate the stony passageway.",
1, 1,
1
));
map.AddRoom((2,1), new Room(
"The Junction",
"You reach the end of the hallway and come before a large clock. To the right (South) is curved hallway lined with geometric tiles that quickly turns out fo view. To the left (North) in a stone corridor like the one you came from, but all the candles have gone out.",
2, 1,
9
));
map.AddRoom((2,0), new Room(
"The Spiral",
"The curving hallway begins to curve sharper and sharper as you walk along, like a snail's shell. The walls are tiled with pastel geometric shapes. Squares, hexagons, octagons, and triangles all interlock to form intricate patterns of color. You continue East, or as close as you can to East in this bizarre spiral, until you reach a wooden door.",
2, 0,
3
));
map.AddRoom((3,0), new Room(
"The Lyceum",
"The room is full of worktables heaped high with papers. The walls are covered in dials and instruments for counting. Most of the floor is likewise covered in papers, drafts of mathematical equations left scattered as the towering piles on the desks toppled. You notice a large tome nestled among all the other papers. As you approach it, you realize that a corpse lies buried among the pages.\n'LET THE THRID KEY BE FOUND IN THE SOLUTION TO OUR EQUATION.'\nAn absurdly long equation is written below, but it's almost solved. It seems your predecessor did most of the work for you before he met his unpleasant end.\n'2x + 3 = 11'",
3, 0,
14
));
map.AddRoom((2,2), new Room(
"The Dark",
"You advance down the dark hallway, feeling along the walls with your hands. The floor is sticky, but you can't tell with what. The air is cold and reeks of a strong metallic scent.",
2, 2,
0
));
map.AddRoom((2,3), new Room(
"The Forbidden Library",
"You arrive at a small library lit by a few dying candles. The walls are covered in bookshelves, yet the majority of them are locked shut with metal grates. Even in the dim lighting, you can see that three tomes are conspicuously absent from among the shelves. A door to the left (West) seems to lead to the end of this strange labyrinth.",
2, 3,
5
));
map.AddRoom((1,3), new FinalRoom(
"The Vault",
"Before you is a large vault door. Its dark metal surface etched with the image of a large branching tree. In the center of it is a giant lock composed of three circular dials. It seems you can use these dials to enter a three digit password.",
1, 3,
12
));

// Into text.
Console.WriteLine("~THE VAULT~\n");
Console.WriteLine("You came looking for something sealed here, deep underground. Look for clues and make your way to the end.\nWhen prompted, enter the direction you want to go.\n");
Console.Write("<ENTER>");
Console.Read();
Console.Clear();
// Main game loop.
bool running = true;
while (running)
{
    running = map.PlayGame();
}
// Win, final message and title.
Console.Clear();
Console.WriteLine("\nThe last lock clicks and the vault opens. You look inside and feel ██████ tear through your thoughts. Whatever ██████ is, you know at once that ██████ it was a mistake, because now you—\n");
Console.WriteLine("~THE VAULT~");
