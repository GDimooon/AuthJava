namespace laba_7
{
    partial class task2Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nextbutton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prevbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.adddaysbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.subtractdaysbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущая дата:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTextBox.Location = new System.Drawing.Point(342, 24);
            this.DateTextBox.Multiline = true;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DateTextBox.Size = new System.Drawing.Size(200, 32);
            this.DateTextBox.TabIndex = 1;
            this.DateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysTextBox.Location = new System.Drawing.Point(342, 70);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(123, 27);
            this.DaysTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите количество дней:";
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextbutton.Location = new System.Drawing.Point(351, 113);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(135, 39);
            this.nextbutton.TabIndex = 5;
            this.nextbutton.Text = "Показать";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultTextBox.Location = new System.Drawing.Point(558, 24);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(258, 80);
            this.ResultTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Перемещения на следующий день";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Перемещения на предыдущий день";
            // 
            // prevbutton
            // 
            this.prevbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevbutton.Location = new System.Drawing.Point(351, 179);
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.Size = new System.Drawing.Size(135, 39);
            this.prevbutton.TabIndex = 9;
            this.prevbutton.Text = "Показать";
            this.prevbutton.UseVisualStyleBackColor = true;
            this.prevbutton.Click += new System.EventHandler(this.prevbutton_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 53);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прибавления указанного количества дней к текущей дате";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adddaysbutton
            // 
            this.adddaysbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adddaysbutton.Location = new System.Drawing.Point(351, 251);
            this.adddaysbutton.Name = "adddaysbutton";
            this.adddaysbutton.Size = new System.Drawing.Size(135, 37);
            this.adddaysbutton.TabIndex = 11;
            this.adddaysbutton.Text = "Показать";
            this.adddaysbutton.UseVisualStyleBackColor = true;
            this.adddaysbutton.Click += new System.EventHandler(this.adddaysbutton_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 54);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вычитания указанного количества дней из текущей даты";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtractdaysbutton
            // 
            this.subtractdaysbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractdaysbutton.Location = new System.Drawing.Point(351, 316);
            this.subtractdaysbutton.Name = "subtractdaysbutton";
            this.subtractdaysbutton.Size = new System.Drawing.Size(135, 33);
            this.subtractdaysbutton.TabIndex = 13;
            this.subtractdaysbutton.Text = "Показать";
            this.subtractdaysbutton.UseVisualStyleBackColor = true;
            this.subtractdaysbutton.Click += new System.EventHandler(this.subtractdaysbutton_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(712, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // task2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subtractdaysbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adddaysbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prevbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label1);
            this.Name = "task2Form";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prevbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adddaysbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button subtractdaysbutton;
        private System.Windows.Forms.Button button1;
    }
}