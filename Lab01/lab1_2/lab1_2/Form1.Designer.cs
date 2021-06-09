
namespace lab1_2
{
    partial class Threads
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.prBar1 = new System.Windows.Forms.ProgressBar();
            this.prBar2 = new System.Windows.Forms.ProgressBar();
            this.prBar3 = new System.Windows.Forms.ProgressBar();
            this.txtThread1 = new System.Windows.Forms.TextBox();
            this.txtThread2 = new System.Windows.Forms.TextBox();
            this.txtThread3 = new System.Windows.Forms.TextBox();
            this.CheckMax = new System.Windows.Forms.CheckBox();
            this.CheckAvg = new System.Windows.Forms.CheckBox();
            this.CheckMin = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(271, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 74);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckMax);
            this.groupBox1.Controls.Add(this.txtThread1);
            this.groupBox1.Controls.Add(this.prBar1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckMin);
            this.groupBox2.Controls.Add(this.txtThread2);
            this.groupBox2.Controls.Add(this.prBar2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread #2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckAvg);
            this.groupBox3.Controls.Add(this.txtThread3);
            this.groupBox3.Controls.Add(this.prBar3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thread #3";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(30, 262);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(196, 74);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // prBar1
            // 
            this.prBar1.ForeColor = System.Drawing.Color.Lime;
            this.prBar1.Location = new System.Drawing.Point(149, 20);
            this.prBar1.Name = "prBar1";
            this.prBar1.Size = new System.Drawing.Size(237, 23);
            this.prBar1.Step = 1;
            this.prBar1.TabIndex = 0;
            // 
            // prBar2
            // 
            this.prBar2.ForeColor = System.Drawing.Color.Lime;
            this.prBar2.Location = new System.Drawing.Point(149, 20);
            this.prBar2.Name = "prBar2";
            this.prBar2.Size = new System.Drawing.Size(237, 23);
            this.prBar2.Step = 1;
            this.prBar2.TabIndex = 1;
            // 
            // prBar3
            // 
            this.prBar3.ForeColor = System.Drawing.Color.Lime;
            this.prBar3.Location = new System.Drawing.Point(149, 20);
            this.prBar3.Name = "prBar3";
            this.prBar3.Size = new System.Drawing.Size(237, 23);
            this.prBar3.Step = 1;
            this.prBar3.TabIndex = 2;
            // 
            // txtThread1
            // 
            this.txtThread1.Location = new System.Drawing.Point(23, 20);
            this.txtThread1.Multiline = true;
            this.txtThread1.Name = "txtThread1";
            this.txtThread1.ReadOnly = true;
            this.txtThread1.Size = new System.Drawing.Size(98, 23);
            this.txtThread1.TabIndex = 1;
            this.txtThread1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThread2
            // 
            this.txtThread2.Location = new System.Drawing.Point(23, 20);
            this.txtThread2.Multiline = true;
            this.txtThread2.Name = "txtThread2";
            this.txtThread2.ReadOnly = true;
            this.txtThread2.Size = new System.Drawing.Size(98, 23);
            this.txtThread2.TabIndex = 2;
            this.txtThread2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThread3
            // 
            this.txtThread3.Location = new System.Drawing.Point(23, 20);
            this.txtThread3.Multiline = true;
            this.txtThread3.Name = "txtThread3";
            this.txtThread3.ReadOnly = true;
            this.txtThread3.Size = new System.Drawing.Size(98, 23);
            this.txtThread3.TabIndex = 3;
            this.txtThread3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckMax
            // 
            this.CheckMax.AutoSize = true;
            this.CheckMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckMax.Location = new System.Drawing.Point(412, 21);
            this.CheckMax.Name = "CheckMax";
            this.CheckMax.Size = new System.Drawing.Size(52, 20);
            this.CheckMax.TabIndex = 7;
            this.CheckMax.Text = "Max";
            this.CheckMax.UseVisualStyleBackColor = true;
            // 
            // CheckAvg
            // 
            this.CheckAvg.AutoSize = true;
            this.CheckAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckAvg.Location = new System.Drawing.Point(412, 21);
            this.CheckAvg.Name = "CheckAvg";
            this.CheckAvg.Size = new System.Drawing.Size(51, 20);
            this.CheckAvg.TabIndex = 8;
            this.CheckAvg.Text = "Avg";
            this.CheckAvg.UseVisualStyleBackColor = true;
            // 
            // CheckMin
            // 
            this.CheckMin.AutoSize = true;
            this.CheckMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckMin.Location = new System.Drawing.Point(412, 21);
            this.CheckMin.Name = "CheckMin";
            this.CheckMin.Size = new System.Drawing.Size(48, 20);
            this.CheckMin.TabIndex = 9;
            this.CheckMin.Text = "Min";
            this.CheckMin.UseVisualStyleBackColor = true;
            // 
            // Threads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 360);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Threads";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ProgressBar prBar1;
        private System.Windows.Forms.ProgressBar prBar2;
        private System.Windows.Forms.ProgressBar prBar3;
        private System.Windows.Forms.CheckBox CheckMax;
        private System.Windows.Forms.TextBox txtThread1;
        private System.Windows.Forms.CheckBox CheckMin;
        private System.Windows.Forms.TextBox txtThread2;
        private System.Windows.Forms.CheckBox CheckAvg;
        private System.Windows.Forms.TextBox txtThread3;
    }
}

