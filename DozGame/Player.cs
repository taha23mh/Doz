namespace DozGame;

public class Player(int id, string name, bool isCurrentlyPlaying, char symbol)
{
    public int Id { get; set; } = id;
    private readonly Score _score = new Score();
    public string Name { get; set; } = name;
    public bool IsCurrentlyPlaying { get; set; } = isCurrentlyPlaying;
    public char Symbol { get; set; } = symbol;

    public void SetCurrentlyPlaying(bool isCurrentlyPlaying)
    {
        IsCurrentlyPlaying = isCurrentlyPlaying; 
    }
    public void AddWin()
    {
        _score.IncrementWins();
    }
    public void AddDraw()
    {
        _score.IncrementDraws();
    }
    public void AddLose()
    {
        _score.IncrementLoses();
    }
    public void ResetScore()
    {
        _score.Reset();
    }
    public Score Score => _score;
}



