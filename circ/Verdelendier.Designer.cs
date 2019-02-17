namespace circ
{
    partial class Verdelendier
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
            this.Btninvoer = new System.Windows.Forms.Button();
            this.lbldier = new System.Windows.Forms.Label();
            this.lblSoort = new System.Windows.Forms.Label();
            this.lblGrootte = new System.Windows.Forms.Label();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.GbGegevens = new System.Windows.Forms.GroupBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.cbGrootte = new System.Windows.Forms.ComboBox();
            this.lbDier = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnIndelen = new System.Windows.Forms.Button();
            this.GbGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btninvoer
            // 
            this.Btninvoer.Location = new System.Drawing.Point(113, 117);
            this.Btninvoer.Name = "Btninvoer";
            this.Btninvoer.Size = new System.Drawing.Size(117, 23);
            this.Btninvoer.TabIndex = 0;
            this.Btninvoer.Text = "Dier invoeren";
            this.Btninvoer.UseVisualStyleBackColor = true;
            this.Btninvoer.Click += new System.EventHandler(this.Btninvoer_Click);
            // 
            // lbldier
            // 
            this.lbldier.AutoSize = true;
            this.lbldier.Location = new System.Drawing.Point(18, 40);
            this.lbldier.Name = "lbldier";
            this.lbldier.Size = new System.Drawing.Size(29, 13);
            this.lbldier.TabIndex = 1;
            this.lbldier.Text = "Dier:";
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(18, 66);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(32, 13);
            this.lblSoort.TabIndex = 2;
            this.lblSoort.Text = "Soort";
            // 
            // lblGrootte
            // 
            this.lblGrootte.AutoSize = true;
            this.lblGrootte.Location = new System.Drawing.Point(18, 93);
            this.lblGrootte.Name = "lblGrootte";
            this.lblGrootte.Size = new System.Drawing.Size(42, 13);
            this.lblGrootte.TabIndex = 3;
            this.lblGrootte.Text = "Grootte";
            // 
            // cbSoort
            // 
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Items.AddRange(new object[] {
            "Vleeseter",
            "Planteter"});
            this.cbSoort.Location = new System.Drawing.Point(113, 63);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(121, 21);
            this.cbSoort.TabIndex = 4;
            // 
            // GbGegevens
            // 
            this.GbGegevens.Controls.Add(this.tbNaam);
            this.GbGegevens.Controls.Add(this.cbGrootte);
            this.GbGegevens.Controls.Add(this.lbldier);
            this.GbGegevens.Controls.Add(this.cbSoort);
            this.GbGegevens.Controls.Add(this.Btninvoer);
            this.GbGegevens.Controls.Add(this.lblGrootte);
            this.GbGegevens.Controls.Add(this.lblSoort);
            this.GbGegevens.Location = new System.Drawing.Point(25, 27);
            this.GbGegevens.Name = "GbGegevens";
            this.GbGegevens.Size = new System.Drawing.Size(246, 148);
            this.GbGegevens.TabIndex = 5;
            this.GbGegevens.TabStop = false;
            this.GbGegevens.Text = "Gegevens Dier";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(113, 37);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(121, 20);
            this.tbNaam.TabIndex = 6;
            // 
            // cbGrootte
            // 
            this.cbGrootte.FormattingEnabled = true;
            this.cbGrootte.Items.AddRange(new object[] {
            "Klein",
            "Middelmatig",
            "Groot"});
            this.cbGrootte.Location = new System.Drawing.Point(113, 90);
            this.cbGrootte.Name = "cbGrootte";
            this.cbGrootte.Size = new System.Drawing.Size(121, 21);
            this.cbGrootte.TabIndex = 5;
            // 
            // lbDier
            // 
            this.lbDier.FormattingEnabled = true;
            this.lbDier.Location = new System.Drawing.Point(375, 27);
            this.lbDier.Name = "lbDier";
            this.lbDier.Size = new System.Drawing.Size(120, 147);
            this.lbDier.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(35, 286);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(460, 134);
            this.lbResult.TabIndex = 7;
            // 
            // btnIndelen
            // 
            this.btnIndelen.Location = new System.Drawing.Point(35, 251);
            this.btnIndelen.Name = "btnIndelen";
            this.btnIndelen.Size = new System.Drawing.Size(460, 23);
            this.btnIndelen.TabIndex = 8;
            this.btnIndelen.Text = "Indelen";
            this.btnIndelen.UseVisualStyleBackColor = true;
            this.btnIndelen.Click += new System.EventHandler(this.btnIndelen_Click);
            // 
            // Verdelendier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.btnIndelen);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbDier);
            this.Controls.Add(this.GbGegevens);
            this.Name = "Verdelendier";
            this.Text = "Indelen";
            this.GbGegevens.ResumeLayout(false);
            this.GbGegevens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btninvoer;
        private System.Windows.Forms.Label lbldier;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.Label lblGrootte;
        private System.Windows.Forms.ComboBox cbSoort;
        private System.Windows.Forms.GroupBox GbGegevens;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.ComboBox cbGrootte;
        private System.Windows.Forms.ListBox lbDier;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnIndelen;
    }
}

