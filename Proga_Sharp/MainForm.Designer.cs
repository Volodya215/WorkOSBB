namespace Proga_Sharp
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.Game = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.dataUserButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.mainPanel.Controls.Add(this.Game);
            this.mainPanel.Controls.Add(this.payButton);
            this.mainPanel.Controls.Add(this.changeButton);
            this.mainPanel.Controls.Add(this.enterButton);
            this.mainPanel.Controls.Add(this.dataUserButton);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 550);
            this.mainPanel.TabIndex = 1;
            // 
            // Game
            // 
            this.Game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.Game.Location = new System.Drawing.Point(0, 515);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(75, 23);
            this.Game.TabIndex = 5;
            this.Game.Text = "+";
            this.Game.UseVisualStyleBackColor = false;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // payButton
            // 
            this.payButton.AutoSize = true;
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.payButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.payButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.payButton.Location = new System.Drawing.Point(164, 448);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(283, 44);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "Оплатити послуги";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.AutoSize = true;
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.changeButton.Location = new System.Drawing.Point(164, 357);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(283, 44);
            this.changeButton.TabIndex = 3;
            this.changeButton.Text = "Змінити користувача";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.AutoSize = true;
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.enterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.enterButton.Location = new System.Drawing.Point(182, 257);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(245, 44);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Ввести показники";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // dataUserButton
            // 
            this.dataUserButton.AutoSize = true;
            this.dataUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.dataUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.dataUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.dataUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataUserButton.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.dataUserButton.Location = new System.Drawing.Point(182, 164);
            this.dataUserButton.Name = "dataUserButton";
            this.dataUserButton.Size = new System.Drawing.Size(240, 44);
            this.dataUserButton.TabIndex = 1;
            this.dataUserButton.Text = "Дані користувача";
            this.dataUserButton.UseVisualStyleBackColor = false;
            this.dataUserButton.Click += new System.EventHandler(this.DataUserButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(19)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 122);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(570, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "Особистий кабінет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button dataUserButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button Game;
    }
}