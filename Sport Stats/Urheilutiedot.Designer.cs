namespace Harjoitustyö
{
    partial class frmUrheilutiedotvalinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrheilutiedotvalinta));
            this.btnJalkapallo = new System.Windows.Forms.Button();
            this.btnJääkiekko = new System.Windows.Forms.Button();
            this.btnSalibandy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJalkapallo
            // 
            this.btnJalkapallo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJalkapallo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJalkapallo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJalkapallo.Location = new System.Drawing.Point(0, 0);
            this.btnJalkapallo.Name = "btnJalkapallo";
            this.btnJalkapallo.Size = new System.Drawing.Size(298, 100);
            this.btnJalkapallo.TabIndex = 0;
            this.btnJalkapallo.Text = "Jalkapallo";
            this.btnJalkapallo.UseVisualStyleBackColor = true;
            this.btnJalkapallo.Click += new System.EventHandler(this.btnJalkapallo_Click);
            // 
            // btnJääkiekko
            // 
            this.btnJääkiekko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJääkiekko.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJääkiekko.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJääkiekko.Location = new System.Drawing.Point(0, 106);
            this.btnJääkiekko.Name = "btnJääkiekko";
            this.btnJääkiekko.Size = new System.Drawing.Size(298, 100);
            this.btnJääkiekko.TabIndex = 1;
            this.btnJääkiekko.Text = "Jääkiekko";
            this.btnJääkiekko.UseVisualStyleBackColor = true;
            this.btnJääkiekko.Click += new System.EventHandler(this.btnJääkiekko_Click);
            // 
            // btnSalibandy
            // 
            this.btnSalibandy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalibandy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalibandy.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalibandy.Location = new System.Drawing.Point(0, 212);
            this.btnSalibandy.Name = "btnSalibandy";
            this.btnSalibandy.Size = new System.Drawing.Size(298, 100);
            this.btnSalibandy.TabIndex = 2;
            this.btnSalibandy.Text = "Salibandy";
            this.btnSalibandy.UseVisualStyleBackColor = true;
            this.btnSalibandy.Click += new System.EventHandler(this.btnSalibandy_Click);
            // 
            // frmUrheilutiedotvalinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 312);
            this.Controls.Add(this.btnSalibandy);
            this.Controls.Add(this.btnJääkiekko);
            this.Controls.Add(this.btnJalkapallo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUrheilutiedotvalinta";
            this.Text = "Urheilutiedot";
            this.Load += new System.EventHandler(this.frmUrheilutiedotvalinta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJalkapallo;
        private System.Windows.Forms.Button btnJääkiekko;
        private System.Windows.Forms.Button btnSalibandy;
    }
}

