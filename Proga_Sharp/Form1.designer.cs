namespace Proga_Sharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.Num3Label = new System.Windows.Forms.Label();
            this.dvg1 = new System.Windows.Forms.Timer(this.components);
            this.dvg2 = new System.Windows.Forms.Timer(this.components);
            this.dvg3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.rateNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.makeRateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rateNum)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(67, 340);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(312, 81);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Погнали!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num1Label.Location = new System.Drawing.Point(132, 113);
            this.Num1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(166, 181);
            this.Num1Label.TabIndex = 1;
            this.Num1Label.Text = "0";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num2Label.Location = new System.Drawing.Point(317, 113);
            this.Num2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(166, 181);
            this.Num2Label.TabIndex = 2;
            this.Num2Label.Text = "0";
            // 
            // Num3Label
            // 
            this.Num3Label.AutoSize = true;
            this.Num3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num3Label.Location = new System.Drawing.Point(503, 113);
            this.Num3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num3Label.Name = "Num3Label";
            this.Num3Label.Size = new System.Drawing.Size(166, 181);
            this.Num3Label.TabIndex = 3;
            this.Num3Label.Text = "0";
            // 
            // dvg1
            // 
            this.dvg1.Interval = 25;
            this.dvg1.Tick += new System.EventHandler(this.dvg1_Tick);
            // 
            // dvg2
            // 
            this.dvg2.Interval = 25;
            this.dvg2.Tick += new System.EventHandler(this.dvg2_Tick);
            // 
            // dvg3
            // 
            this.dvg3.Interval = 25;
            this.dvg3.Tick += new System.EventHandler(this.dvg3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 1500;
            this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 2500;
            this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 3500;
            this.stop3.Tick += new System.EventHandler(this.stop3_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(413, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Баланс:  $100";
            // 
            // rateNum
            // 
            this.rateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rateNum.Location = new System.Drawing.Point(605, 443);
            this.rateNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rateNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.rateNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rateNum.Name = "rateNum";
            this.rateNum.Size = new System.Drawing.Size(59, 30);
            this.rateNum.TabIndex = 5;
            this.rateNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(413, 446);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вибрати ставку: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(413, 490);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Залишилося спроб: 0";
            // 
            // makeRateButton
            // 
            this.makeRateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeRateButton.Location = new System.Drawing.Point(67, 446);
            this.makeRateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makeRateButton.Name = "makeRateButton";
            this.makeRateButton.Size = new System.Drawing.Size(312, 69);
            this.makeRateButton.TabIndex = 8;
            this.makeRateButton.Text = "Зробити ставку";
            this.makeRateButton.UseVisualStyleBackColor = true;
            this.makeRateButton.Click += new System.EventHandler(this.MakeRateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 569);
            this.Controls.Add(this.makeRateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rateNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Num3Label);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Однорукий Бандит";
            ((System.ComponentModel.ISupportInitialize)(this.rateNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label Num1Label;
        private System.Windows.Forms.Label Num2Label;
        private System.Windows.Forms.Label Num3Label;
        private System.Windows.Forms.Timer dvg1;
        private System.Windows.Forms.Timer dvg2;
        private System.Windows.Forms.Timer dvg3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rateNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button makeRateButton;
    }
}

