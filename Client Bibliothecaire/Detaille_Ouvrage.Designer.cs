namespace Client_Bibliothecaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.Titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fiche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Auteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "code barre :";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(256, 45);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(169, 20);
            this.Code.TabIndex = 2;
            // 
            // Titre
            // 
            this.Titre.Location = new System.Drawing.Point(256, 64);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(169, 20);
            this.Titre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titre :";
            // 
            // Fiche
            // 
            this.Fiche.Location = new System.Drawing.Point(256, 125);
            this.Fiche.Multiline = true;
            this.Fiche.Name = "Fiche";
            this.Fiche.Size = new System.Drawing.Size(169, 73);
            this.Fiche.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiche descriptife";
            // 
            // Auteur
            // 
            this.Auteur.Location = new System.Drawing.Point(256, 90);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(169, 20);
            this.Auteur.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Auteur";
            // 
            // Theme
            // 
            this.Theme.Location = new System.Drawing.Point(256, 219);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(169, 20);
            this.Theme.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Theme";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(256, 245);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(169, 20);
            this.Type.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Detaille_Ouvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Auteur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Detaille_Ouvrage";
            this.Text = "Detaille_Ouvrage";
            this.Load += new System.EventHandler(this.Detaille_Ouvrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox Titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fiche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Auteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Theme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}