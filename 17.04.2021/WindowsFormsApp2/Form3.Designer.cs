
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MonthNumber = new System.Windows.Forms.TextBox();
            this.IncreaseAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(315, 46);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID";
            // 
            // IDNumber
            // 
            this.IDNumber.Location = new System.Drawing.Point(37, 46);
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.Size = new System.Drawing.Size(47, 20);
            this.IDNumber.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "День";
            // 
            // MonthNumber
            // 
            this.MonthNumber.Location = new System.Drawing.Point(105, 46);
            this.MonthNumber.Name = "MonthNumber";
            this.MonthNumber.Size = new System.Drawing.Size(41, 20);
            this.MonthNumber.TabIndex = 29;
            // 
            // IncreaseAmount
            // 
            this.IncreaseAmount.Location = new System.Drawing.Point(169, 46);
            this.IncreaseAmount.Name = "IncreaseAmount";
            this.IncreaseAmount.Size = new System.Drawing.Size(100, 20);
            this.IncreaseAmount.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Растояние за день";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Общее растояние";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MonthNumber);
            this.Controls.Add(this.IncreaseAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox IDNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox MonthNumber;
        public System.Windows.Forms.TextBox IncreaseAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}