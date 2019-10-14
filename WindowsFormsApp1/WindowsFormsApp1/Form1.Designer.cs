namespace WindowsFormsApp1
{
    partial class počítadlo
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.secti = new System.Windows.Forms.Button();
            this.boxik1 = new System.Windows.Forms.TextBox();
            this.boxik2 = new System.Windows.Forms.TextBox();
            this.vydel = new System.Windows.Forms.Button();
            this.vynasob = new System.Windows.Forms.Button();
            this.odecti = new System.Windows.Forms.Button();
            this.vysledek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // secti
            // 
            this.secti.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.secti.Location = new System.Drawing.Point(303, 74);
            this.secti.Name = "secti";
            this.secti.Size = new System.Drawing.Size(75, 20);
            this.secti.TabIndex = 0;
            this.secti.Text = "secti";
            this.secti.UseVisualStyleBackColor = true;
            this.secti.Click += new System.EventHandler(this.secti_Click);
            // 
            // boxik1
            // 
            this.boxik1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxik1.Location = new System.Drawing.Point(107, 157);
            this.boxik1.Name = "boxik1";
            this.boxik1.Size = new System.Drawing.Size(100, 20);
            this.boxik1.TabIndex = 1;
            this.boxik1.TextChanged += new System.EventHandler(this.boxik1_TextChanged);
            // 
            // boxik2
            // 
            this.boxik2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxik2.Location = new System.Drawing.Point(108, 266);
            this.boxik2.Name = "boxik2";
            this.boxik2.Size = new System.Drawing.Size(100, 20);
            this.boxik2.TabIndex = 2;
            this.boxik2.TextChanged += new System.EventHandler(this.boxik2_TextChanged);
            // 
            // vydel
            // 
            this.vydel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vydel.Location = new System.Drawing.Point(303, 320);
            this.vydel.Name = "vydel";
            this.vydel.Size = new System.Drawing.Size(75, 20);
            this.vydel.TabIndex = 3;
            this.vydel.Text = "vydel";
            this.vydel.UseVisualStyleBackColor = true;
            this.vydel.Click += new System.EventHandler(this.vydel_Click);
            // 
            // vynasob
            // 
            this.vynasob.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vynasob.Location = new System.Drawing.Point(303, 246);
            this.vynasob.Name = "vynasob";
            this.vynasob.Size = new System.Drawing.Size(75, 20);
            this.vynasob.TabIndex = 4;
            this.vynasob.Text = "vynasob";
            this.vynasob.UseVisualStyleBackColor = true;
            this.vynasob.Click += new System.EventHandler(this.vynasob_Click);
            // 
            // odecti
            // 
            this.odecti.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.odecti.Location = new System.Drawing.Point(303, 156);
            this.odecti.Name = "odecti";
            this.odecti.Size = new System.Drawing.Size(75, 20);
            this.odecti.TabIndex = 5;
            this.odecti.Text = "odecti";
            this.odecti.UseVisualStyleBackColor = true;
            this.odecti.Click += new System.EventHandler(this.odecti_Click);
            // 
            // vysledek
            // 
            this.vysledek.ForeColor = System.Drawing.SystemColors.WindowText;
            this.vysledek.Location = new System.Drawing.Point(491, 209);
            this.vysledek.Name = "vysledek";
            this.vysledek.Size = new System.Drawing.Size(100, 20);
            this.vysledek.TabIndex = 6;
            this.vysledek.TextChanged += new System.EventHandler(this.vysledek_TextChanged);
            // 
            // počítadlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 462);
            this.Controls.Add(this.vysledek);
            this.Controls.Add(this.odecti);
            this.Controls.Add(this.vynasob);
            this.Controls.Add(this.vydel);
            this.Controls.Add(this.boxik2);
            this.Controls.Add(this.boxik1);
            this.Controls.Add(this.secti);
            this.Name = "počítadlo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.počítadlo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button secti;
        private System.Windows.Forms.TextBox boxik1;
        private System.Windows.Forms.TextBox boxik2;
        private System.Windows.Forms.Button vydel;
        private System.Windows.Forms.Button vynasob;
        private System.Windows.Forms.Button odecti;
        private System.Windows.Forms.TextBox vysledek;
    }
}

