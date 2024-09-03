namespace DozGame;

public class Player(int id, string name, bool isCurrentlyPlaying, char symbol)
{
    public int Id { get; set; } = id;
    private readonly Score _score = new Score();
    public string Name { get; set; } = name;
    public bool IsCurrentlyPlaying { get; set; } = isCurrentlyPlaying;
    public char Symbol { get; set; } = symbol;
}



