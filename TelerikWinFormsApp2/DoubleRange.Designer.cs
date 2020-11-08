namespace TelerikWinFormsApp2
{
    partial class DoubleRange
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.labeledDoubleValye1 = new TelerikWinFormsApp2.LabeledDoubleValye();
            this.labeledDoubleValye2 = new TelerikWinFormsApp2.LabeledDoubleValye();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.labeledDoubleValye2);
            this.radGroupBox1.Controls.Add(this.labeledDoubleValye1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.FooterText = "Диапазон (от и до)";
            this.radGroupBox1.FooterVisibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radGroupBox1.HeaderText = "Диапазон";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(396, 159);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Диапазон";
            this.radGroupBox1.ThemeName = "Material";
            // 
            // labeledDoubleValye1
            // 
            this.labeledDoubleValye1.BackColor = System.Drawing.Color.YellowGreen;
            this.labeledDoubleValye1.DecPlaces = 3;
            this.labeledDoubleValye1.Location = new System.Drawing.Point(5, 30);
            this.labeledDoubleValye1.MaxValue = 100D;
            this.labeledDoubleValye1.MinValue = -100D;
            this.labeledDoubleValye1.Name = "labeledDoubleValye1";
            this.labeledDoubleValye1.Size = new System.Drawing.Size(373, 48);
            this.labeledDoubleValye1.TabIndex = 0;
            this.labeledDoubleValye1.Title = "От";
            this.labeledDoubleValye1.Value = 0D;
            // 
            // labeledDoubleValye2
            // 
            this.labeledDoubleValye2.BackColor = System.Drawing.Color.DarkOrange;
            this.labeledDoubleValye2.DecPlaces = 3;
            this.labeledDoubleValye2.Location = new System.Drawing.Point(5, 84);
            this.labeledDoubleValye2.MaxValue = 100D;
            this.labeledDoubleValye2.MinValue = -100D;
            this.labeledDoubleValye2.Name = "labeledDoubleValye2";
            this.labeledDoubleValye2.Size = new System.Drawing.Size(373, 48);
            this.labeledDoubleValye2.TabIndex = 1;
            this.labeledDoubleValye2.Title = "До";
            this.labeledDoubleValye2.Value = 0D;
            // 
            // DoubleRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "DoubleRange";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(402, 165);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private LabeledDoubleValye labeledDoubleValye2;
        private LabeledDoubleValye labeledDoubleValye1;
    }
}
