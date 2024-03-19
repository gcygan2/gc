namespace WindowsFormsApp40
{
    partial class Form1
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
            this.txtKosztFilamentu = new System.Windows.Forms.TextBox();
            this.txtZuzytyFilament = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKosztFilamentu
            // 
            this.txtKosztFilamentu.Location = new System.Drawing.Point(93, 24);
            this.txtKosztFilamentu.Name = "txtKosztFilamentu";
            this.txtKosztFilamentu.Size = new System.Drawing.Size(100, 20);
            this.txtKosztFilamentu.TabIndex = 0;
            // 
            // txtZuzytyFilament
            // 
            this.txtZuzytyFilament.Location = new System.Drawing.Point(93, 62);
            this.txtZuzytyFilament.Name = "txtZuzytyFilament";
            this.txtZuzytyFilament.Size = new System.Drawing.Size(100, 20);
            this.txtZuzytyFilament.TabIndex = 1;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(281, 117);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(152, 13);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "Cena materiałów wynosi 12,45";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 175);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.txtZuzytyFilament);
            this.Controls.Add(this.txtKosztFilamentu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKosztFilamentu;
        private System.Windows.Forms.TextBox txtZuzytyFilament;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Button button1;
    }
}

