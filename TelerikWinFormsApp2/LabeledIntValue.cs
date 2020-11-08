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
    public partial class LabeledIntValue : UserControl
    {
        public LabeledIntValue()
        {
            InitializeComponent();

            Title = "Выберите";

            MinValue = 0;
            Value = 1;
            MaxValue = 100;
        }
        
        [Category("User Input")]
        public int Value
        {
            get
            {
                return (int)this.radSpinEditor1.Value;
            }
            set
            {
                radSpinEditor1.Value = value;
                radLinearGauge1.Value = value;
            }
        }
        [Category("User Input")]
        public int MinValue
        {
            get
            {
                return (int)radSpinEditor1.Minimum;
            }
            set
            {
                radSpinEditor1.Minimum = value;
                radLinearGauge1.RangeStart = value;
                linearGaugeBar1.RangeStart = value;
            }
        }
        [Category("User Input")]
        public int MaxValue
        {
            get
            {
                return (int)radSpinEditor1.Maximum;
            }
            set
            {
                radSpinEditor1.Maximum = value;
                radLinearGauge1.RangeEnd = value;
                linearGaugeBar1.RangeEnd = value;
            }

        }
        [Category("User Input")]
        public string Title {
            get
            {
                return radLabel1.Text;
            }
            set
            {
                radLabel1.Text = value;
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            Value = (int)radSpinEditor1.Value;
        }
    }
}
