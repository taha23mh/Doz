namespace DozGame;

public class Square
{
    public char Symbol { get; set; }

    public Square()
    {
        Symbol = '\0';
    }

    public bool IsTaken()
    {
        return Symbol != '\0';
    }

    public void SetSquare(char symbol)
    {
        Symbol = symbol; 
    }
}