using System.Security.AccessControl;

namespace DozGame;

public class DozGameModel(int row, int column,char symbol)
{
    public int Row { get; set; } = row;
    public int Column { get; set; } = column;
    public char Symbol { get; set; } = symbol;
}
