namespace laba_6
{
    partial class graphsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.graphDraw = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphWind = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Сапожникова Александра ИВТ-22 Вариант 13";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(568, 563);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 35);
            this.button5.TabIndex = 21;
            this.button5.Text = "Закрыть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 30);
            this.button4.TabIndex = 20;
            this.button4.Text = "Нарисовать график";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart2
            // 
            chartArea9.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea9);
            this.chart2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend9.Name = "Legend1";
            this.chart2.Legends.Add(legend9);
            this.chart2.Location = new System.Drawing.Point(412, 324);
            this.chart2.Name = "chart2";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart2.Series.Add(series9);
            this.chart2.Size = new System.Drawing.Size(298, 173);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "chart1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 26);
            this.button3.TabIndex = 18;
            this.button3.Text = "Нарисовать фигуры";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Нарисовать график";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Нарисовать график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // graphDraw
            // 
            this.graphDraw.BackColor = System.Drawing.Color.White;
            this.graphDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphDraw.Location = new System.Drawing.Point(412, 60);
            this.graphDraw.Name = "graphDraw";
            this.graphDraw.Size = new System.Drawing.Size(298, 217);
            this.graphDraw.TabIndex = 15;
            this.graphDraw.TabStop = false;
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(32, 60);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(309, 217);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // graphWind
            // 
            this.graphWind.BackColor = System.Drawing.Color.White;
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(41, 324);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(282, 173);
            this.graphWind.TabIndex = 14;
            this.graphWind.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите значение параметра a:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойстваToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.свойстваToolStripMenuItem.Text = "Свойства";
           // this.свойстваToolStripMenuItem.Click += new System.EventHandler(this.свойстваToolStripMenuItem_Click_1);
            // 
            // graphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graphDraw);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.graphWind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "graphsForm";
            this.Text = "graphsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox graphDraw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox graphWind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
    }
}