using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace GameLifeGUI
{
    class Field : IEnumerable<CellPoint>
    {
        private int _width;
        private int _height;
        public Field()
        {
            cells = new List<CellPoint>();
        }
        public int Width
        {
            get => _width;
            set => _width = (value > 0) ? value : 0;
        }
        public int Height
        {
            get => _height;
            set => _height = (value > 0) ? value : 0;
        }
        private List<CellPoint> cells;
        public bool IsCorrectCoordinate(int x, int y) => x >= 0 && x < Width && y >= 0 && y < Height;
        private bool IsFieldEmpty() => cells.Count == 0;
        public void AddLivingCells(CellPoint[] cls)
        {
            foreach (var cell in cls)
                AddLivingCell(cell);
        }
        public void AddLivingCell(CellPoint cell)
        {
            if (!cells.Contains(cell) && IsCorrectCoordinate(cell.X, cell.Y))
                cells.Add(cell);
        }
        public void DeleteLivingCells(CellPoint[] cells)
        {
            foreach (var cell in cells)
                DeleteLivingCell(cell);
        }
        public void DeleteLivingCell(CellPoint cell) => cells.Remove(cell);
        public void ClearField() => cells.Clear();
        public void CreateNextGeneration()
        {
            var nextGenCells = new List<CellPoint>();
            var field = new bool[Width, Height];
            foreach (var cell in cells)
                field[cell.X, cell.Y] = true;
            for (int x = 0; x < Width; x++)
                for(int y = 0; y < Height; y++)
                {
                    var countNeight = CalculateCountNeightborsCell(field, x, y);
                    if (field[x, y] && (countNeight == 2 || countNeight == 3))
                        nextGenCells.Add(new CellPoint(x, y));
                    if (countNeight == 3)
                        nextGenCells.Add(new CellPoint(x, y));
                }
            cells = nextGenCells;
        }
        public int CalculateCountNeightborsCell(bool[,] field, int x, int y)
        {
            var ret = 0;
            for (int dx = -1; dx <= 1; dx++)
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0)
                        continue;
                    var cx = x + dx;
                    var cy = y + dy;
                    if (cx < 0 || cx == Width)
                        cx = Width - Abs(cx);
                    if (cy < 0 || cy == Height)
                        cy = Height - Abs(cy);
                    if (field[cx, cy])
                        ret++;
                }
            return ret;
        }
        //public void CreateNextGeneration()
        //{
        //    SetCountNeightborsCells(cells);
        //    var nextGeneratironCells = cells.Where(x => x.CountNeighbors == 2 || x.CountNeighbors == 3)
        //                                    .ToList();
        //    foreach (var cell in cells)
        //    {
        //        var offsets = new (int, int)[] { (-1, -1), (0, -1), (1, -1), (-1, 0), (1, 0), (-1, 1), (0, 1), (1, 1) };
        //        for (int i = 0; i < offsets.Length; i++)
        //        {
        //            var anotherCell = new CellPoint(cell.X + offsets[i].Item1, cell.Y + offsets[i].Item2);
        //            if (anotherCell.X == -1 || anotherCell.X == Width)
        //                anotherCell.X = Width - Abs(anotherCell.X);
        //            if (anotherCell.Y == -1 || anotherCell.Y == Height)
        //                anotherCell.Y = Height - Abs(anotherCell.Y);
        //            if (nextGeneratironCells.Contains(anotherCell))
        //                continue;
        //            CalculateCountNeightborsCell(cells, anotherCell);
        //            if (anotherCell.CountNeighbors == 3)
        //                nextGeneratironCells.Add(anotherCell);
        //        }
        //    }
        //    cells = nextGeneratironCells;
        //}
        //private void SetCountNeightborsCells(List<CellPoint> cells)
        //{
        //    foreach (var cell in cells)
        //        cell.CountNeighbors = CalculateCountNeightborsCell(cells, cell);
        //}
        //private int CalculateCountNeightborsCell(List<CellPoint> cells, CellPoint cell)
        //{
        //    Func<CellPoint, bool> onCenter = (x => Abs(cell.X - x.X) <= 1 && Abs(cell.Y - x.Y) <= 1);
        //    Func<CellPoint, bool> onLRBorder = (x => Abs(cell.X - x.X) == Width - 1 && Abs(cell.Y - x.Y) <= 1);
        //    Func<CellPoint, bool> onTBBorder = (x => Abs(cell.X - x.X) <= 1 && Abs(cell.Y - x.Y) == Height - 1);
        //    Func<CellPoint, bool> onCorner = (x => Abs(cell.X - x.X) == Width - 1 && Abs(cell.Y - x.Y) == Height - 1);
        //    Func<CellPoint, bool> onSelf = (x => cell.X == x.X && cell.Y == x.Y);

        //    if (cell.X == 0 || cell.X == Width - 1 || cell.Y == 0 || cell.Y == Height - 1)
        //        cell.CountNeighbors = cells.Where(x => !onSelf(x) && (onCenter(x) || onLRBorder(x) || onTBBorder(x) || onCorner(x)))
        //                                   .Count();
        //    else
        //        cell.CountNeighbors = cells.Where(x => !onSelf(x) && onCenter(x))
        //                                   .Count();
        //    return cell.CountNeighbors;
        //}

        public IEnumerator<CellPoint> GetEnumerator()
        {
            return cells.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cells.GetEnumerator();
        }
    }
}
