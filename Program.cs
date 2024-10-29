namespace GruppÖvning_spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var player = new Player();
            
        }
    }
}

class Player
{
    List<GameConsole> gameConsole = new List<GameConsole>();
    public AddGame(GameConsole console)
    {
        gameConsole.Add(console);
    }
}

class GameConsole
{
    GameLibrary gameLibrary = new GameLibrary();
}

class Game
{
    Level level = new Level();
    Processor processor = new Processor();
    GraphicsCard graphicsCard = new GraphicsCard();
}
class Level
{

}

class GameLibrary
{
    List<Game> games = new List<Game>();

    public AddGame(Game game)
    {
        gameLibrary.Add(game);
    }
}
class Processor
{

}
class GraphicsCard
{

}