namespace Harjoitustyö
{
    partial class frmMaalit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaalit));
            this.dgvMaalit = new System.Windows.Forms.DataGridView();
            this.lblMaalit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlisää = new System.Windows.Forms.Button();
            this.rbtnVieras = new System.Windows.Forms.RadioButton();
            this.rbtnKoti = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSyöttäjä = new System.Windows.Forms.ComboBox();
            this.cbTekijä = new System.Windows.Forms.ComboBox();
            this.tbAika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaalit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaalit
            // 
            this.dgvMaalit.AllowUserToAddRows = false;
            this.dgvMaalit.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMaalit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaalit.Location = new System.Drawing.Point(263, 68);
            this.dgvMaalit.Name = "dgvMaalit";
            this.dgvMaalit.Size = new System.Drawing.Size(445, 301);
            this.dgvMaalit.TabIndex = 0;
            // 
            // lblMaalit
            // 
            this.lblMaalit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaalit.AutoSize = true;
            this.lblMaalit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaalit.Location = new System.Drawing.Point(308, 0);
            this.lblMaalit.Name = "lblMaalit";
            this.lblMaalit.Size = new System.Drawing.Size(124, 50);
            this.lblMaalit.TabIndex = 1;
            this.lblMaalit.Text = "Maalit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnlisää);
            this.panel1.Controls.Add(this.rbtnVieras);
            this.panel1.Controls.Add(this.rbtnKoti);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbSyöttäjä);
            this.panel1.Controls.Add(this.cbTekijä);
            this.panel1.Controls.Add(this.tbAika);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTallenna);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 301);
            this.panel1.TabIndex = 2;
            // 
            // btnlisää
            // 
            this.btnlisää.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlisää.Location = new System.Drawing.Point(143, 240);
            this.btnlisää.Name = "btnlisää";
            this.btnlisää.Size = new System.Drawing.Size(99, 58);
            this.btnlisää.TabIndex = 10;
            this.btnlisää.Text = "Lisää";
            this.btnlisää.UseVisualStyleBackColor = true;
            this.btnlisää.Click += new System.EventHandler(this.btnlisää_Click);
            // 
            // rbtnVieras
            // 
            this.rbtnVieras.AutoSize = true;
            this.rbtnVieras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVieras.Location = new System.Drawing.Point(119, 73);
            this.rbtnVieras.Name = "rbtnVieras";
            this.rbtnVieras.Size = new System.Drawing.Size(126, 25);
            this.rbtnVieras.TabIndex = 9;
            this.rbtnVieras.TabStop = true;
            this.rbtnVieras.Text = "Vierasjoukkue";
            this.rbtnVieras.UseVisualStyleBackColor = true;
            this.rbtnVieras.CheckedChanged += new System.EventHandler(this.rbtnVieras_CheckedChanged);
            // 
            // rbtnKoti
            // 
            this.rbtnKoti.AutoSize = true;
            this.rbtnKoti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnKoti.Location = new System.Drawing.Point(10, 73);
            this.rbtnKoti.Name = "rbtnKoti";
            this.rbtnKoti.Size = new System.Drawing.Size(110, 25);
            this.rbtnKoti.TabIndex = 8;
            this.rbtnKoti.TabStop = true;
            this.rbtnKoti.Text = "Kotijoukkue";
            this.rbtnKoti.UseVisualStyleBackColor = true;
            this.rbtnKoti.CheckedChanged += new System.EventHandler(this.rbtnKoti_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maalinsyöttäjä";
            // 
            // cbSyöttäjä
            // 
            this.cbSyöttäjä.FormattingEnabled = true;
            this.cbSyöttäjä.Location = new System.Drawing.Point(119, 180);
            this.cbSyöttäjä.Name = "cbSyöttäjä";
            this.cbSyöttäjä.Size = new System.Drawing.Size(121, 21);
            this.cbSyöttäjä.TabIndex = 6;
            // 
            // cbTekijä
            // 
            this.cbTekijä.FormattingEnabled = true;
            this.cbTekijä.Location = new System.Drawing.Point(119, 120);
            this.cbTekijä.Name = "cbTekijä";
            this.cbTekijä.Size = new System.Drawing.Size(121, 21);
            this.cbTekijä.TabIndex = 5;
            // 
            // tbAika
            // 
            this.tbAika.Location = new System.Drawing.Point(119, 24);
            this.tbAika.Name = "tbAika";
            this.tbAika.Size = new System.Drawing.Size(39, 20);
            this.tbAika.TabIndex = 4;
            this.tbAika.Text = "0000";
            this.tbAika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAika_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maalintekijä";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aika";
            // 
            // btnTallenna
            // 
            this.btnTallenna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTallenna.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(10, 240);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(125, 58);
            this.btnTallenna.TabIndex = 0;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMaalit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 50);
            this.panel2.TabIndex = 3;
            // 
            // frmMaalit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMaalit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaalit";
            this.Text = "Maalit";
            this.Load += new System.EventHandler(this.Maalit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaalit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaalit;
        private System.Windows.Forms.Label lblMaalit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnVieras;
        private System.Windows.Forms.RadioButton rbtnKoti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSyöttäjä;
        private System.Windows.Forms.ComboBox cbTekijä;
        private System.Windows.Forms.TextBox tbAika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnlisää;
        private System.Windows.Forms.Panel panel2;
    }
}