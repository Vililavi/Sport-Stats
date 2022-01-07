namespace Harjoitustyö
{
    partial class Joukkueet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joukkueet));
            this.dgvKotijoukkue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVierasjoukkue = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbKoti = new System.Windows.Forms.TextBox();
            this.txtbVieras = new System.Windows.Forms.TextBox();
            this.btnValmis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKotijoukkue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVierasjoukkue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKotijoukkue
            // 
            this.dgvKotijoukkue.AllowUserToAddRows = false;
            this.dgvKotijoukkue.AllowUserToDeleteRows = false;
            this.dgvKotijoukkue.AllowUserToResizeColumns = false;
            this.dgvKotijoukkue.AllowUserToResizeRows = false;
            this.dgvKotijoukkue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKotijoukkue.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvKotijoukkue.EnableHeadersVisualStyles = false;
            this.dgvKotijoukkue.Location = new System.Drawing.Point(0, 0);
            this.dgvKotijoukkue.MultiSelect = false;
            this.dgvKotijoukkue.Name = "dgvKotijoukkue";
            this.dgvKotijoukkue.ReadOnly = true;
            this.dgvKotijoukkue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKotijoukkue.ShowEditingIcon = false;
            this.dgvKotijoukkue.Size = new System.Drawing.Size(143, 284);
            this.dgvKotijoukkue.TabIndex = 0;
            this.dgvKotijoukkue.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJoukkueet_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Koti";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvVierasjoukkue);
            this.panel1.Controls.Add(this.dgvKotijoukkue);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 284);
            this.panel1.TabIndex = 4;
            // 
            // dgvVierasjoukkue
            // 
            this.dgvVierasjoukkue.AllowUserToAddRows = false;
            this.dgvVierasjoukkue.AllowUserToDeleteRows = false;
            this.dgvVierasjoukkue.AllowUserToResizeColumns = false;
            this.dgvVierasjoukkue.AllowUserToResizeRows = false;
            this.dgvVierasjoukkue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVierasjoukkue.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvVierasjoukkue.EnableHeadersVisualStyles = false;
            this.dgvVierasjoukkue.Location = new System.Drawing.Point(144, 0);
            this.dgvVierasjoukkue.MultiSelect = false;
            this.dgvVierasjoukkue.Name = "dgvVierasjoukkue";
            this.dgvVierasjoukkue.ReadOnly = true;
            this.dgvVierasjoukkue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVierasjoukkue.ShowEditingIcon = false;
            this.dgvVierasjoukkue.Size = new System.Drawing.Size(143, 284);
            this.dgvVierasjoukkue.TabIndex = 0;
            this.dgvVierasjoukkue.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvVierasjoukkue_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vieras";
            // 
            // txtbKoti
            // 
            this.txtbKoti.Location = new System.Drawing.Point(60, 16);
            this.txtbKoti.Name = "txtbKoti";
            this.txtbKoti.Size = new System.Drawing.Size(60, 20);
            this.txtbKoti.TabIndex = 8;
            // 
            // txtbVieras
            // 
            this.txtbVieras.Location = new System.Drawing.Point(214, 16);
            this.txtbVieras.Name = "txtbVieras";
            this.txtbVieras.Size = new System.Drawing.Size(60, 20);
            this.txtbVieras.TabIndex = 9;
            // 
            // btnValmis
            // 
            this.btnValmis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnValmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValmis.Location = new System.Drawing.Point(0, 256);
            this.btnValmis.Name = "btnValmis";
            this.btnValmis.Size = new System.Drawing.Size(287, 72);
            this.btnValmis.TabIndex = 10;
            this.btnValmis.Text = "Valmis";
            this.btnValmis.UseVisualStyleBackColor = true;
            this.btnValmis.Click += new System.EventHandler(this.btnValmis_Click);
            // 
            // JalkapalloJoukkueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 328);
            this.Controls.Add(this.btnValmis);
            this.Controls.Add(this.txtbVieras);
            this.Controls.Add(this.txtbKoti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JalkapalloJoukkueet";
            this.Text = "Joukkueet";
            this.Load += new System.EventHandler(this.Jalkapallojoukkueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKotijoukkue)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVierasjoukkue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKotijoukkue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVierasjoukkue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbKoti;
        private System.Windows.Forms.TextBox txtbVieras;
        private System.Windows.Forms.Button btnValmis;
    }
}