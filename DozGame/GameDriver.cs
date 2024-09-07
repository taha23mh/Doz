namespace DozGame;

public class GameDriver
{
    public Game Game { get; set; }
    public List<Player> players => [new(1, "name1", true, 'o'),
                                    new(2, "name2", false, 'x'),];
    public GameDriver()
    {
        Game = new Game(new Board(), players);
    }
    public void SetSquare(DozGameModel dozGameModel)
    {
        Game.SetSquare(dozGameModel);
    }
    public void SwitchPlayer()
    {
        Game.SwitchPlayer();
    }
    public void RestGame()
    {
        if (!Game.IsDraw())
        {
        
        Game.GetLoser()?.AddLose();
            Game.GetWinner()?.AddWin();
        }
        else
        {
            Game.Players.ForEach(players => players.AddDraw());
        }
        Game = new Game(new Board(), players);
    }
    public Player GetWinner()
    {
        return Game.GetWinner();
    }
    public int Rows => Game.Board.Rows;
    public int Columns => Game.Board.Columns;

    public bool IsSquareTaken(int row, int column)
    {
        return Game.Board.IsSquaresTaken(row, column);
    }
    public Square GetSquare(int row, int column)
    {
        return Game.Board.Squares[row, column];
    }
    public Player Currentplayer => Game.Players.First(players => players.IsCurrentlyPlaying);
}