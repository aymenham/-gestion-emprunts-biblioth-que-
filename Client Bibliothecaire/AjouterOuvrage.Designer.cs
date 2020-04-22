namespace Client_Bibliothecaire
{
    partial class AjouterOuvrage
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
            this.code_bare = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tittre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.auteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fiche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reponse = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imagepath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // code_bare
            // 
            this.code_bare.Location = new System.Drawing.Point(21, 122);
            this.code_bare.Name = "code_bare";
            this.code_bare.Size = new System.Drawing.Size(302, 20);
            this.code_bare.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "code barre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "titre";
            // 
            // tittre
            // 
            this.tittre.Location = new System.Drawing.Point(21, 163);
            this.tittre.Name = "tittre";
            this.tittre.Size = new System.Drawing.Size(302, 20);
            this.tittre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "auteur";
            // 
            // auteur
            // 
            this.auteur.Location = new System.Drawing.Point(21, 202);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(302, 20);
            this.auteur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "fiche descriptive";
            // 
            // fiche
            // 
            this.fiche.Location = new System.Drawing.Point(21, 242);
            this.fiche.Multiline = true;
            this.fiche.Name = "fiche";
            this.fiche.Size = new System.Drawing.Size(302, 76);
            this.fiche.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "theme";
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(21, 337);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(302, 20);
            this.theme.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Client_Bibliothecaire.Properties.Resources.add_book;
            this.pictureBox1.Location = new System.Drawing.Point(114, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 113);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reponse
            // 
            this.reponse.AutoSize = true;
            this.reponse.Location = new System.Drawing.Point(142, 479);
            this.reponse.Name = "reponse";
            this.reponse.Size = new System.Drawing.Size(46, 13);
            this.reponse.TabIndex = 17;
            this.reponse.Text = "reponse";
            this.reponse.Visible = false;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "livre",
            "memoire",
            "these"});
            this.type.Location = new System.Drawing.Point(21, 377);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(302, 21);
            this.type.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Importer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imagepath
            // 
            this.imagepath.AutoSize = true;
            this.imagepath.Location = new System.Drawing.Point(18, 401);
            this.imagepath.Name = "imagepath";
            this.imagepath.Size = new System.Drawing.Size(99, 13);
            this.imagepath.TabIndex = 20;
            this.imagepath.Text = "importer une image";
            // 
            // AjouterOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 559);
            this.Controls.Add(this.imagepath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.reponse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tittre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code_bare);
            this.Name = "AjouterOuvrage";
            this.Text = "AjouterOuvrage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code_bare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tittre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox auteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fiche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reponse;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label imagepath;
    }
}