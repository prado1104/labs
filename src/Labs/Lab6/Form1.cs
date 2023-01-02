using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Point _startPoint;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void picBoxColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = picBoxColor.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
                picBoxColor.BackColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(picBoxMain.Size.Width, picBoxMain.Size.Height);
            _graphics = Graphics.FromImage(_bitmap);
            picBoxMain.Image = _bitmap;
            _graphics.Clear(Color.White);
            figureList.SelectedIndex = 0;
        }

        private void picBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = new Point(e.X, e.Y);
        }

        private void picBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            var pen = new Pen(picBoxColor.BackColor, (float)numericUpDown1.Value);
            pen.DashStyle = GetPenStyle();
            
            switch (figureList.SelectedIndex)
            {
                // Line
                case 0:
                    _graphics.DrawLine(pen, _startPoint, new Point(e.X, e.Y));
                    picBoxMain.Invalidate();
                    break;
                // Rectangle
                case 1:
                    _graphics.DrawRectangle(pen, _startPoint.X, _startPoint.Y, e.X - _startPoint.X, e.Y - _startPoint.Y);
                    if (fillCheckbox.Checked)
                        _graphics.FillRectangle(GetBrush(), _startPoint.X, _startPoint.Y, e.X - _startPoint.X, e.Y - _startPoint.Y);
                    
                    picBoxMain.Invalidate();
                    break;
                // Ellipse
                case 2:
                    _graphics.DrawEllipse(pen, _startPoint.X, _startPoint.Y, e.X - _startPoint.X, e.Y - _startPoint.Y);
                    if (fillCheckbox.Checked)
                        _graphics.FillEllipse(GetBrush(), _startPoint.X, _startPoint.Y, e.X - _startPoint.X, e.Y - _startPoint.Y);
                    
                    picBoxMain.Invalidate();
                    break;
            }
        }

        private Brush GetBrush()
        {
            var foreColor = Color.White;
            var backColor = picBoxColor.BackColor;

            return brushStyleList.SelectedIndex switch {
                0 => new SolidBrush(backColor),
                1 => new HatchBrush(HatchStyle.Horizontal, foreColor, backColor),
                2 => new HatchBrush(HatchStyle.Vertical, foreColor, backColor),
                3 => new HatchBrush(HatchStyle.Percent50, foreColor, backColor),
                4 => new HatchBrush(HatchStyle.DiagonalBrick, foreColor, backColor),
                _ => new SolidBrush(backColor)
            };
        }

        private DashStyle GetPenStyle()
        {
            return penStyleList.SelectedIndex switch
            {
                0 => DashStyle.Solid,
                1 => DashStyle.Dash,
                2 => DashStyle.Dot,
                3 => DashStyle.DashDot,
                4 => DashStyle.DashDotDot,
                _ => DashStyle.Solid
            };
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            picBoxMain.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _graphics.Clear(Color.White);
                _graphics.DrawImage(Image.FromFile(openFileDialog1.FileName), 0, 0);
                picBoxMain.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                _bitmap.Save(saveFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AbouDialogForm().ShowDialog();
        }
    }
}