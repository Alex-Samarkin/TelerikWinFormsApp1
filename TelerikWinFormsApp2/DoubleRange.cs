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
    public partial class DoubleRange : UserControl
    {
        public DoubleRange()
        {
            InitializeComponent();
        }

        [Category("User input")]
        public string Title { get => radGroupBox1.HeaderText; set => radGroupBox1.HeaderText = value; }
        [Category("User input")]
        public string SubTitle { get => radGroupBox1.FooterText; set => radGroupBox1.FooterText = value; }
        [Category("User input")]
        public double From
        {
            get => labeledDoubleValye1.Value;
            set => labeledDoubleValye1.Value = value;
        }
        [Category("User input")]
        public double To
        {
            get => labeledDoubleValye2.Value;
            set => labeledDoubleValye2.Value = value;
        }
        [Category("User input")]
        public double MinValue
        {
            get
            {
                labeledDoubleValye2.MinValue = labeledDoubleValye1.MinValue;
                return labeledDoubleValye2.MinValue;
            }
            set
            {
                labeledDoubleValye2.MinValue = value;
                labeledDoubleValye1.MinValue = value;
            }
        }
        [Category("User input")]
        public double MaxValue
        {
            get
            {
                labeledDoubleValye2.MaxValue = labeledDoubleValye1.MaxValue;
                return labeledDoubleValye2.MaxValue;
            }
            set
            {
                labeledDoubleValye2.MaxValue = value;
                labeledDoubleValye1.MaxValue = value;
            }
        }
    }
}

