namespace DozGame;

public class Board
{
    public Square[,] Squares { get; set; }
    public int Rows => 3;
    public int Column => 3;

    public Board()
    {
        Squares = new Square[Rows, Column];
        Thefirstvalue();
    }

    private void Thefirstvalue()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Column; j++)
            {
                Squares = new Square[i, j];
            }
        }
    }

    public bool IsFull()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; i < Column; j++)
            {
                if (Squares[i, j].IsTaken())
                {
                    return false;
                }
            }
        }

        return true;
    }

    public bool IsSquaresTaken(int row, int cloumn)
    {
        return Squares[row, cloumn].IsTaken();
    }

    public void SetSquares(DozGameModel dozGameModel)
    {
        if (!IsSquaresTaken(dozGameModel.Row,dozGameModel.Column))
        {
        }

        {
            Squares[dozGameModel.Row, dozGameModel.Column].SetSquare(dozGameModel.Symbol);
        }
    }
}