
namespace WindowsFormsApp2
{
    partial class Form4
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
            this.label19 = new System.Windows.Forms.Label();
            this.TotalYield = new System.Windows.Forms.TextBox();
            this.Yield = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.Square = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(328, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Общий уражай в течении лет";
            // 
            // TotalYield
            // 
            this.TotalYield.Location = new System.Drawing.Point(331, 47);
            this.TotalYield.Name = "TotalYield";
            this.TotalYield.Size = new System.Drawing.Size(151, 20);
            this.TotalYield.TabIndex = 51;
            // 
            // Yield
            // 
            this.Yield.Location = new System.Drawing.Point(116, 48);
            this.Yield.Name = "Yield";
            this.Yield.Size = new System.Drawing.Size(100, 20);
            this.Yield.TabIndex = 50;
       
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Год";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(52, 47);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(58, 20);
            this.Year.TabIndex = 48;
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(222, 48);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(100, 20);
            this.Square.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(226, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Площадь участка";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Уражайность";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 169);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TotalYield);
            this.Controls.Add(this.Yield);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox TotalYield;
        public System.Windows.Forms.TextBox Yield;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox Year;
        public System.Windows.Forms.TextBox Square;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}