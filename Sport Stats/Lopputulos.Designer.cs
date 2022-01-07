namespace Harjoitustyö
{
    partial class frmLopputulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopputulos));
            this.lblLopputulos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblJoukkue1Tulos = new System.Windows.Forms.Label();
            this.lblJoukkue2 = new System.Windows.Forms.Label();
            this.lblJoukkue1 = new System.Windows.Forms.Label();
            this.lblJoukkue2Tulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLopputulos
            // 
            this.lblLopputulos.AutoSize = true;
            this.lblLopputulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLopputulos.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopputulos.Location = new System.Drawing.Point(0, 0);
            this.lblLopputulos.Name = "lblLopputulos";
            this.lblLopputulos.Size = new System.Drawing.Size(155, 37);
            this.lblLopputulos.TabIndex = 0;
            this.lblLopputulos.Text = "Lopputulos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblJoukkue1Tulos
            // 
            this.lblJoukkue1Tulos.AutoSize = true;
            this.lblJoukkue1Tulos.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue1Tulos.Location = new System.Drawing.Point(289, 0);
            this.lblJoukkue1Tulos.Name = "lblJoukkue1Tulos";
            this.lblJoukkue1Tulos.Size = new System.Drawing.Size(32, 37);
            this.lblJoukkue1Tulos.TabIndex = 2;
            this.lblJoukkue1Tulos.Text = "0";
            // 
            // lblJoukkue2
            // 
            this.lblJoukkue2.AutoSize = true;
            this.lblJoukkue2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue2.Location = new System.Drawing.Point(323, 0);
            this.lblJoukkue2.Name = "lblJoukkue2";
            this.lblJoukkue2.Size = new System.Drawing.Size(133, 37);
            this.lblJoukkue2.TabIndex = 3;
            this.lblJoukkue2.Text = "Joukkue2";
            // 
            // lblJoukkue1
            // 
            this.lblJoukkue1.AutoSize = true;
            this.lblJoukkue1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue1.Location = new System.Drawing.Point(154, 0);
            this.lblJoukkue1.Name = "lblJoukkue1";
            this.lblJoukkue1.Size = new System.Drawing.Size(129, 37);
            this.lblJoukkue1.TabIndex = 4;
            this.lblJoukkue1.Text = "Joukkue1";
            // 
            // lblJoukkue2Tulos
            // 
            this.lblJoukkue2Tulos.AutoSize = true;
            this.lblJoukkue2Tulos.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue2Tulos.Location = new System.Drawing.Point(462, 0);
            this.lblJoukkue2Tulos.Name = "lblJoukkue2Tulos";
            this.lblJoukkue2Tulos.Size = new System.Drawing.Size(32, 37);
            this.lblJoukkue2Tulos.TabIndex = 5;
            this.lblJoukkue2Tulos.Text = "0";
            // 
            // frmLopputulos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 374);
            this.Controls.Add(this.lblJoukkue2Tulos);
            this.Controls.Add(this.lblJoukkue1);
            this.Controls.Add(this.lblJoukkue2);
            this.Controls.Add(this.lblJoukkue1Tulos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLopputulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLopputulos";
            this.Text = "Lopputulos";
            this.Load += new System.EventHandler(this.Lopputulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLopputulos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblJoukkue1Tulos;
        private System.Windows.Forms.Label lblJoukkue2;
        private System.Windows.Forms.Label lblJoukkue1;
        private System.Windows.Forms.Label lblJoukkue2Tulos;
    }
}