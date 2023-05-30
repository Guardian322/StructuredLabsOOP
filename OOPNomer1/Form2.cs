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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkBox.Checked)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();

                btn.Location = new System.Drawing.Point(e.X - btn.Size.Width / 2, e.Y - btn.Size.Height / 2);

                btn.Click += new System.EventHandler(this.btnEmpty_Click);
                this.Controls.Add(btn);
            }
        }

        private void btnColr_Click(object sender, EventArgs e)
        {
            if (btnColr.BackColor == Color.White) btnColr.BackColor = Color.Red;
            else if (btnColr.BackColor == Color.Red) btnColr.BackColor = Color.Blue;
            else if (btnColr.BackColor == Color.Blue) btnColr.BackColor = Color.Yellow;
            else btnColr.BackColor = Color.White;
        }

        private void btnBlink_Click(object sender, EventArgs e)
        {
            btnBlink.Location = new Point(((btnBlink.Location.X^2)*2)%this.Size.Width, ((btnBlink.Location.Y ^ 2)*2) % this.Size.Height);
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            lblKey.ForeColor = Color.Brown;
            lblKey.Text = e.KeyCode.ToString();
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            lblKey.ForeColor = Color.Black;
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if(chkBox.Checked == false ) this.Controls.Remove(sender as Button);
        }

        int counterSize = 0;
        private void Form2_Resize(object sender, EventArgs e)
        {
            counterSize++; lblSize.Text = counterSize.ToString();
        }
    }
}
