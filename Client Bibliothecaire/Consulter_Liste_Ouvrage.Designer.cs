namespace Client_Bibliothecaire
{
    partial class Consulter_Liste_Ouvrage
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
            this.listOuvrage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listOuvrage
            // 
            this.listOuvrage.Location = new System.Drawing.Point(0, 0);
            this.listOuvrage.Name = "listOuvrage";
            this.listOuvrage.Size = new System.Drawing.Size(548, 309);
            this.listOuvrage.TabIndex = 0;
            this.listOuvrage.UseCompatibleStateImageBehavior = false;
            this.listOuvrage.SelectedIndexChanged += new System.EventHandler(this.listOuvrage_SelectedIndexChanged);
            this.listOuvrage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_click);
            // 
            // Consulter_Liste_Ouvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 321);
            this.Controls.Add(this.listOuvrage);
            this.Name = "Consulter_Liste_Ouvrage";
            this.Text = "Consulter_Liste_Ouvrage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listOuvrage;
    }
}