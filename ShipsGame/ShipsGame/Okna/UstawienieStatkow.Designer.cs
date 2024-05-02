namespace ShipsGame.Okna
{
    partial class UstawienieStatkow
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
            this.btnDalej = new System.Windows.Forms.Button();
            this.btnObrot = new System.Windows.Forms.Button();
            this.txtNazwaGracza = new System.Windows.Forms.TextBox();
            this.lblNazwaGracza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDalej
            // 
            this.btnDalej.Location = new System.Drawing.Point(507, 240);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(75, 23);
            this.btnDalej.TabIndex = 4;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = true;
 //           this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);
            // 
            // btnObrot
            // 
            this.btnObrot.Location = new System.Drawing.Point(507, 202);
            this.btnObrot.Name = "btnObrot";
            this.btnObrot.Size = new System.Drawing.Size(75, 23);
            this.btnObrot.TabIndex = 5;
            this.btnObrot.Text = "Obróć";
            this.btnObrot.UseVisualStyleBackColor = true;
  //          this.btnObrot.Click += new System.EventHandler(this.btnObrot_Click);
            // 
            // txtNazwaGracza
            // 
            this.txtNazwaGracza.Location = new System.Drawing.Point(495, 115);
            this.txtNazwaGracza.Name = "txtNazwaGracza";
            this.txtNazwaGracza.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaGracza.TabIndex = 6;
            // 
            // lblNazwaGracza
            // 
            this.lblNazwaGracza.AutoSize = true;
            this.lblNazwaGracza.ForeColor = System.Drawing.Color.Red;
            this.lblNazwaGracza.Location = new System.Drawing.Point(497, 149);
            this.lblNazwaGracza.Name = "lblNazwaGracza";
            this.lblNazwaGracza.Size = new System.Drawing.Size(98, 13);
            this.lblNazwaGracza.TabIndex = 7;
            this.lblNazwaGracza.Text = "Podaj swoją nazwę";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(526, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gracz";
            // 
            // planszaGracza
            // 
            this.planszaGracza.BackColor = System.Drawing.Color.Transparent;
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.InitialImage = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(39, 25);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 0;
            this.planszaGracza.TabStop = false;
  //          this.planszaGracza.Click += new System.EventHandler(this.planszaGracza_Click);
            //this.planszaGracza.Paint += new System.Windows.Forms.PaintEventHandler(this.planszaGracza_Paint);
            //this.planszaGracza.MouseMove += new System.Windows.Forms.MouseEventHandler(this.planszaGracza_MouseMove);
            // 
            // UstawienieStatkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNazwaGracza);
            this.Controls.Add(this.txtNazwaGracza);
            this.Controls.Add(this.btnObrot);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.planszaGracza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UstawienieStatkow";
            this.Text = "UstawienieStatkow";
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.Button btnObrot;
        private System.Windows.Forms.TextBox txtNazwaGracza;
        private System.Windows.Forms.Label lblNazwaGracza;
        private System.Windows.Forms.Label label1;
    }
}