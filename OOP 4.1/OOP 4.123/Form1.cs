using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4._1
{
    public partial class Form1 : Form
    {
        public Graphics g;
        Pen pen = new Pen(Color.Black, 10);
        Brush selectedBrush = new SolidBrush(Color.White);
        Brush unselectedBrush = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void PaintAllCircles(Graphics g)
        {
            foreach (CCircle a in MasCircles)
            {
                Brush brush;
                if (a.Check())
                    brush = selectedBrush;
                else
                    brush = unselectedBrush;

                a.Repaint(pen, brush, g);
            }
        }
        void AllChangeCheck(bool _b)
        {
            foreach (CCircle a in MasCircles) a.ChangeCheck(_b);
        }
        List<CCircle> MasCircles = new List<CCircle>();
        bool flag=true;
        private void pnl_MouseClick_1(object sender, MouseEventArgs e)
        {
            List<CCircle> pricols = new List<CCircle>();
            foreach (CCircle i in MasCircles)
                {
                    if (i.ChkSelected(e.X - 25, e.Y - 25))
                    {
                    pricols.Add(i);
                    if (!CtrlPressed) AllChangeCheck(false);
                    i.ChangeCheck(true);
                    flag = false;
                    if (!chkbox2.Checked) break;
                    }
                }
            foreach (CCircle i in pricols) i.ChangeCheck(true);
            if (flag)
            {
                if(!CtrlPressed) AllChangeCheck(false);
                CCircle kryg = new CCircle(e.X - 25, e.Y - 25);
                MasCircles.Add(kryg);
            }
            flag = true;
            pnl.Invalidate();
        }

        bool CtrlPressed=false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (chkbox1.Checked == true)
            {
                if (e.KeyCode == Keys.ControlKey) CtrlPressed = true;
                else { CtrlPressed = false;}
            }
            if (e.KeyCode == Keys.Delete)
            {
                foreach (CCircle a in MasCircles.ToArray()) if(a.Check()) MasCircles.Remove(a);
                pnl.CreateGraphics().Clear(Color.White);
                MasCircles[MasCircles.Count - 1].ChangeCheck(true);
                pnl.Invalidate();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CtrlPressed = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            PaintAllCircles(e.Graphics);
        }
    }
    class CCircle
    {
        private int x, y;
        private int radius = 50;
        private bool check;
        
        public CCircle(int _x, int _y, bool _ch = true)
        {
            this.x = _x;
            this.y = _y;
            this.check = _ch;
        }
        public bool Check() { return this.check; }
        public void ChangeCheck(bool _newch)
        {
            this.check = _newch;
        }
        public bool ChkSelected(int _x, int _y)
        {
            return ((_x - this.x) * (_x - this.x) + (_y - this.y) * (_y - this.y)) <= (this.radius * this.radius / 4);

        }
        public void Repaint(Pen _pen, Brush _brush, Graphics g)
        {
            g.DrawEllipse(_pen, x, y, radius, radius);
            g.FillEllipse(_brush, x, y, radius, radius);
        }
    }
}
