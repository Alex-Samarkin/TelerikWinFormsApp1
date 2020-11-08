namespace TelerikWinFormsApp2
{
    partial class LabeledIntValue
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLinearGauge1 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar1 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine1 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks1 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels1 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeNeedleIndicator1 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(6, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "radLabel1";
            this.radLabel1.ThemeName = "Material";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSpinEditor1.Location = new System.Drawing.Point(194, 6);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.Size = new System.Drawing.Size(173, 36);
            this.radSpinEditor1.TabIndex = 1;
            this.radSpinEditor1.ThemeName = "Material";
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            // 
            // radLinearGauge1
            // 
            this.radLinearGauge1.BackColor = System.Drawing.Color.White;
            this.radLinearGauge1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radLinearGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar1,
            this.linearGaugeLine1,
            this.linearGaugeTicks1,
            this.linearGaugeLabels1,
            this.linearGaugeNeedleIndicator1});
            this.radLinearGauge1.Location = new System.Drawing.Point(3, 49);
            this.radLinearGauge1.Name = "radLinearGauge1";
            this.radLinearGauge1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.radLinearGauge1.RangeEnd = 120F;
            this.radLinearGauge1.Size = new System.Drawing.Size(367, 44);
            this.radLinearGauge1.TabIndex = 2;
            this.radLinearGauge1.Text = "radLinearGauge2";
            this.radLinearGauge1.ThemeName = "ControlDefault";
            this.radLinearGauge1.Value = 90F;
            // 
            // linearGaugeBar1
            // 
            this.linearGaugeBar1.AutoSize = true;
            this.linearGaugeBar1.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow;
            this.linearGaugeBar1.Name = "linearGaugeBar1";
            this.linearGaugeBar1.Offset = 25F;
            this.linearGaugeBar1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar1.RangeEnd = 120F;
            this.linearGaugeBar1.Width = 10F;
            this.linearGaugeBar1.Width2 = 70F;
            // 
            // linearGaugeLine1
            // 
            this.linearGaugeLine1.AutoSize = false;
            this.linearGaugeLine1.Bounds = new System.Drawing.Rectangle(0, 0, 15, 285);
            this.linearGaugeLine1.Name = "linearGaugeLine1";
            this.linearGaugeLine1.Offset = 22F;
            this.linearGaugeLine1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine1.RangeEnd = 120F;
            this.linearGaugeLine1.Width = 1.5F;
            // 
            // linearGaugeTicks1
            // 
            this.linearGaugeTicks1.AutoSize = false;
            this.linearGaugeTicks1.Bounds = new System.Drawing.Rectangle(0, 0, 15, 261);
            this.linearGaugeTicks1.Name = "linearGaugeTicks1";
            this.linearGaugeTicks1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks1.TicksCount = 12;
            this.linearGaugeTicks1.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks1.TicksLocationPercentage = 21F;
            this.linearGaugeTicks1.TicksOffset = 65;
            this.linearGaugeTicks1.TickThickness = 0.5F;
            // 
            // linearGaugeLabels1
            // 
            this.linearGaugeLabels1.AutoSize = false;
            this.linearGaugeLabels1.Bounds = new System.Drawing.Rectangle(0, 0, 219, 33);
            this.linearGaugeLabels1.LabelLocationPercentage = 10F;
            this.linearGaugeLabels1.LabelsCount = 3;
            this.linearGaugeLabels1.Name = "linearGaugeLabels1";
            this.linearGaugeLabels1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeNeedleIndicator1
            // 
            this.linearGaugeNeedleIndicator1.AutoSize = false;
            this.linearGaugeNeedleIndicator1.BindValue = true;
            this.linearGaugeNeedleIndicator1.Bounds = new System.Drawing.Rectangle(0, 0, 11, 223);
            this.linearGaugeNeedleIndicator1.Direction = Telerik.WinControls.UI.Gauges.Direction.Down;
            this.linearGaugeNeedleIndicator1.HorizontalLineWidth = 0;
            this.linearGaugeNeedleIndicator1.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator1.LocationPercentage = 17F;
            this.linearGaugeNeedleIndicator1.Name = "linearGaugeNeedleIndicator1";
            this.linearGaugeNeedleIndicator1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator1.Value = 90F;
            // 
            // LabeledIntValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLinearGauge1);
            this.Controls.Add(this.radSpinEditor1);
            this.Controls.Add(this.radLabel1);
            this.Name = "LabeledIntValue";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(373, 96);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator1;
    }
}
