namespace Client_Emprunteur
{
    partial class Modifier_profile
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
            this.button1 = new System.Windows.Forms.Button();
            this.nouveau_nom_utilisateur = new System.Windows.Forms.TextBox();
            this.nouveau_mot_de_passe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultat_modifcation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nouveau_nom_utilisateur
            // 
            this.nouveau_nom_utilisateur.HideSelection = false;
            this.nouveau_nom_utilisateur.Location = new System.Drawing.Point(187, 63);
            this.nouveau_nom_utilisateur.Name = "nouveau_nom_utilisateur";
            this.nouveau_nom_utilisateur.Size = new System.Drawing.Size(158, 20);
            this.nouveau_nom_utilisateur.TabIndex = 1;
            // 
            // nouveau_mot_de_passe
            // 
            this.nouveau_mot_de_passe.Location = new System.Drawing.Point(187, 120);
            this.nouveau_mot_de_passe.Name = "nouveau_mot_de_passe";
            this.nouveau_mot_de_passe.Size = new System.Drawing.Size(158, 20);
            this.nouveau_mot_de_passe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nouveau nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "nouveau mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultat_modifcation
            // 
            this.resultat_modifcation.AutoSize = true;
            this.resultat_modifcation.Location = new System.Drawing.Point(226, 9);
            this.resultat_modifcation.Name = "resultat_modifcation";
            this.resultat_modifcation.Size = new System.Drawing.Size(0, 13);
            this.resultat_modifcation.TabIndex = 5;
            // 
            // Modifier_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 253);
            this.Controls.Add(this.resultat_modifcation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nouveau_mot_de_passe);
            this.Controls.Add(this.nouveau_nom_utilisateur);
            this.Controls.Add(this.button1);
            this.Name = "Modifier_profile";
            this.Text = "Modifier votre profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nouveau_nom_utilisateur;
        private System.Windows.Forms.TextBox nouveau_mot_de_passe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultat_modifcation;
    }
}