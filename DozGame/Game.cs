using System.Security.Cryptography.X509Certificates;

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
    public void SetSquare(DozGameModel dozGameModel)
    {
       Board.SetSquares(dozGameModel);
    }
   public void SwitchPlayer()
    {
        var nextPlayer = _players.First(Player => !Player.IsCurrentlyPlaying);
        var CurrentPlayer =_players.First(Player =>Player.IsCurrentlyPlaying);
        CurrentPlayer.SetCurrentlyPlaying(false);
        nextPlayer.SetCurrentlyPlaying(true);
    }
    public bool IsGameOver()
    {
        return GetWinner() != null || IsDraw(); 
    }
    public bool IsDraw()
    {
        var currentPlayer = _players.First(Player => Player.IsCurrentlyPlaying);
        var IsWinningMove = _board.IsWinningMove(currentPlayer.Symbol);
        return !_board.IsWinningMove(currentPlayer.Symbol) && _board.IsFull();
    }
    public Player GetWinner()
    {
        var currentPlayer = _players.First(Player => Player.IsCurrentlyPlaying);
        var IsWinningMove = _board.IsWinningMove(currentPlayer.Symbol);
        return currentPlayer;
    }
    public Player GetLoser()

    {
        var winner = GetWinner();
        if (winner != null)
        { 
            return _players.First(Player=>Player.Id != winner.Id);
        }
        else
        {
        return null;
        }
    }
    public Board Board => _board;
    public List<Player> Players => _players;
}