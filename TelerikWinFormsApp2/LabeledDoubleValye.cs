using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelerikWinFormsApp2
{
    public partial class LabeledDoubleValye : UserControl
    {
        public LabeledDoubleValye()
        {
            InitializeComponent();

            Value = 0;
            MaxValue = 100;
            MinValue = -100;

            DecPlaces = 3;
        }

        [Category("User input")]
        public double Value
        {
            get => Convert.ToDouble(this.radSpinEditor1.Value);
            set => this.radSpinEditor1.Value = Convert.ToDecimal(value);
        }
        [Category("User input")]
        public double MaxValue { get=>(double)radSpinEditor1.Maximum; set=>radSpinEditor1.Maximum=(decimal)value; }
        [Category("User input")]
        public double MinValue { get => (double)radSpinEditor1.Minimum; set => radSpinEditor1.Minimum = (decimal)value; }
        [Category("User input")]
        public int DecPlaces
        {
            get => radSpinEditor1.DecimalPlaces;
            set => radSpinEditor1.DecimalPlaces = value;
        }
        [Category("User input")]
        public string Title { get=>radLabel1.Text; set=>radLabel1.Text = value; }


        private double Check(double x)
        {
            return x;
        }

        private void radCalculatorDropDown1_CalculatorValueChanged(object sender, EventArgs e)
        {
            //double d = (double)radCalculatorDropDown1.Value;
            //radCalculatorDropDown1.Value = this.Value;
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            Value = (double)radSpinEditor1.Value;
        }
    }
}
