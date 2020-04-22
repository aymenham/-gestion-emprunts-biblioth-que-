namespace Client_Bibliothecaire
{
    partial class AjouterMembreEnseignant
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
            this.numero_de_carte_ = new System.Windows.Forms.TextBox();
            this.numero_de_carte_enseignant = new System.Windows.Forms.Label();
            this.nom_utilisateur_enseignant = new System.Windows.Forms.Label();
            this.nom_utilisateur_ = new System.Windows.Forms.TextBox();
            this.mot_de_passe_enseignant = new System.Windows.Forms.Label();
            this.mot_de_passe_ = new System.Windows.Forms.TextBox();
            this.nom_enseignant = new System.Windows.Forms.Label();
            this.nom_ = new System.Windows.Forms.TextBox();
            this.prenom_enseignant = new System.Windows.Forms.Label();
            this.prenom_ = new System.Windows.Forms.TextBox();
            this.email_enseignant = new System.Windows.Forms.Label();
            this.email_ = new System.Windows.Forms.TextBox();
            this.grade_enseignant = new System.Windows.Forms.Label();
            this.grade_ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reponse_ajout_enseignant = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_de_carte_
            // 
            this.numero_de_carte_.Location = new System.Drawing.Point(44, 136);
            this.numero_de_carte_.Name = "numero_de_carte_";
            this.numero_de_carte_.Size = new System.Drawing.Size(270, 20);
            this.numero_de_carte_.TabIndex = 0;
            // 
            // numero_de_carte_enseignant
            // 
            this.numero_de_carte_enseignant.AutoSize = true;
            this.numero_de_carte_enseignant.Location = new System.Drawing.Point(41, 120);
            this.numero_de_carte_enseignant.Name = "numero_de_carte_enseignant";
            this.numero_de_carte_enseignant.Size = new System.Drawing.Size(87, 13);
            this.numero_de_carte_enseignant.TabIndex = 1;
            this.numero_de_carte_enseignant.Text = "Numero de carte";
            // 
            // nom_utilisateur_enseignant
            // 
            this.nom_utilisateur_enseignant.AutoSize = true;
            this.nom_utilisateur_enseignant.Location = new System.Drawing.Point(41, 162);
            this.nom_utilisateur_enseignant.Name = "nom_utilisateur_enseignant";
            this.nom_utilisateur_enseignant.Size = new System.Drawing.Size(86, 13);
            this.nom_utilisateur_enseignant.TabIndex = 3;
            this.nom_utilisateur_enseignant.Text = "Nom d\'utilisateur";
            // 
            // nom_utilisateur_
            // 
            this.nom_utilisateur_.Location = new System.Drawing.Point(44, 178);
            this.nom_utilisateur_.Name = "nom_utilisateur_";
            this.nom_utilisateur_.Size = new System.Drawing.Size(270, 20);
            this.nom_utilisateur_.TabIndex = 2;
            // 
            // mot_de_passe_enseignant
            // 
            this.mot_de_passe_enseignant.AutoSize = true;
            this.mot_de_passe_enseignant.Location = new System.Drawing.Point(41, 201);
            this.mot_de_passe_enseignant.Name = "mot_de_passe_enseignant";
            this.mot_de_passe_enseignant.Size = new System.Drawing.Size(71, 13);
            this.mot_de_passe_enseignant.TabIndex = 5;
            this.mot_de_passe_enseignant.Text = "Mot de passe";
            // 
            // mot_de_passe_
            // 
            this.mot_de_passe_.Location = new System.Drawing.Point(44, 217);
            this.mot_de_passe_.Name = "mot_de_passe_";
            this.mot_de_passe_.Size = new System.Drawing.Size(270, 20);
            this.mot_de_passe_.TabIndex = 4;
            // 
            // nom_enseignant
            // 
            this.nom_enseignant.AutoSize = true;
            this.nom_enseignant.Location = new System.Drawing.Point(41, 241);
            this.nom_enseignant.Name = "nom_enseignant";
            this.nom_enseignant.Size = new System.Drawing.Size(28, 13);
            this.nom_enseignant.TabIndex = 7;
            this.nom_enseignant.Text = "Nom";
            // 
            // nom_
            // 
            this.nom_.Location = new System.Drawing.Point(44, 257);
            this.nom_.Name = "nom_";
            this.nom_.Size = new System.Drawing.Size(270, 20);
            this.nom_.TabIndex = 6;
            // 
            // prenom_enseignant
            // 
            this.prenom_enseignant.AutoSize = true;
            this.prenom_enseignant.Location = new System.Drawing.Point(41, 282);
            this.prenom_enseignant.Name = "prenom_enseignant";
            this.prenom_enseignant.Size = new System.Drawing.Size(43, 13);
            this.prenom_enseignant.TabIndex = 9;
            this.prenom_enseignant.Text = "Prénom";
            // 
            // prenom_
            // 
            this.prenom_.Location = new System.Drawing.Point(44, 298);
            this.prenom_.Name = "prenom_";
            this.prenom_.Size = new System.Drawing.Size(270, 20);
            this.prenom_.TabIndex = 8;
            this.prenom_.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // email_enseignant
            // 
            this.email_enseignant.AutoSize = true;
            this.email_enseignant.Location = new System.Drawing.Point(41, 323);
            this.email_enseignant.Name = "email_enseignant";
            this.email_enseignant.Size = new System.Drawing.Size(31, 13);
            this.email_enseignant.TabIndex = 11;
            this.email_enseignant.Text = "Email";
            // 
            // email_
            // 
            this.email_.Location = new System.Drawing.Point(44, 339);
            this.email_.Name = "email_";
            this.email_.Size = new System.Drawing.Size(270, 20);
            this.email_.TabIndex = 10;
            this.email_.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // grade_enseignant
            // 
            this.grade_enseignant.AutoSize = true;
            this.grade_enseignant.Location = new System.Drawing.Point(41, 362);
            this.grade_enseignant.Name = "grade_enseignant";
            this.grade_enseignant.Size = new System.Drawing.Size(36, 13);
            this.grade_enseignant.TabIndex = 13;
            this.grade_enseignant.Text = "Grade";
            // 
            // grade_
            // 
            this.grade_.Location = new System.Drawing.Point(44, 378);
            this.grade_.Name = "grade_";
            this.grade_.Size = new System.Drawing.Size(270, 20);
            this.grade_.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reponse_ajout_enseignant
            // 
            this.reponse_ajout_enseignant.AutoSize = true;
            this.reponse_ajout_enseignant.Location = new System.Drawing.Point(148, 401);
            this.reponse_ajout_enseignant.Name = "reponse_ajout_enseignant";
            this.reponse_ajout_enseignant.Size = new System.Drawing.Size(46, 13);
            this.reponse_ajout_enseignant.TabIndex = 15;
            this.reponse_ajout_enseignant.Text = "reponse";
            this.reponse_ajout_enseignant.Visible = false;
            this.reponse_ajout_enseignant.Click += new System.EventHandler(this.reponse_ajout_enseignant_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Client_Bibliothecaire.Properties.Resources.enseignant;
            this.pictureBox1.Location = new System.Drawing.Point(129, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 106);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AjouterMembreEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reponse_ajout_enseignant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grade_enseignant);
            this.Controls.Add(this.grade_);
            this.Controls.Add(this.email_enseignant);
            this.Controls.Add(this.email_);
            this.Controls.Add(this.prenom_enseignant);
            this.Controls.Add(this.prenom_);
            this.Controls.Add(this.nom_enseignant);
            this.Controls.Add(this.nom_);
            this.Controls.Add(this.mot_de_passe_enseignant);
            this.Controls.Add(this.mot_de_passe_);
            this.Controls.Add(this.nom_utilisateur_enseignant);
            this.Controls.Add(this.nom_utilisateur_);
            this.Controls.Add(this.numero_de_carte_enseignant);
            this.Controls.Add(this.numero_de_carte_);
            this.Name = "AjouterMembreEnseignant";
            this.Text = "AjouterMembreEnseignant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero_de_carte_;
        private System.Windows.Forms.Label numero_de_carte_enseignant;
        private System.Windows.Forms.Label nom_utilisateur_enseignant;
        private System.Windows.Forms.TextBox nom_utilisateur_;
        private System.Windows.Forms.Label mot_de_passe_enseignant;
        private System.Windows.Forms.TextBox mot_de_passe_;
        private System.Windows.Forms.Label nom_enseignant;
        private System.Windows.Forms.TextBox nom_;
        private System.Windows.Forms.Label prenom_enseignant;
        private System.Windows.Forms.TextBox prenom_;
        private System.Windows.Forms.Label email_enseignant;
        private System.Windows.Forms.TextBox email_;
        private System.Windows.Forms.Label grade_enseignant;
        private System.Windows.Forms.TextBox grade_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reponse_ajout_enseignant;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}