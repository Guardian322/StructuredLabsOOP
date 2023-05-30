using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP4._2
{
    public partial class Form1 : Form
    {
        Model model;

        Int32 TxtToNumPlaceholder = -1;
        
        private void txtbxAll_Leave(object sender, EventArgs e)
        {
            if (sender == txtbxA)
            {
                Int32.TryParse(txtbxA.Text, out TxtToNumPlaceholder);
                if (Convert.ToBoolean(TxtToNumPlaceholder)) model.setValueA(TxtToNumPlaceholder);
                else model.observers.Invoke(this, null);
            }
            if (sender == txtbxB)
            {
                Int32.TryParse(txtbxB.Text, out TxtToNumPlaceholder);
                if (Convert.ToBoolean(TxtToNumPlaceholder)) model.setValueB(TxtToNumPlaceholder);
                else model.observers.Invoke(this, null);
            }
            if (sender == txtbxC)
            {
                Int32.TryParse(txtbxC.Text, out TxtToNumPlaceholder);
                if (Convert.ToBoolean(TxtToNumPlaceholder)) model.setValueC(TxtToNumPlaceholder);
                else model.observers.Invoke(this, null);
            }
        }
        private void txtbxAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(sender == txtbxA){
                    Int32.TryParse(txtbxA.Text, out TxtToNumPlaceholder);
                    if (Convert.ToBoolean(TxtToNumPlaceholder)) model.setValueA(TxtToNumPlaceholder);
                    else model.observers.Invoke(this, null);
                }
                if (sender == txtbxB)
                {
                    Int32.TryParse(txtbxB.Text, out TxtToNumPlaceholder);
                    if (Convert.ToBoolean(TxtToNumPlaceholder)) model.setValueB(TxtToNumPlaceholder);
                    else model.observers.Invoke(this, null);
                }
                if (sender == txtbxC)
                {
                    Int32.TryParse(txtbxC.Text, out TxtToNumPlaceholder);
                    if (Convert.ToBoolean(TxtToNumPlaceholder)) model.setValueC(TxtToNumPlaceholder);
                    else model.observers.Invoke(this, null);
                }
            }
        }

        private void nmrUpAll_ValueChanged(object sender, EventArgs e)
        {
            if (sender == nmrUpA) model.setValueA(Decimal.ToInt32(nmrUpA.Value));
            if (sender == nmrUpB) model.setValueB(Decimal.ToInt32(nmrUpB.Value));
            if (sender == nmrUpC) model.setValueC(Decimal.ToInt32(nmrUpC.Value));
        }
        private void trckbrAll_Scroll(object sender, EventArgs e)
        {
            if (sender == trckbrA) model.setValueA(trckbrA.Value);
            if (sender == trckbrB) model.setValueB(trckbrB.Value);
            if (sender == trckbrC) model.setValueC(trckbrC.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.LoadValues();
        }

        public Form1()
        {
            InitializeComponent();
            model = new Model();

            model.observers += new System.EventHandler(this.UpdateFromModel);
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            trckbrC.Value = model.getValueC();
            trckbrB.Value = model.getValueB();
            trckbrA.Value = model.getValueA();
            txtbxC.Text = model.getValueC().ToString();
            txtbxB.Text = model.getValueB().ToString();
            txtbxA.Text = model.getValueA().ToString();
            nmrUpC.Value = model.getValueC();
            nmrUpB.Value = model.getValueB();
            nmrUpA.Value = model.getValueA();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.SaveValues();
        }
    }
    public class Model
    {
        private int valueA, valueB, valueC;
        public System.EventHandler observers;
        public void setValueA(int _value)
        {
            if (_value > 100) _value = 100;
            if (_value < 0) _value = 0;
            this.valueA = _value;
            if (_value > this.valueC) this.valueC = _value;
            if (_value > this.valueB) this.valueB = _value;
            observers.Invoke(this, null);
        }
        public void setValueB(int _value)
        {
            if (_value > 100) _value = 100;
            if (_value < 0) _value = 0;
            if (_value <= this.valueA) this.valueB = this.valueA;
            else if (_value >= this.valueC) this.valueB = this.valueC;
            else this.valueB = _value;
            observers.Invoke(this, null);
        }
        public void setValueC(int _value)
        {
            if (_value > 100) _value = 100;
            if (_value < 0 ) _value = 0;
            this.valueC = _value;
            if (_value < this.valueA) this.valueA = _value;
            if (_value < this.valueB) this.valueB = _value;
            observers.Invoke(this, null);
        }
        public int getValueA()
        {
            return valueA;
        }
        public int getValueB()
        {
            return valueB;
        }
        public int getValueC()
        {
            return valueC;
        }
        public void SaveValues()
        {
            Properties.Settings.Default.data3A = valueA;
            Properties.Settings.Default.data3B = valueB;
            Properties.Settings.Default.data3C = valueC;
            Properties.Settings.Default.Save();
        }
        public void LoadValues()
        {
            valueA = Properties.Settings.Default.data3A;
            valueB = Properties.Settings.Default.data3B;
            valueC = Properties.Settings.Default.data3C;
            observers.Invoke(this, null);
        }
    }

}
