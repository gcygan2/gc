namespace Kalkulator2
{
    partial class Kalkulator
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
            this.liczba1txt = new System.Windows.Forms.TextBox();
            this.txtDzialanie = new System.Windows.Forms.TextBox();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // liczba1txt
            // 
            this.liczba1txt.Location = new System.Drawing.Point(27, 61);
            this.liczba1txt.Name = "liczba1txt";
            this.liczba1txt.Size = new System.Drawing.Size(100, 20);
            this.liczba1txt.TabIndex = 1;
            // 
            // txtDzialanie
            // 
            this.txtDzialanie.Location = new System.Drawing.Point(145, 61);
            this.txtDzialanie.Name = "txtDzialanie";
            this.txtDzialanie.Size = new System.Drawing.Size(100, 20);
            this.txtDzialanie.TabIndex = 2;
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(262, 61);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba2.TabIndex = 3;
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(380, 61);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(100, 20);
            this.txtWynik.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liczba 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Działanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liczba 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wynik";
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 156);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.txtLiczba2);
            this.Controls.Add(this.txtDzialanie);
            this.Controls.Add(this.liczba1txt);
            this.Controls.Add(this.button1);
            this.Name = "Kalkulator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox liczba1txt;
        private System.Windows.Forms.TextBox txtDzialanie;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

