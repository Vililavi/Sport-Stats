namespace Harjoitustyö
{
    partial class frmEräntiedot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEräntiedot));
            this.dgvEräntiedot = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblEräntiedot = new System.Windows.Forms.Label();
            this.lblJoukkue1 = new System.Windows.Forms.Label();
            this.lblJoukkue1Tulos = new System.Windows.Forms.Label();
            this.lblJoukkue2 = new System.Windows.Forms.Label();
            this.lblJoukkue2Tulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEräntiedot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEräntiedot
            // 
            this.dgvEräntiedot.AllowUserToAddRows = false;
            this.dgvEräntiedot.AllowUserToDeleteRows = false;
            this.dgvEräntiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEräntiedot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEräntiedot.Location = new System.Drawing.Point(1, 40);
            this.dgvEräntiedot.Name = "dgvEräntiedot";
            this.dgvEräntiedot.Size = new System.Drawing.Size(489, 265);
            this.dgvEräntiedot.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(0, 311);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(491, 63);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblEräntiedot
            // 
            this.lblEräntiedot.AutoSize = true;
            this.lblEräntiedot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEräntiedot.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEräntiedot.Location = new System.Drawing.Point(0, 0);
            this.lblEräntiedot.Name = "lblEräntiedot";
            this.lblEräntiedot.Size = new System.Drawing.Size(144, 37);
            this.lblEräntiedot.TabIndex = 4;
            this.lblEräntiedot.Text = "Eräntiedot";
            // 
            // lblJoukkue1
            // 
            this.lblJoukkue1.AutoSize = true;
            this.lblJoukkue1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue1.Location = new System.Drawing.Point(150, 0);
            this.lblJoukkue1.Name = "lblJoukkue1";
            this.lblJoukkue1.Size = new System.Drawing.Size(129, 37);
            this.lblJoukkue1.TabIndex = 5;
            this.lblJoukkue1.Text = "Joukkue1";
            // 
            // lblJoukkue1Tulos
            // 
            this.lblJoukkue1Tulos.AutoSize = true;
            this.lblJoukkue1Tulos.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue1Tulos.Location = new System.Drawing.Point(281, 0);
            this.lblJoukkue1Tulos.Name = "lblJoukkue1Tulos";
            this.lblJoukkue1Tulos.Size = new System.Drawing.Size(32, 37);
            this.lblJoukkue1Tulos.TabIndex = 6;
            this.lblJoukkue1Tulos.Text = "0";
            // 
            // lblJoukkue2
            // 
            this.lblJoukkue2.AutoSize = true;
            this.lblJoukkue2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue2.Location = new System.Drawing.Point(319, 0);
            this.lblJoukkue2.Name = "lblJoukkue2";
            this.lblJoukkue2.Size = new System.Drawing.Size(133, 37);
            this.lblJoukkue2.TabIndex = 6;
            this.lblJoukkue2.Text = "Joukkue2";
            // 
            // lblJoukkue2Tulos
            // 
            this.lblJoukkue2Tulos.AutoSize = true;
            this.lblJoukkue2Tulos.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkue2Tulos.Location = new System.Drawing.Point(458, 0);
            this.lblJoukkue2Tulos.Name = "lblJoukkue2Tulos";
            this.lblJoukkue2Tulos.Size = new System.Drawing.Size(32, 37);
            this.lblJoukkue2Tulos.TabIndex = 7;
            this.lblJoukkue2Tulos.Text = "0";
            // 
            // frmEräntiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 374);
            this.Controls.Add(this.lblJoukkue2Tulos);
            this.Controls.Add(this.lblJoukkue2);
            this.Controls.Add(this.lblJoukkue1Tulos);
            this.Controls.Add(this.lblJoukkue1);
            this.Controls.Add(this.lblEräntiedot);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvEräntiedot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEräntiedot";
            this.Text = "Eräntiedot";
            this.Load += new System.EventHandler(this.Eräntiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEräntiedot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEräntiedot;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblEräntiedot;
        private System.Windows.Forms.Label lblJoukkue1;
        private System.Windows.Forms.Label lblJoukkue1Tulos;
        private System.Windows.Forms.Label lblJoukkue2;
        private System.Windows.Forms.Label lblJoukkue2Tulos;
    }
}