
namespace Clustering
{
    partial class UIManager
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
            this.buttonClustering = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.PlaneChartView = new OxyPlot.WindowsForms.PlotView();
            this.ClusterizerSetBox = new System.Windows.Forms.ComboBox();
            this.CleanSetNamesBox = new System.Windows.Forms.ComboBox();
            this.ChartMementoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Export_Button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClustering
            // 
            this.buttonClustering.Location = new System.Drawing.Point(407, 32);
            this.buttonClustering.Name = "buttonClustering";
            this.buttonClustering.Size = new System.Drawing.Size(135, 29);
            this.buttonClustering.TabIndex = 2;
            this.buttonClustering.Text = "Кластеризовать";
            this.buttonClustering.UseVisualStyleBackColor = true;
            this.buttonClustering.Click += new System.EventHandler(this.Сlusterize_Button_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.AutoWordSelection = true;
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultTextBox.Location = new System.Drawing.Point(6, 23);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(558, 280);
            this.ResultTextBox.TabIndex = 4;
            this.ResultTextBox.Text = "";
            // 
            // PlaneChartView
            // 
            this.PlaneChartView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlaneChartView.Location = new System.Drawing.Point(20, 112);
            this.PlaneChartView.Name = "PlaneChartView";
            this.PlaneChartView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlaneChartView.Size = new System.Drawing.Size(545, 303);
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
            this.ClusterizerSetBox.Location = new System.Drawing.Point(7, 33);
            this.ClusterizerSetBox.Name = "ClusterizerSetBox";
            this.ClusterizerSetBox.Size = new System.Drawing.Size(185, 28);
            this.ClusterizerSetBox.TabIndex = 6;
            this.ClusterizerSetBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CleanSetNamesBox
            // 
            this.CleanSetNamesBox.FormattingEnabled = true;
            this.CleanSetNamesBox.Location = new System.Drawing.Point(198, 33);
            this.CleanSetNamesBox.Name = "CleanSetNamesBox";
            this.CleanSetNamesBox.Size = new System.Drawing.Size(203, 28);
            this.CleanSetNamesBox.TabIndex = 7;
            this.CleanSetNamesBox.SelectedIndexChanged += new System.EventHandler(this.CleanSetNamesBox_SelectedIndexChanged);
            // 
            // ChartMementoBox
            // 
            this.ChartMementoBox.FormattingEnabled = true;
            this.ChartMementoBox.Location = new System.Drawing.Point(20, 55);
            this.ChartMementoBox.Name = "ChartMementoBox";
            this.ChartMementoBox.Size = new System.Drawing.Size(545, 28);
            this.ChartMementoBox.TabIndex = 8;
            this.ChartMementoBox.SelectedIndexChanged += new System.EventHandler(this.ChartMementoBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Алгоритм кластеризации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Набор данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Предыдущие результаты";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CleanSetNamesBox);
            this.panel1.Controls.Add(this.buttonClustering);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ClusterizerSetBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 80);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 112);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Export_Button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ChartMementoBox);
            this.groupBox2.Controls.Add(this.PlaneChartView);
            this.groupBox2.Location = new System.Drawing.Point(588, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 451);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Представление результата";
            // 
            // Export_Button
            // 
            this.Export_Button.Location = new System.Drawing.Point(359, 422);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(210, 29);
            this.Export_Button.TabIndex = 17;
            this.Export_Button.Text = "Экспортировать результат";
            this.Export_Button.UseVisualStyleBackColor = true;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 339);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Журналирование";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UIManager";
            this.Text = "BachClusterizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClustering;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private OxyPlot.WindowsForms.PlotView PlaneChartView;
        private System.Windows.Forms.ComboBox ClusterizerSetBox;
        private System.Windows.Forms.ComboBox CleanSetNamesBox;
        private System.Windows.Forms.ComboBox ChartMementoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

