
namespace Clustering
{
    partial class MainWindowForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClusteringResultPlotView = new OxyPlot.WindowsForms.PlotView();
            this.buttonClustering = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.PlaneChartView = new OxyPlot.WindowsForms.PlotView();
            this.ClusterizerSetBox = new System.Windows.Forms.ComboBox();
            this.CleanSetNamesBox = new System.Windows.Forms.ComboBox();
            this.NormalizerBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClusteringResultPlotView
            // 
            this.ClusteringResultPlotView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClusteringResultPlotView.Location = new System.Drawing.Point(958, 369);
            this.ClusteringResultPlotView.Name = "ClusteringResultPlotView";
            this.ClusteringResultPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.ClusteringResultPlotView.Size = new System.Drawing.Size(510, 84);
            this.ClusteringResultPlotView.TabIndex = 0;
            this.ClusteringResultPlotView.Text = "plotView1";
            this.ClusteringResultPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.ClusteringResultPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ClusteringResultPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // buttonClustering
            // 
            this.buttonClustering.Location = new System.Drawing.Point(472, 38);
            this.buttonClustering.Name = "buttonClustering";
            this.buttonClustering.Size = new System.Drawing.Size(168, 29);
            this.buttonClustering.TabIndex = 2;
            this.buttonClustering.Text = "Кластеризовать";
            this.buttonClustering.UseVisualStyleBackColor = true;
            this.buttonClustering.Click += new System.EventHandler(this.buttonClustering_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(1049, 40);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(171, 29);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "Построить график";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(985, 225);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(384, 245);
            this.ResultTextBox.TabIndex = 4;
            this.ResultTextBox.Text = "";
            // 
            // PlaneChartView
            // 
            this.PlaneChartView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlaneChartView.Location = new System.Drawing.Point(72, 104);
            this.PlaneChartView.Name = "PlaneChartView";
            this.PlaneChartView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlaneChartView.Size = new System.Drawing.Size(851, 366);
            this.PlaneChartView.TabIndex = 5;
            this.PlaneChartView.Text = "plotView1";
            this.PlaneChartView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlaneChartView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlaneChartView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.PlaneChartView.Paint += new System.Windows.Forms.PaintEventHandler(this.PlaneChartView_Paint);
            // 
            // ClusterizerSetBox
            // 
            this.ClusterizerSetBox.FormattingEnabled = true;
            this.ClusterizerSetBox.Location = new System.Drawing.Point(72, 40);
            this.ClusterizerSetBox.Name = "ClusterizerSetBox";
            this.ClusterizerSetBox.Size = new System.Drawing.Size(185, 28);
            this.ClusterizerSetBox.TabIndex = 6;
            this.ClusterizerSetBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CleanSetNamesBox
            // 
            this.CleanSetNamesBox.FormattingEnabled = true;
            this.CleanSetNamesBox.Location = new System.Drawing.Point(263, 39);
            this.CleanSetNamesBox.Name = "CleanSetNamesBox";
            this.CleanSetNamesBox.Size = new System.Drawing.Size(203, 28);
            this.CleanSetNamesBox.TabIndex = 7;
            this.CleanSetNamesBox.SelectedIndexChanged += new System.EventHandler(this.CleanSetNamesBox_SelectedIndexChanged);
            // 
            // NormalizerBox
            // 
            this.NormalizerBox.FormattingEnabled = true;
            this.NormalizerBox.Location = new System.Drawing.Point(663, 41);
            this.NormalizerBox.Name = "NormalizerBox";
            this.NormalizerBox.Size = new System.Drawing.Size(260, 28);
            this.NormalizerBox.TabIndex = 8;
            this.NormalizerBox.SelectedIndexChanged += new System.EventHandler(this.NormalizerBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Алгоритм кластеризации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Набор данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Предыдущие результаты";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NormalizerBox);
            this.Controls.Add(this.CleanSetNamesBox);
            this.Controls.Add(this.ClusterizerSetBox);
            this.Controls.Add(this.PlaneChartView);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonClustering);
            this.Controls.Add(this.ClusteringResultPlotView);
            this.Name = "MainWindowForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView ClusteringResultPlotView;
        private System.Windows.Forms.Button buttonClustering;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private OxyPlot.WindowsForms.PlotView PlaneChartView;
        private System.Windows.Forms.ComboBox ClusterizerSetBox;
        private System.Windows.Forms.ComboBox CleanSetNamesBox;
        private System.Windows.Forms.ComboBox NormalizerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

