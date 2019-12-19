using System.Drawing;

namespace GameLifeGUI
{
    public class CellPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int CountNeighbors { get; set; }
        public CellPoint(int x, int y) : this(x, y, Color.Black)
        {

        }
        public CellPoint(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;
            CellPoint p = (CellPoint)obj;
            return (X == p.X) && (Y == p.Y);
        }
        public override int GetHashCode() => base.GetHashCode();
    }
}
