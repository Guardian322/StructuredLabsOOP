using OOPNomer1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPNomer1
{
    
    public partial class ForMain : Form
    {
        public ForMain()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblStep.Text = progBar.Step.ToString();
        }

        private void btnOpa_Click(object sender, EventArgs e)
        {
            tbDest.Text = "";
        }

        private void tbSource_TextChanged(object sender, EventArgs e)
        {
            tbDest.Text = tbSource.Text;
        }

        private void tbDest_TextChanged(object sender, EventArgs e)
        {
            tbSource.Text = tbDest.Text;
        }

        private void tbSource_KeyDown(object sender, KeyEventArgs e)
        {
            tbCode.Text = e.KeyValue.ToString();
        }

        private void ForMain_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordX.Text = e.X.ToString();
            lbCoordY.Text = e.Y.ToString();
        }

        private void ForMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkBox.Checked)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();

                btn.Location = new System.Drawing.Point(e.X - btn.Size.Width / 2, e.Y - btn.Size.Height / 2);

                btn.Click += new System.EventHandler(this.btnOpa_Click);
                this.Controls.Add(btn);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (progBar.Value < progBar.Maximum - progBar.Step) progBar.Value += progBar.Step;
            else progBar.Value = progBar.Maximum;
            if (progBar.Value == progBar.Maximum) lblcasino.Text = "Деньги с казино выкачаны";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            progBar.Value = 0;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (progBar.Step > 9) progBar.Step -= 10;
            lblStep.Text = progBar.Step.ToString();
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (progBar.Step < 491) progBar.Step += 10;
            lblStep.Text = progBar.Step.ToString();
        }

        private void btnOpa_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordX.Text = (e.X + btnOpa.Location.X).ToString();
            lbCoordY.Text = (e.Y + btnOpa.Location.Y).ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            if ((h + m + s) % 7 == 0) lblbtc.Text = "+0.001 bitcoin";
            else lblbtc.Text = "";
            string time = "";
            if (h < 10)
            {
                time += "0" + h + ":";
            }
            else
            {
                time += h + ":";
            }
            if (m < 10)
            {
                time += "0" + m + ":";
            }
            else
            {
                time += m + ":";
            }
            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }
            timeWin.Text = time;
        }

        private void btnSf_Click(object sender, EventArgs e)
        {
            pctrSF.Visible = !pctrSF.Visible;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chckTxtBox.Items.Add(dateTimePicker1.Text);
        }

        private void btnColr_Click(object sender, EventArgs e)
        {
            if (btnColr.BackColor == Color.White) btnColr.BackColor = Color.Red;
            else if (btnColr.BackColor == Color.Red) btnColr.BackColor = Color.Blue;
            else if (btnColr.BackColor == Color.Blue) btnColr.BackColor = Color.Yellow;
            else btnColr.BackColor = Color.White;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Form2 tt = new Form2();
            tt.Show();
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сведенияОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лаба 1 по ООП, норм");
        }
        int counterPaint = 0;
        private void ForMain_Paint(object sender, PaintEventArgs e)
        {
            counterPaint++; lblPaint.Text = counterPaint.ToString();
        }
    }
}
