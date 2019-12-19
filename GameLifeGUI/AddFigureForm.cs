using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GameLifeGUI
{
    public partial class AddFigureForm : Form
    {
        private Dictionary<string, CellPoint[]> figures;
        private int cellWidth, cellHeight;
        private int xMin, yMin;
        public int FieldWidth { get; set; }
        public int FieldHeight { get; set; }
        public AddFigureFormResult Result { get; private set; }
        public AddFigureForm()
        {
            figures = new Dictionary<string, CellPoint[]>();
            InitializeComponent();
            GetFiguresFromDirectory("figures");
        }
        public void DisplayFigures()
        {
            foreach (var figure in figures)
                listFigures.Items.Add(figure.Key);
        }
        private void GetFiguresFromDirectory(string path)
        {
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException($"Directory not found {path}");
            var fileTypes = new Dictionary<string, Action<string>>()
            {
                { ".cells", ParsePlaintextFile },
            };
            foreach (var filePath in Directory.GetFiles(path))
            {
                var fileExt = Path.GetExtension(filePath).ToLower();
                if (fileTypes.ContainsKey(fileExt))
                    fileTypes[fileExt](filePath);
            }
            DisplayFigures();
        }
        private void ParsePlaintextFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("", path);
            var ret = new List<CellPoint>();
            int lineNumber = 0;
            foreach (var line in File.ReadAllLines(path))
            {
                if (line.Length == 0 || line[0] == '!')
                    continue;
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == 'O')
                        ret.Add(new CellPoint(i, lineNumber));
                lineNumber++;
            }
            var name = Path.GetFileNameWithoutExtension(path);
            if (!figures.ContainsKey(name))
                figures.Add(name, ret.ToArray());
        }
        private void CalculateFigureSampleParams(CellPoint[] cells)
        {
            if (cells.Length == 0)
                return;
            int width, height;
            width = cells.Select(x => x.X).Max();
            height = cells.Select(x => x.Y).Max();

            cellWidth = picSampleFigure.ClientSize.Width / (width + 2);
            cellHeight = picSampleFigure.ClientSize.Height / (height + 2);
            if (cellWidth > cellHeight)
                cellWidth = cellHeight;
            else
                cellHeight = cellWidth;
            xMin = (picSampleFigure.ClientSize.Width - width * cellWidth) / 2;
            yMin = (picSampleFigure.ClientSize.Height - height * cellHeight) / 2;
        }
        private void DrawCell(Graphics gr, CellPoint cell)
        {
            int x, y;
            x = xMin + cell.X * cellWidth;
            y = yMin + cell.Y * cellHeight;
            var rect = new Rectangle(x, y, cellWidth, cellHeight);
            SolidBrush brush = new SolidBrush(cell.Color);
            gr.DrawRectangle(new Pen(brush), rect);
            gr.FillRectangle(brush, rect);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtInputX.Text);
            var y = int.Parse(txtInputY.Text);
            var figure = listFigures.SelectedItem as string;
            var cells = figures[figure];
            Result = new AddFigureFormResult(x, y, cells, FieldWidth, FieldHeight);
        }

        private void DrawFigureSample(string figure)
        {
            if (figures.ContainsKey(figure))
            {
                var cells = figures[figure];
                CalculateFigureSampleParams(cells);
                Bitmap bm = new Bitmap(
                    picSampleFigure.ClientSize.Width,
                    picSampleFigure.ClientSize.Height);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    foreach (var cell in cells)
                        DrawCell(gr, cell);
                }
                picSampleFigure.Image = bm;
            }
        }
        private void listFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = sender as ListBox;
            var index = list.SelectedIndex;
            if (index != -1)
            {
                var item = list.SelectedItem as string;
                DrawFigureSample(item);
            }
        }
    }
}
