using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace GameLifeGUI
{
    public partial class MainForm : Form
    {
        private Field field;
        private int _latency;
        public int GameLatency
        {
            get => _latency;
            set
            {
                _latency = (value >= 0) ? value : 0;
            }
        }
        public MainForm() : this(100, 100)
        {

        }
        public MainForm(int fieldWidth, int fieldHeight)
        {
            field = new Field()
            {
                Width = fieldWidth,
                Height = fieldHeight,
            };
            InitializeComponent();
            backworkerRun.WorkerSupportsCancellation = true;
        }
        private int cellWidth, cellHeight;
        private int xMin, yMin;
        private void btnNextGen_Click(object sender, EventArgs e) => DisplayGeneration();

        public void DisplayGeneration()
        {
            int width, height;
            width = field.Width;
            height = field.Height;

            cellWidth = picGame.ClientSize.Width / (width + 2);
            cellHeight = picGame.ClientSize.Height / (height + 2);
            if (cellWidth > cellHeight)
                cellWidth = cellHeight;
            else
                cellHeight = cellWidth;
            xMin = (picGame.ClientSize.Width - width * cellWidth) / 2;
            yMin = (picGame.ClientSize.Height - height * cellHeight) / 2;

            DrawGeneration();
            field.CreateNextGeneration();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (backworkerRun.IsBusy != true)
            {
                btnNextGen.Enabled = false;
                btnRun.Enabled = false;
                backworkerRun.RunWorkerAsync();
            }
        }

        private void backworkerRun_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                DisplayGeneration();
                Thread.Sleep(GameLatency);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backworkerRun.WorkerSupportsCancellation == true)
            {
                btnNextGen.Enabled = true;
                btnRun.Enabled = true;
                backworkerRun.CancelAsync();
            }
        }

        private void btnAddFigure_Click(object sender, EventArgs e)
        {
            AddFigureForm form = new AddFigureForm()
            {
                FieldWidth = field.Width,
                FieldHeight = field.Height,
            };
            bool isGameRun = backworkerRun.IsBusy;
            if (isGameRun)
                backworkerRun.CancelAsync();
            
            if (form.ShowDialog(this) == DialogResult.OK)
                foreach (var cell in form.Result)
                    field.AddLivingCell(cell);
            
            if (isGameRun)
                backworkerRun.RunWorkerAsync();
            form.Dispose();
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
        private void DrawGeneration()
        {
            Bitmap bm = new Bitmap(
                picGame.ClientSize.Width,
                picGame.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (var cell in field)
                    DrawCell(gr, cell);
            }
            picGame.Image = bm;
        }
    }
}
