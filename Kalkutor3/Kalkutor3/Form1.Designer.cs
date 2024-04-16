namespace Kalkutor3
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLiczba1 = new System.Windows.Forms.TextBox();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.txtLDzialanie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtLiczba1
            // 
            this.txtLiczba1.Location = new System.Drawing.Point(79, 70);
            this.txtLiczba1.Name = "txtLiczba1";
            this.txtLiczba1.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba1.TabIndex = 1;
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(291, 70);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba2.TabIndex = 2;
            // 
            // txtLDzialanie
            // 
            this.txtLDzialanie.Location = new System.Drawing.Point(185, 70);
            this.txtLDzialanie.Name = "txtLDzialanie";
            this.txtLDzialanie.Size = new System.Drawing.Size(100, 20);
            this.txtLDzialanie.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 187);
            this.Controls.Add(this.txtLDzialanie);
            this.Controls.Add(this.txtLiczba2);
            this.Controls.Add(this.txtLiczba1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLiczba1;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.TextBox txtLDzialanie;
    }
}

