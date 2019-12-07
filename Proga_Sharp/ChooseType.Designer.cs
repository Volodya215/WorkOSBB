namespace Proga_Sharp
{
    partial class ChooseType
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
            this.inhbenefit = new System.Windows.Forms.Button();
            this.company = new System.Windows.Forms.Button();
            this.inhabitant = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.mainPanel.Controls.Add(this.inhbenefit);
            this.mainPanel.Controls.Add(this.company);
            this.mainPanel.Controls.Add(this.inhabitant);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 2;
            // 
            // inhbenefit
            // 
            this.inhbenefit.AutoSize = true;
            this.inhbenefit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.inhbenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inhbenefit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.inhbenefit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.inhbenefit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inhbenefit.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.inhbenefit.Location = new System.Drawing.Point(317, 352);
            this.inhbenefit.Name = "inhbenefit";
            this.inhbenefit.Size = new System.Drawing.Size(150, 44);
            this.inhbenefit.TabIndex = 3;
            this.inhbenefit.Text = "Пільговик";
            this.inhbenefit.UseVisualStyleBackColor = false;
            this.inhbenefit.Click += new System.EventHandler(this.Inhbenefit_Click);
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.company.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.company.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.company.Location = new System.Drawing.Point(224, 268);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(324, 44);
            this.company.TabIndex = 2;
            this.company.Text = "Приватний підприємець";
            this.company.UseVisualStyleBackColor = false;
            this.company.Click += new System.EventHandler(this.Company_Click);
            // 
            // inhabitant
            // 
            this.inhabitant.AutoSize = true;
            this.inhabitant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.inhabitant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inhabitant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.inhabitant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.inhabitant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inhabitant.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.inhabitant.Location = new System.Drawing.Point(252, 181);
            this.inhabitant.Name = "inhabitant";
            this.inhabitant.Size = new System.Drawing.Size(276, 44);
            this.inhabitant.TabIndex = 1;
            this.inhabitant.Text = "Мешканець будинку";
            this.inhabitant.UseVisualStyleBackColor = false;
            this.inhabitant.Click += new System.EventHandler(this.Inhabitant_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(19)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 122);
            this.panel2.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 36);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "←";
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(770, 0);
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
            this.label1.Size = new System.Drawing.Size(800, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть тип користувача";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseType";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inhabitant;
        private System.Windows.Forms.Button inhbenefit;
        private System.Windows.Forms.Button company;
        private System.Windows.Forms.Label backButton;
    }
}