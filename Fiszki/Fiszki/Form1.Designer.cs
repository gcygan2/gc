namespace Fiszki
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
            this.txtPoPolsku = new System.Windows.Forms.TextBox();
            this.txtPoAngielsku = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPoPolsku
            // 
            this.txtPoPolsku.Location = new System.Drawing.Point(350, 44);
            this.txtPoPolsku.Name = "txtPoPolsku";
            this.txtPoPolsku.Size = new System.Drawing.Size(100, 20);
            this.txtPoPolsku.TabIndex = 0;
            // 
            // txtPoAngielsku
            // 
            this.txtPoAngielsku.Location = new System.Drawing.Point(350, 86);
            this.txtPoAngielsku.Name = "txtPoAngielsku";
            this.txtPoAngielsku.Size = new System.Drawing.Size(100, 20);
            this.txtPoAngielsku.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sprawdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPoAngielsku);
            this.Controls.Add(this.txtPoPolsku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoPolsku;
        private System.Windows.Forms.TextBox txtPoAngielsku;
        private System.Windows.Forms.Button button1;
    }
}

