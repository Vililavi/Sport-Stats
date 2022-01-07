namespace Harjoitustyö
{
    partial class frmMaali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaali));
            this.rbtnKotijoukkue = new System.Windows.Forms.RadioButton();
            this.rbtnVierasjoukkue = new System.Windows.Forms.RadioButton();
            this.cbTekijä = new System.Windows.Forms.ComboBox();
            this.cbSyöttäjä = new System.Windows.Forms.ComboBox();
            this.lblMaalintekijä = new System.Windows.Forms.Label();
            this.lblMaalinsyöttäjä = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnKotijoukkue
            // 
            this.rbtnKotijoukkue.AutoSize = true;
            this.rbtnKotijoukkue.Location = new System.Drawing.Point(12, 12);
            this.rbtnKotijoukkue.Name = "rbtnKotijoukkue";
            this.rbtnKotijoukkue.Size = new System.Drawing.Size(43, 17);
            this.rbtnKotijoukkue.TabIndex = 0;
            this.rbtnKotijoukkue.TabStop = true;
            this.rbtnKotijoukkue.Text = "Koti";
            this.rbtnKotijoukkue.UseVisualStyleBackColor = true;
            this.rbtnKotijoukkue.CheckedChanged += new System.EventHandler(this.rbtnKotijoukkue_CheckedChanged);
            // 
            // rbtnVierasjoukkue
            // 
            this.rbtnVierasjoukkue.AutoSize = true;
            this.rbtnVierasjoukkue.Location = new System.Drawing.Point(116, 12);
            this.rbtnVierasjoukkue.Name = "rbtnVierasjoukkue";
            this.rbtnVierasjoukkue.Size = new System.Drawing.Size(54, 17);
            this.rbtnVierasjoukkue.TabIndex = 1;
            this.rbtnVierasjoukkue.TabStop = true;
            this.rbtnVierasjoukkue.Text = "Vieras";
            this.rbtnVierasjoukkue.UseVisualStyleBackColor = true;
            this.rbtnVierasjoukkue.CheckedChanged += new System.EventHandler(this.rbtnVierasjoukkue_CheckedChanged);
            // 
            // cbTekijä
            // 
            this.cbTekijä.FormattingEnabled = true;
            this.cbTekijä.Location = new System.Drawing.Point(12, 70);
            this.cbTekijä.Name = "cbTekijä";
            this.cbTekijä.Size = new System.Drawing.Size(158, 21);
            this.cbTekijä.TabIndex = 2;
            // 
            // cbSyöttäjä
            // 
            this.cbSyöttäjä.FormattingEnabled = true;
            this.cbSyöttäjä.Location = new System.Drawing.Point(12, 120);
            this.cbSyöttäjä.Name = "cbSyöttäjä";
            this.cbSyöttäjä.Size = new System.Drawing.Size(158, 21);
            this.cbSyöttäjä.TabIndex = 3;
            // 
            // lblMaalintekijä
            // 
            this.lblMaalintekijä.AutoSize = true;
            this.lblMaalintekijä.Location = new System.Drawing.Point(12, 51);
            this.lblMaalintekijä.Name = "lblMaalintekijä";
            this.lblMaalintekijä.Size = new System.Drawing.Size(66, 13);
            this.lblMaalintekijä.TabIndex = 4;
            this.lblMaalintekijä.Text = "Maalin tekijä";
            // 
            // lblMaalinsyöttäjä
            // 
            this.lblMaalinsyöttäjä.AutoSize = true;
            this.lblMaalinsyöttäjä.Location = new System.Drawing.Point(9, 104);
            this.lblMaalinsyöttäjä.Name = "lblMaalinsyöttäjä";
            this.lblMaalinsyöttäjä.Size = new System.Drawing.Size(77, 13);
            this.lblMaalinsyöttäjä.TabIndex = 5;
            this.lblMaalinsyöttäjä.Text = "Maalin syöttäjä";
            // 
            // btnTallenna
            // 
            this.btnTallenna.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTallenna.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(0, 164);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(185, 54);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMaali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.lblMaalinsyöttäjä);
            this.Controls.Add(this.lblMaalintekijä);
            this.Controls.Add(this.cbSyöttäjä);
            this.Controls.Add(this.cbTekijä);
            this.Controls.Add(this.rbtnVierasjoukkue);
            this.Controls.Add(this.rbtnKotijoukkue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaali";
            this.Text = "Maali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnKotijoukkue;
        private System.Windows.Forms.RadioButton rbtnVierasjoukkue;
        private System.Windows.Forms.ComboBox cbTekijä;
        private System.Windows.Forms.ComboBox cbSyöttäjä;
        private System.Windows.Forms.Label lblMaalintekijä;
        private System.Windows.Forms.Label lblMaalinsyöttäjä;
        private System.Windows.Forms.Button btnTallenna;
    }
}