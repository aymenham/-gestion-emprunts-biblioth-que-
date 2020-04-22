namespace Client_Emprunteur
{
    partial class Detaille_Ouvrage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titre = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.Label();
            this.Fiche = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Auteur = new System.Windows.Forms.Label();
            this.reserver = new System.Windows.Forms.Button();
            this.statut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Location = new System.Drawing.Point(219, 26);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(36, 13);
            this.Titre.TabIndex = 1;
            this.Titre.Text = "Titre :";
            // 
            // Theme
            // 
            this.Theme.AutoSize = true;
            this.Theme.Location = new System.Drawing.Point(219, 117);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(46, 13);
            this.Theme.TabIndex = 2;
            this.Theme.Text = "Theme :";
            // 
            // Fiche
            // 
            this.Fiche.AutoSize = true;
            this.Fiche.Location = new System.Drawing.Point(219, 81);
            this.Fiche.Name = "Fiche";
            this.Fiche.Size = new System.Drawing.Size(94, 13);
            this.Fiche.TabIndex = 3;
            this.Fiche.Text = "Fiche descriptive :";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(219, 142);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(38, 13);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type :";
            // 
            // Auteur
            // 
            this.Auteur.AutoSize = true;
            this.Auteur.Location = new System.Drawing.Point(219, 55);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(50, 13);
            this.Auteur.TabIndex = 5;
            this.Auteur.Text = "Auteur  :";
            // 
            // reserver
            // 
            this.reserver.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserver.ForeColor = System.Drawing.Color.Red;
            this.reserver.Location = new System.Drawing.Point(12, 268);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(301, 33);
            this.reserver.TabIndex = 6;
            this.reserver.Text = "Reserver";
            this.reserver.UseVisualStyleBackColor = true;
            this.reserver.Click += new System.EventHandler(this.button1_Click);
            // 
            // statut
            // 
            this.statut.AutoSize = true;
            this.statut.Location = new System.Drawing.Point(219, 165);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(36, 13);
            this.statut.TabIndex = 7;
            this.statut.Text = "statut";
            // 
            // Detaille_Ouvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 313);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.reserver);
            this.Controls.Add(this.Auteur);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Fiche);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Detaille_Ouvrage";
            this.Text = "Detaille_Ouvrage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Theme;
        private System.Windows.Forms.Label Fiche;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Auteur;
        private System.Windows.Forms.Button reserver;
        private System.Windows.Forms.Label statut;
    }
}