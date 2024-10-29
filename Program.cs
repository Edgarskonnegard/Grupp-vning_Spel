namespace GruppÖvning_spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var player = new Player();
            var gameConsole = new GameConsole("PS5");
            player.AddGameConsole(gameConsole);
            var game = new Game("SuperLuigiSisters");

        }
    }
}

public class Player
{
    List<GameConsole> gameConsole = new List<GameConsole>();
    public void AddGameConsole(GameConsole console)
    {
        gameConsole.Add(console);
    }
}

public class GameConsole
{
    public string Name { get; set; }

    public GameConsole(string name)
    {
        Name = name;
    }
    GameLibrary gameLibrary = new GameLibrary();

    Processor processor = new Processor();
    GraphicsCard graphicsCard = new GraphicsCard();

    public void ChooseGame()
    {
        gameLibrary.Show();
    }
}

public class Game
{
    public string Name { get; set; }
    public Game(string name)
    {
        Name = name;
    }
    Level level = new Level();
}
public class Level
{

}

public class GameLibrary
{
    List<Game> games = new List<Game>();

    public void Show()
    {
        foreach (var game in games)
        {
            Console.WriteLine(game.Name);
        }
    }

    public void AddGame(Game game)
    {
        games.Add(game);

    }
}
public class Processor
{

}
public class GraphicsCard
{

}