
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
            this.buttonClustering.Location = new System.Drawing.Point(472, 39);
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
            this.PlaneChartView.Location = new System.Drawing.Point(138, 104);
            this.PlaneChartView.Name = "PlaneChartView";
            this.PlaneChartView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlaneChartView.Size = new System.Drawing.Size(502, 366);
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
            this.ClusterizerSetBox.Location = new System.Drawing.Point(115, 40);
            this.ClusterizerSetBox.Name = "ClusterizerSetBox";
            this.ClusterizerSetBox.Size = new System.Drawing.Size(151, 28);
            this.ClusterizerSetBox.TabIndex = 6;
            this.ClusterizerSetBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CleanSetNamesBox
            // 
            this.CleanSetNamesBox.FormattingEnabled = true;
            this.CleanSetNamesBox.Location = new System.Drawing.Point(291, 39);
            this.CleanSetNamesBox.Name = "CleanSetNamesBox";
            this.CleanSetNamesBox.Size = new System.Drawing.Size(151, 28);
            this.CleanSetNamesBox.TabIndex = 7;
            this.CleanSetNamesBox.SelectedIndexChanged += new System.EventHandler(this.CleanSetNamesBox_SelectedIndexChanged);
            // 
            // NormalizerBox
            // 
            this.NormalizerBox.FormattingEnabled = true;
            this.NormalizerBox.Location = new System.Drawing.Point(849, 104);
            this.NormalizerBox.Name = "NormalizerBox";
            this.NormalizerBox.Size = new System.Drawing.Size(151, 28);
            this.NormalizerBox.TabIndex = 8;
            this.NormalizerBox.SelectedIndexChanged += new System.EventHandler(this.NormalizerBox_SelectedIndexChanged);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 506);
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
    }
}

