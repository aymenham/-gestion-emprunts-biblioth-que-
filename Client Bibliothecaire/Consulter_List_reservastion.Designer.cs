namespace Client_Bibliothecaire
{
    partial class Consulter_List_reservastion
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
            this.list_reservation = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // list_reservation
            // 
            this.list_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_reservation.Location = new System.Drawing.Point(12, 74);
            this.list_reservation.Name = "list_reservation";
            this.list_reservation.Size = new System.Drawing.Size(775, 310);
            this.list_reservation.TabIndex = 0;
            this.list_reservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_reservation_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Liberer Reservastion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Confirmer Reservastion ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consulter_List_reservastion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_reservation);
            this.Name = "Consulter_List_reservastion";
            this.Text = "Consulter_List_reservastion";
            ((System.ComponentModel.ISupportInitialize)(this.list_reservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list_reservation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}