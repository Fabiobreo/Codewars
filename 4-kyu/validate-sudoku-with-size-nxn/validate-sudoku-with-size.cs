using System;
using System.Collections.Generic;
using System.Linq;

public class Sudoku
{
    private readonly int[][] board;
    private readonly int boardWidth;
    private readonly int segmentWidth;

    public Sudoku(int[][] sudokuData)
    {
        board = sudokuData;
        boardWidth = sudokuData.Length;
        segmentWidth = (int)Math.Sqrt(boardWidth);
    }

    public bool IsValid()
    {
        return 
            GetRows().All(IsComponentValid) && 
            GetColumns().All(IsComponentValid) && 
            GetSegments().All(IsComponentValid);
    }

    public IEnumerable<int> GetRow(int row)
    {
        return board[row];
    }

    public IEnumerable<int> GetColumn(int column)
    {
        return board.Select(r => r[column]);
    }

    public IEnumerable<int> GetSegment(int x, int y)
    {
        return board
            .Where((r, ri) => ri / segmentWidth == x)
            .SelectMany(r => r.Where((c, ci) => ci / segmentWidth == y));
    }

    public IEnumerable<IEnumerable<int>> GetRows()
    {
        return Enumerable.Range(0, boardWidth).Select(GetRow);
    }

    public IEnumerable<IEnumerable<int>> GetColumns()
    {
        return Enumerable.Range(0, boardWidth).Select(GetColumn);
    }

    public IEnumerable<IEnumerable<int>> GetSegments()
    {
        return Enumerable.Range(0, boardWidth).Select(i => GetSegment(i / segmentWidth, i % segmentWidth));
    }

    public bool IsComponentValid(IEnumerable<int> values)
    {
        return values.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, boardWidth));
    }
}
