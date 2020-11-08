using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TelerikWinFormsApp1.Database1DataSetTableAdapters;

namespace TelerikWinFormsApp1
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Измерения". При необходимости она может быть перемещена или удалена.
            this.измеренияTableAdapter.Fill(this.database1DataSet.Измерения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Визиты". При необходимости она может быть перемещена или удалена.
            this.визитыTableAdapter.Fill(this.database1DataSet.Визиты);
            this.radGridView1.AutoGenerateHierarchy = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.database1DataSet.Пациенты);

        }

        private void пациентыBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
            пациентыTableAdapter.Update(this.database1DataSet.Пациенты);
            визитыTableAdapter.Update(this.database1DataSet.Визиты);
            измеренияTableAdapter.Update(this.database1DataSet.Измерения);
        }
    }
}
