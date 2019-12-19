using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeGUI
{
    public class AddFigureFormResult : IEnumerable<CellPoint>
    {
        public int StartX { get; private set; }
        public int StartY { get; private set; }
        public CellPoint[] Cells { get; private set; }
        public int FieldWidth { get; private set; }
        public int FieldHeight { get; set; }
        public AddFigureFormResult(int x, int y, CellPoint[] cells, int width, int height)
        {
            StartX = x;
            StartY = y;
            Cells = new CellPoint[cells.Length];
            FieldWidth = width;
            FieldHeight = height; 
            for (int i = 0; i < cells.Length; i++) 
            { 
                int cellX, cellY;
                cellX = (StartX + cells[i].X) % FieldWidth;
                cellY = (StartY + cells[i].Y) % FieldHeight;
                Cells[i] = new CellPoint(cellX, cellY);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cells.GetEnumerator();
        }

        public IEnumerator<CellPoint> GetEnumerator()
        {
            return Cells.ToList().GetEnumerator();
        }
    }
}
