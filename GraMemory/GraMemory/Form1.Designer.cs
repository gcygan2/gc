namespace GraMemory
{
    partial class MemoryForm
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
            this.components = new System.ComponentModel.Container();
            this.lblCzas = new System.Windows.Forms.Label();
            this.lblCzasWartosc = new System.Windows.Forms.Label();
            this.lblPunktyWartosc = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.panelKart = new System.Windows.Forms.Panel();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzas.Location = new System.Drawing.Point(12, 9);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(56, 24);
            this.lblCzas.TabIndex = 0;
            this.lblCzas.Text = "Czas:";
            // 
            // lblCzasWartosc
            // 
            this.lblCzasWartosc.AutoSize = true;
            this.lblCzasWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasWartosc.Location = new System.Drawing.Point(87, 9);
            this.lblCzasWartosc.Name = "lblCzasWartosc";
            this.lblCzasWartosc.Size = new System.Drawing.Size(30, 24);
            this.lblCzasWartosc.TabIndex = 1;
            this.lblCzasWartosc.Text = "60";
            // 
            // lblPunktyWartosc
            // 
            this.lblPunktyWartosc.AutoSize = true;
            this.lblPunktyWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunktyWartosc.Location = new System.Drawing.Point(242, 9);
            this.lblPunktyWartosc.Name = "lblPunktyWartosc";
            this.lblPunktyWartosc.Size = new System.Drawing.Size(20, 24);
            this.lblPunktyWartosc.TabIndex = 3;
            this.lblPunktyWartosc.Text = "0";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty.Location = new System.Drawing.Point(169, 9);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(66, 24);
            this.lblPunkty.TabIndex = 2;
            this.lblPunkty.Text = "Punkty";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartInfo.Location = new System.Drawing.Point(323, 9);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(165, 24);
            this.lblStartInfo.TabIndex = 4;
            this.lblStartInfo.Text = "Początek gry za 5s";
            // 
            // panelKart
            // 
            this.panelKart.Location = new System.Drawing.Point(16, 49);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(591, 100);
            this.panelKart.TabIndex = 5;
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 177);
            this.Controls.Add(this.panelKart);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.lblPunktyWartosc);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.lblCzasWartosc);
            this.Controls.Add(this.lblCzas);
            this.Name = "MemoryForm";
            this.Text = "Gra memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.Label lblCzasWartosc;
        private System.Windows.Forms.Label lblPunktyWartosc;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Panel panelKart;
        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
    }
}

