
using System.Data.Common;

namespace DozGame;

public class Board
{
    public Square[,] Squares { get; set; }
    public int Rows => 3;
    public int Columns => 3;

    public Board()
    {
        Squares = new Square[Rows, Columns];
        Thefirstvalue();
    }

    private void Thefirstvalue()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Squares[i, j] = new Square();
            }
        }
    }
    public bool IsWinningMove(char symbol)
    {
        return IsWinningRow(symbol) || IsWinningColumn(symbol) || IsWinninDiagonal(symbol);
    }

    private bool IsWinninDiagonal(char symbol)

    {
        for (int row = 0; row < Rows; row++)
        {
            if (Squares[row, row].Symbol != symbol)
            {
                return false;
            }
        }
        return true;
    }

    private bool IsWinningColumn(char symbol)
    {
        for (int row = 0; row < Rows; row++)
        {
            var IsWiningColumn = true;
            for (int column = 0; column < Columns; column++)
            {
                if (Squares[column, row].Symbol != symbol)
                {
                    IsWiningColumn = false;
                    break;
                }
            }
            if (IsWiningColumn)
            {
                return true;
            }
        }
        return false;
    }

    private bool IsWinningRow(char symbol)
    {
        {
            for (int column = 0; column < Columns; column++)
            {
                var IsWiningRows = true;
                for (int row = 0; row < Rows; row++)
                {
                    if (Squares[row, column].Symbol != symbol)
                    {
                        IsWiningRows = false;
                        break;
                    }
                }
                if (IsWiningRows)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public bool IsFull()
    {
        for (int j = 0; j < Columns; j++)
        {
            for (int i = 0; i < Rows; i++)
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
        if (!IsSquaresTaken(dozGameModel.Row, dozGameModel.Column))
        {
        }

        {
            Squares[dozGameModel.Row, dozGameModel.Column].SetSquare(dozGameModel.Symbol);
        }
    }
}
