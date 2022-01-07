namespace Harjoitustyö
{
    partial class frmJääkiekkotilastot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJääkiekkotilastot));
            this.timerKello = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblJoukkueKoti = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJoukkueVieras = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgVieras = new System.Windows.Forms.DataGridView();
            this.dgKoti = new System.Windows.Forms.DataGridView();
            this.lblEra = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMaaliVieras = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblkello = new System.Windows.Forms.Label();
            this.lblMaaliKoti = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAikamuokkausMiinus = new System.Windows.Forms.Button();
            this.btnAikamuokkausPlus = new System.Windows.Forms.Button();
            this.btnAikamuokkaus = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jalkapallotilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jääkiekkotilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salibandytilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maalitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnValitseJoukkueet = new System.Windows.Forms.Button();
            this.btnAloitaera = new System.Windows.Forms.Button();
            this.btnMaali = new System.Windows.Forms.Button();
            this.timerPäivitys = new System.Windows.Forms.Timer(this.components);
            this.btnPelinTiedot = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPikakelaus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVieras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKoti)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerKello
            // 
            this.timerKello.Interval = 1000;
            this.timerKello.Tick += new System.EventHandler(this.timerKello_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(513, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyDown);
            // 
            // lblJoukkueKoti
            // 
            this.lblJoukkueKoti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJoukkueKoti.AutoSize = true;
            this.lblJoukkueKoti.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkueKoti.ForeColor = System.Drawing.Color.Black;
            this.lblJoukkueKoti.Location = new System.Drawing.Point(8, 11);
            this.lblJoukkueKoti.Name = "lblJoukkueKoti";
            this.lblJoukkueKoti.Size = new System.Drawing.Size(0, 40);
            this.lblJoukkueKoti.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Koti";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblJoukkueKoti);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 86);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblJoukkueVieras);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(647, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 86);
            this.panel2.TabIndex = 11;
            // 
            // lblJoukkueVieras
            // 
            this.lblJoukkueVieras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJoukkueVieras.AutoSize = true;
            this.lblJoukkueVieras.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoukkueVieras.ForeColor = System.Drawing.Color.Black;
            this.lblJoukkueVieras.Location = new System.Drawing.Point(5, 11);
            this.lblJoukkueVieras.Name = "lblJoukkueVieras";
            this.lblJoukkueVieras.Size = new System.Drawing.Size(0, 40);
            this.lblJoukkueVieras.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(48, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vieras";
            // 
            // dgVieras
            // 
            this.dgVieras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVieras.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgVieras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVieras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgVieras.Location = new System.Drawing.Point(458, 115);
            this.dgVieras.Name = "dgVieras";
            this.dgVieras.Size = new System.Drawing.Size(345, 415);
            this.dgVieras.TabIndex = 12;
            this.dgVieras.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // dgKoti
            // 
            this.dgKoti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgKoti.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgKoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKoti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgKoti.Location = new System.Drawing.Point(0, 115);
            this.dgKoti.Name = "dgKoti";
            this.dgKoti.Size = new System.Drawing.Size(345, 415);
            this.dgKoti.TabIndex = 13;
            this.dgKoti.DataSourceChanged += new System.EventHandler(this.dataGridView2_DataSourceChanged);
            // 
            // lblEra
            // 
            this.lblEra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEra.AutoSize = true;
            this.lblEra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEra.ForeColor = System.Drawing.Color.Black;
            this.lblEra.Location = new System.Drawing.Point(85, 70);
            this.lblEra.Name = "lblEra";
            this.lblEra.Size = new System.Drawing.Size(0, 20);
            this.lblEra.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblMaaliVieras);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblMaaliKoti);
            this.panel3.Controls.Add(this.lblEra);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(293, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 361);
            this.panel3.TabIndex = 15;
            // 
            // lblMaaliVieras
            // 
            this.lblMaaliVieras.AutoSize = true;
            this.lblMaaliVieras.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaaliVieras.ForeColor = System.Drawing.Color.Black;
            this.lblMaaliVieras.Location = new System.Drawing.Point(167, 60);
            this.lblMaaliVieras.Name = "lblMaaliVieras";
            this.lblMaaliVieras.Size = new System.Drawing.Size(28, 32);
            this.lblMaaliVieras.TabIndex = 17;
            this.lblMaaliVieras.Text = "0";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblkello);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 51);
            this.panel5.TabIndex = 15;
            // 
            // lblkello
            // 
            this.lblkello.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblkello.AutoSize = true;
            this.lblkello.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkello.ForeColor = System.Drawing.Color.Red;
            this.lblkello.Location = new System.Drawing.Point(59, 3);
            this.lblkello.Name = "lblkello";
            this.lblkello.Size = new System.Drawing.Size(110, 50);
            this.lblkello.TabIndex = 6;
            this.lblkello.Text = "60:00";
            this.lblkello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaaliKoti
            // 
            this.lblMaaliKoti.AutoSize = true;
            this.lblMaaliKoti.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaaliKoti.ForeColor = System.Drawing.Color.Black;
            this.lblMaaliKoti.Location = new System.Drawing.Point(26, 60);
            this.lblMaaliKoti.Name = "lblMaaliKoti";
            this.lblMaaliKoti.Size = new System.Drawing.Size(28, 32);
            this.lblMaaliKoti.TabIndex = 16;
            this.lblMaaliKoti.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAikamuokkausMiinus);
            this.panel4.Controls.Add(this.btnAikamuokkausPlus);
            this.panel4.Controls.Add(this.btnAikamuokkaus);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 115);
            this.panel4.TabIndex = 16;
            // 
            // btnAikamuokkausMiinus
            // 
            this.btnAikamuokkausMiinus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAikamuokkausMiinus.BackColor = System.Drawing.Color.LightGray;
            this.btnAikamuokkausMiinus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAikamuokkausMiinus.ForeColor = System.Drawing.Color.Black;
            this.btnAikamuokkausMiinus.Location = new System.Drawing.Point(225, 66);
            this.btnAikamuokkausMiinus.Name = "btnAikamuokkausMiinus";
            this.btnAikamuokkausMiinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAikamuokkausMiinus.Size = new System.Drawing.Size(62, 43);
            this.btnAikamuokkausMiinus.TabIndex = 19;
            this.btnAikamuokkausMiinus.Text = "-";
            this.btnAikamuokkausMiinus.UseVisualStyleBackColor = false;
            this.btnAikamuokkausMiinus.Click += new System.EventHandler(this.btnAikamuokkausMiinus_Click);
            this.btnAikamuokkausMiinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAikamuokkausMiinus_KeyDown);
            // 
            // btnAikamuokkausPlus
            // 
            this.btnAikamuokkausPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAikamuokkausPlus.BackColor = System.Drawing.Color.LightGray;
            this.btnAikamuokkausPlus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAikamuokkausPlus.ForeColor = System.Drawing.Color.Black;
            this.btnAikamuokkausPlus.Location = new System.Drawing.Point(159, 66);
            this.btnAikamuokkausPlus.Name = "btnAikamuokkausPlus";
            this.btnAikamuokkausPlus.Size = new System.Drawing.Size(62, 43);
            this.btnAikamuokkausPlus.TabIndex = 18;
            this.btnAikamuokkausPlus.Text = "+";
            this.btnAikamuokkausPlus.UseVisualStyleBackColor = false;
            this.btnAikamuokkausPlus.Click += new System.EventHandler(this.btnAikamuokkausPlus_Click);
            this.btnAikamuokkausPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAikamuokkausPlus_KeyDown);
            // 
            // btnAikamuokkaus
            // 
            this.btnAikamuokkaus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAikamuokkaus.BackColor = System.Drawing.Color.LightGray;
            this.btnAikamuokkaus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAikamuokkaus.ForeColor = System.Drawing.Color.Black;
            this.btnAikamuokkaus.Location = new System.Drawing.Point(159, 23);
            this.btnAikamuokkaus.Name = "btnAikamuokkaus";
            this.btnAikamuokkaus.Size = new System.Drawing.Size(128, 37);
            this.btnAikamuokkaus.TabIndex = 16;
            this.btnAikamuokkaus.Text = "Minuutti";
            this.btnAikamuokkaus.UseVisualStyleBackColor = false;
            this.btnAikamuokkaus.Click += new System.EventHandler(this.btnAikamuokkaus_Click);
            this.btnAikamuokkaus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAikamuokkaus_KeyDown);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(513, 66);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 43);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStop_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jalkapallotilastotToolStripMenuItem,
            this.jääkiekkotilastotToolStripMenuItem,
            this.salibandytilastotToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // jalkapallotilastotToolStripMenuItem
            // 
            this.jalkapallotilastotToolStripMenuItem.Name = "jalkapallotilastotToolStripMenuItem";
            this.jalkapallotilastotToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.jalkapallotilastotToolStripMenuItem.Text = "Jalkapallotilastot";
            this.jalkapallotilastotToolStripMenuItem.Click += new System.EventHandler(this.jalkapallotilastotToolStripMenuItem_Click);
            // 
            // jääkiekkotilastotToolStripMenuItem
            // 
            this.jääkiekkotilastotToolStripMenuItem.Name = "jääkiekkotilastotToolStripMenuItem";
            this.jääkiekkotilastotToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.jääkiekkotilastotToolStripMenuItem.Text = "Jääkiekkotilastot";
            this.jääkiekkotilastotToolStripMenuItem.Click += new System.EventHandler(this.jääkiekkotilastotToolStripMenuItem_Click);
            // 
            // salibandytilastotToolStripMenuItem
            // 
            this.salibandytilastotToolStripMenuItem.Name = "salibandytilastotToolStripMenuItem";
            this.salibandytilastotToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salibandytilastotToolStripMenuItem.Text = "Salibandytilastot";
            this.salibandytilastotToolStripMenuItem.Click += new System.EventHandler(this.salibandytilastotToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maalitToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // maalitToolStripMenuItem
            // 
            this.maalitToolStripMenuItem.Name = "maalitToolStripMenuItem";
            this.maalitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.maalitToolStripMenuItem.Text = "Maalit";
            this.maalitToolStripMenuItem.Click += new System.EventHandler(this.maalitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // btnValitseJoukkueet
            // 
            this.btnValitseJoukkueet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValitseJoukkueet.ForeColor = System.Drawing.Color.Black;
            this.btnValitseJoukkueet.Location = new System.Drawing.Point(351, 448);
            this.btnValitseJoukkueet.Name = "btnValitseJoukkueet";
            this.btnValitseJoukkueet.Size = new System.Drawing.Size(101, 71);
            this.btnValitseJoukkueet.TabIndex = 17;
            this.btnValitseJoukkueet.Text = "Valitse\r\nJoukkueet";
            this.btnValitseJoukkueet.UseVisualStyleBackColor = true;
            this.btnValitseJoukkueet.Click += new System.EventHandler(this.btnValitseJoukkueet_Click);
            // 
            // btnAloitaera
            // 
            this.btnAloitaera.BackColor = System.Drawing.SystemColors.Control;
            this.btnAloitaera.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloitaera.ForeColor = System.Drawing.Color.Black;
            this.btnAloitaera.Location = new System.Drawing.Point(351, 121);
            this.btnAloitaera.Name = "btnAloitaera";
            this.btnAloitaera.Size = new System.Drawing.Size(101, 71);
            this.btnAloitaera.TabIndex = 18;
            this.btnAloitaera.Text = "Aloita erä";
            this.btnAloitaera.UseVisualStyleBackColor = false;
            this.btnAloitaera.Click += new System.EventHandler(this.btnAloitaera_Click);
            // 
            // btnMaali
            // 
            this.btnMaali.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaali.ForeColor = System.Drawing.Color.Black;
            this.btnMaali.Location = new System.Drawing.Point(351, 198);
            this.btnMaali.Name = "btnMaali";
            this.btnMaali.Size = new System.Drawing.Size(101, 71);
            this.btnMaali.TabIndex = 19;
            this.btnMaali.Text = "Maali";
            this.btnMaali.UseVisualStyleBackColor = true;
            this.btnMaali.Click += new System.EventHandler(this.btnMaali_Click);
            this.btnMaali.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnMaali_KeyDown);
            // 
            // timerPäivitys
            // 
            this.timerPäivitys.Tick += new System.EventHandler(this.timerPäivitys_Tick);
            // 
            // btnPelinTiedot
            // 
            this.btnPelinTiedot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelinTiedot.ForeColor = System.Drawing.Color.Black;
            this.btnPelinTiedot.Location = new System.Drawing.Point(351, 275);
            this.btnPelinTiedot.Name = "btnPelinTiedot";
            this.btnPelinTiedot.Size = new System.Drawing.Size(101, 71);
            this.btnPelinTiedot.TabIndex = 20;
            this.btnPelinTiedot.Text = "Pelin Tiedot";
            this.btnPelinTiedot.UseVisualStyleBackColor = true;
            this.btnPelinTiedot.Click += new System.EventHandler(this.btnPelinTiedot_Click);
            // 
            // btnPikakelaus
            // 
            this.btnPikakelaus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPikakelaus.ForeColor = System.Drawing.Color.Black;
            this.btnPikakelaus.Location = new System.Drawing.Point(351, 352);
            this.btnPikakelaus.Name = "btnPikakelaus";
            this.btnPikakelaus.Size = new System.Drawing.Size(101, 71);
            this.btnPikakelaus.TabIndex = 21;
            this.btnPikakelaus.Text = "Normaali nopeus";
            this.btnPikakelaus.UseVisualStyleBackColor = true;
            this.btnPikakelaus.Click += new System.EventHandler(this.btnPikakelaus_Click);
            // 
            // frmJääkiekkotilastot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnPikakelaus);
            this.Controls.Add(this.btnPelinTiedot);
            this.Controls.Add(this.btnMaali);
            this.Controls.Add(this.btnAloitaera);
            this.Controls.Add(this.btnValitseJoukkueet);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgKoti);
            this.Controls.Add(this.dgVieras);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmJääkiekkotilastot";
            this.Text = "Jääkiekkotilastot 1.00.0.0";
            this.Load += new System.EventHandler(this.frmUrheilutiedotJalkapallo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUrheilutiedotJalkapallo_KeyDown);
            this.MouseHover += new System.EventHandler(this.frmUrheilutiedotJalkapallo_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVieras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKoti)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerKello;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblJoukkueKoti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblJoukkueVieras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgVieras;
        private System.Windows.Forms.DataGridView dgKoti;
        private System.Windows.Forms.Label lblEra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAikamuokkaus;
        private System.Windows.Forms.Button btnAikamuokkausMiinus;
        private System.Windows.Forms.Button btnAikamuokkausPlus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jalkapallotilastotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jääkiekkotilastotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salibandytilastotToolStripMenuItem;
        private System.Windows.Forms.Button btnValitseJoukkueet;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.Button btnAloitaera;
        private System.Windows.Forms.Button btnMaali;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblkello;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timerPäivitys;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maalitToolStripMenuItem;
        private System.Windows.Forms.Label lblMaaliVieras;
        private System.Windows.Forms.Label lblMaaliKoti;
        private System.Windows.Forms.Button btnPelinTiedot;
        private System.Windows.Forms.Button btnPikakelaus;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}