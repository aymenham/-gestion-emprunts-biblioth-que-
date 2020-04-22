namespace Client_Emprunteur
{
    partial class Login
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
            this.nom_utilisateur = new System.Windows.Forms.TextBox();
            this.mot_de_passe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reponse_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom_utilisateur
            // 
            this.nom_utilisateur.Location = new System.Drawing.Point(363, 83);
            this.nom_utilisateur.Name = "nom_utilisateur";
            this.nom_utilisateur.Size = new System.Drawing.Size(152, 20);
            this.nom_utilisateur.TabIndex = 0;
            this.nom_utilisateur.TextChanged += new System.EventHandler(this.nom_utilisateur_TextChanged);
            // 
            // mot_de_passe
            // 
            this.mot_de_passe.Location = new System.Drawing.Point(363, 145);
            this.mot_de_passe.Name = "mot_de_passe";
            this.mot_de_passe.PasswordChar = '*';
            this.mot_de_passe.Size = new System.Drawing.Size(152, 20);
            this.mot_de_passe.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(393, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "nom utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "mot de passe";
            // 
            // reponse_login
            // 
            this.reponse_login.AutoSize = true;
            this.reponse_login.Location = new System.Drawing.Point(390, 34);
            this.reponse_login.Name = "reponse_login";
            this.reponse_login.Size = new System.Drawing.Size(0, 13);
            this.reponse_login.TabIndex = 5;
            this.reponse_login.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client_Emprunteur.Properties.Resources.old_library_detail_ConvertImage1;
            this.ClientSize = new System.Drawing.Size(812, 297);
            this.Controls.Add(this.reponse_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mot_de_passe);
            this.Controls.Add(this.nom_utilisateur);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom_utilisateur;
        private System.Windows.Forms.TextBox mot_de_passe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reponse_login;
    }
}

