namespace DozGame;

public class Game
{
    private readonly Board _board;
    private readonly List<Player> _players;

    public Game(Board board, List<Player> players)
    {
        _board = board;
        _players = players;
    }

    public Game()
    {
        _board = new Board();
        _players = new List<Player>()
        {
            new(1, "name1", true, 'o'),
            new(2, "name2", false, 'x'),
        };
    }
}