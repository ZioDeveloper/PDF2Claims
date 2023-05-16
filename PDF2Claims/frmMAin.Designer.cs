namespace PDF2Claims
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDati = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisposizioneFogli = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispAffVert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispAffOrizz = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.cattolicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDati,
            this.mnuUtilities,
            this.mnuDisposizioneFogli,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Exit});
            this.mnuFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuFile.Image")));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(53, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Size = new System.Drawing.Size(93, 22);
            this.mnuFile_Exit.Text = "Exit";
            // 
            // mnuDati
            // 
            this.mnuDati.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cattolicaToolStripMenuItem});
            this.mnuDati.Image = ((System.Drawing.Image)(resources.GetObject("mnuDati.Image")));
            this.mnuDati.Name = "mnuDati";
            this.mnuDati.Size = new System.Drawing.Size(129, 20);
            this.mnuDati.Text = "Importazione PDF";
            // 
            // mnuUtilities
            // 
            this.mnuUtilities.Image = ((System.Drawing.Image)(resources.GetObject("mnuUtilities.Image")));
            this.mnuUtilities.Name = "mnuUtilities";
            this.mnuUtilities.Size = new System.Drawing.Size(66, 20);
            this.mnuUtilities.Text = "Utilità";
            // 
            // mnuDisposizioneFogli
            // 
            this.mnuDisposizioneFogli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDispCascade,
            this.mnuDispAffVert,
            this.mnuDispAffOrizz});
            this.mnuDisposizioneFogli.Image = ((System.Drawing.Image)(resources.GetObject("mnuDisposizioneFogli.Image")));
            this.mnuDisposizioneFogli.Name = "mnuDisposizioneFogli";
            this.mnuDisposizioneFogli.Size = new System.Drawing.Size(143, 20);
            this.mnuDisposizioneFogli.Text = "Disposizione finestre";
            // 
            // mnuDispCascade
            // 
            this.mnuDispCascade.Name = "mnuDispCascade";
            this.mnuDispCascade.Size = new System.Drawing.Size(185, 22);
            this.mnuDispCascade.Text = "Cascata";
            // 
            // mnuDispAffVert
            // 
            this.mnuDispAffVert.Name = "mnuDispAffVert";
            this.mnuDispAffVert.Size = new System.Drawing.Size(185, 22);
            this.mnuDispAffVert.Text = "Affiancate verticali";
            // 
            // mnuDispAffOrizz
            // 
            this.mnuDispAffOrizz.Name = "mnuDispAffOrizz";
            this.mnuDispAffOrizz.Size = new System.Drawing.Size(185, 22);
            this.mnuDispAffOrizz.Text = "Affiancate orizzontali";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_Info});
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(60, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelp_Info
            // 
            this.mnuHelp_Info.Name = "mnuHelp_Info";
            this.mnuHelp_Info.Size = new System.Drawing.Size(95, 22);
            this.mnuHelp_Info.Text = "Info";
            this.mnuHelp_Info.Click += new System.EventHandler(this.mnuHelp_Info_Click);
            // 
            // cattolicaToolStripMenuItem
            // 
            this.cattolicaToolStripMenuItem.Name = "cattolicaToolStripMenuItem";
            this.cattolicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cattolicaToolStripMenuItem.Text = "Cattolica";
            this.cattolicaToolStripMenuItem.Click += new System.EventHandler(this.cattolicaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 716);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "PDF -> Claims";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuDati;
        private System.Windows.Forms.ToolStripMenuItem mnuDisposizioneFogli;
        private System.Windows.Forms.ToolStripMenuItem mnuDispCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuDispAffVert;
        private System.Windows.Forms.ToolStripMenuItem mnuDispAffOrizz;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_Info;
        private System.Windows.Forms.ToolStripMenuItem mnuUtilities;
        private System.Windows.Forms.ToolStripMenuItem cattolicaToolStripMenuItem;
    }
}

