
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MonthNumber = new System.Windows.Forms.TextBox();
            this.IncreaseAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(321, 38);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID";
            // 
            // IDNumber
            // 
            this.IDNumber.Location = new System.Drawing.Point(43, 38);
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.Size = new System.Drawing.Size(47, 20);
            this.IDNumber.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Месяц";
            // 
            // MonthNumber
            // 
            this.MonthNumber.Location = new System.Drawing.Point(111, 38);
            this.MonthNumber.Name = "MonthNumber";
            this.MonthNumber.Size = new System.Drawing.Size(41, 20);
            this.MonthNumber.TabIndex = 20;
            // 
            // IncreaseAmount
            // 
            this.IncreaseAmount.Location = new System.Drawing.Point(175, 38);
            this.IncreaseAmount.Name = "IncreaseAmount";
            this.IncreaseAmount.Size = new System.Drawing.Size(100, 20);
            this.IncreaseAmount.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Прирост суммы вклада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Сумма вклада";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MonthNumber);
            this.Controls.Add(this.IncreaseAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox IDNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox MonthNumber;
        public System.Windows.Forms.TextBox IncreaseAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}