using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord;
using Accord.Controls;
using Accord.Math;
using Accord.Math.Random;
using Accord.Statistics;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Visualizations;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TelerikWinFormsApp2
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        public List<double> Id { get; set; } = new List<double>();
        public List<double> X { get; set; } = new List<double>();
        private void radButton1_Click(object sender, EventArgs e)
        {
            // чистим данные
            Id.Clear();
            X.Clear();

            // чистим графики
            scatterplotView1.Graph.GraphPane.CurveList.Clear();
            radChartView1.Series[0].DataPoints.Clear();
            radChartView2.Series[0].DataPoints.Clear();

            // параметиры для генерации выборки
            int N = this.labeledIntValue1.Value;
            double Xmin = this.doubleRange1.From;
            double Xmax = this.doubleRange1.To;

            // перепроверяем минумум-максимум
            if (Xmax < Xmin)
            {
                double tmp = Xmax;
                Xmax = Xmin;
                Xmin = tmp;
                doubleRange1.From = Xmin;
                doubleRange1.To = Xmax;
            }

            // генерируем индекс (можно быстрее, но так нагляднее)
            for (int i = 0; i < N; i++)
            {
                Id.Add(i);
            }

            // интервал для генератора случайных чисел
            Accord.DoubleRange range = new Accord.DoubleRange(Xmin,Xmax);

            // генератор
            UniformContinuousDistribution uniform = new UniformContinuousDistribution(range);

            // создание выборки объемом N
            X.AddRange(uniform.Generate(N));

            // визуализация - скаттерплот
            scatterplotView1.DataSource = X.ToArray();

            // визуализация - гистограмма
            Histogram histogram = new Histogram();
            histogram.Compute(X.ToArray());
            histogramView1.DataSource = histogram;

            for (int i = 0; i < N; i++)
            {
                radChartView1.Series[0].DataPoints.Add(new ScatterDataPoint(Id[i],X[i]));
            }

            foreach (HistogramBin bin in histogram.Bins)
            {
                string b = $"{bin.Range.Min}-{bin.Range.Max}";
                radChartView2.Series[0].DataPoints.Add(new CategoricalDataPoint(bin.Value,b));
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            // чистим данные
            Id.Clear();
            X.Clear();

            // чистим графики
            scatterplotView1.Graph.GraphPane.CurveList.Clear();
            radChartView1.Series[0].DataPoints.Clear();
            radChartView2.Series[0].DataPoints.Clear();

            // параметиры для генерации выборки
            int N = this.labeledIntValue2.Value;
            double Mx = this.labeledDoubleValye1.Value;
            double Std = this.labeledDoubleValye2.Value;

            // генерируем индекс (можно быстрее, но так нагляднее)
            for (int i = 0; i < N; i++)
            {
                Id.Add(i);
            }

            // генератор
            NormalDistribution norm = new NormalDistribution(Mx, Std);

            // создание выборки объемом N
            X.AddRange(norm.Generate(N));

            // визуализация - скаттерплот
            scatterplotView1.DataSource = X.ToArray();

            // визуализация - гистограмма
            Histogram histogram = new Histogram();
            histogram.Compute(X.ToArray());
            histogramView1.DataSource = histogram;

            for (int i = 0; i < N; i++)
            {
                radChartView1.Series[0].DataPoints.Add(new ScatterDataPoint(Id[i], X[i]));
            }

            foreach (HistogramBin bin in histogram.Bins)
            {
                string b = $"{bin.Range.Min}-{bin.Range.Max}";
                radChartView2.Series[0].DataPoints.Add(new CategoricalDataPoint(bin.Value, b));
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            // чистим данные
            Id.Clear();
            X.Clear();

            // чистим графики
            scatterplotView1.Graph.GraphPane.CurveList.Clear();
            radChartView1.Series[0].DataPoints.Clear();
            radChartView2.Series[0].DataPoints.Clear();

            // параметиры для генерации выборки
            int N = this.labeledIntValue3.Value;
            double rate = this.labeledDoubleValye3.Value;

            // генерируем индекс (можно быстрее, но так нагляднее)
            for (int i = 0; i < N; i++)
            {
                Id.Add(i);
            }

            // генератор
            ExponentialDistribution exp = new ExponentialDistribution(rate);

            // создание выборки объемом N
            X.AddRange(exp.Generate(N));

            // визуализация - скаттерплот
            scatterplotView1.DataSource = X.ToArray();

            // визуализация - гистограмма
            Histogram histogram = new Histogram();
            histogram.Compute(X.ToArray());
            histogramView1.DataSource = histogram;

            for (int i = 0; i < N; i++)
            {
                radChartView1.Series[0].DataPoints.Add(new ScatterDataPoint(Id[i], X[i]));
            }

            foreach (HistogramBin bin in histogram.Bins)
            {
                string b = $"{bin.Range.Min}-{bin.Range.Max}";
                radChartView2.Series[0].DataPoints.Add(new CategoricalDataPoint(bin.Value, b));
            }
        }
    }
}
