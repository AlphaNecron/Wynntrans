﻿namespace WynnicTranslator
{
    partial class MainWindow
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
            this.sep = new DarkUI.Controls.DarkSeparator();
            this.wynnicToggler = new DarkUI.Controls.DarkButton();
            this.gavellianToggler = new DarkUI.Controls.DarkButton();
            this.textOrig = new DarkUI.Controls.DarkTextBox();
            this.titleOrig = new DarkUI.Controls.DarkTitle();
            this.titleOutput = new DarkUI.Controls.DarkTitle();
            this.textOutput = new DarkUI.Controls.DarkTextBox();
            this.btnTrans = new DarkUI.Controls.DarkButton();
            this.btnClear = new DarkUI.Controls.DarkButton();
            this.copyBtn = new DarkUI.Controls.DarkButton();
            this.langLabel = new DarkUI.Controls.DarkLabel();
            this.cred = new System.Windows.Forms.LinkLabel();
            this.sepBottom = new DarkUI.Controls.DarkSeparator();
            this.cbRestrict = new DarkUI.Controls.DarkCheckBox();
            this.contextMenu = new DarkUI.Controls.DarkContextMenu();
            this.itemCheatsheet = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContext = new DarkUI.Controls.DarkButton();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sep
            // 
            this.sep.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sep.Location = new System.Drawing.Point(17, 54);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(873, 2);
            this.sep.TabIndex = 1;
            // 
            // wynnicToggler
            // 
            this.wynnicToggler.Enabled = false;
            this.wynnicToggler.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.wynnicToggler.Location = new System.Drawing.Point(17, 20);
            this.wynnicToggler.Name = "wynnicToggler";
            this.wynnicToggler.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.wynnicToggler.Size = new System.Drawing.Size(80, 25);
            this.wynnicToggler.TabIndex = 2;
            this.wynnicToggler.Tag = "Wynnic";
            this.wynnicToggler.Text = "Wynnic";
            // 
            // gavellianToggler
            // 
            this.gavellianToggler.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.gavellianToggler.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gavellianToggler.Location = new System.Drawing.Point(103, 20);
            this.gavellianToggler.Name = "gavellianToggler";
            this.gavellianToggler.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gavellianToggler.Size = new System.Drawing.Size(90, 25);
            this.gavellianToggler.TabIndex = 3;
            this.gavellianToggler.Tag = "Gavellian";
            this.gavellianToggler.Text = "Gavellian";
            // 
            // textOrig
            // 
            this.textOrig.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (84)))), ((int) (((byte) (84)))));
            this.textOrig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOrig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textOrig.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.textOrig.Location = new System.Drawing.Point(15, 80);
            this.textOrig.Multiline = true;
            this.textOrig.Name = "textOrig";
            this.textOrig.Size = new System.Drawing.Size(880, 125);
            this.textOrig.TabIndex = 4;
            this.textOrig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOrig_KeyPress);
            // 
            // titleOrig
            // 
            this.titleOrig.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleOrig.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.titleOrig.Location = new System.Drawing.Point(15, 61);
            this.titleOrig.Name = "titleOrig";
            this.titleOrig.Size = new System.Drawing.Size(879, 15);
            this.titleOrig.TabIndex = 5;
            this.titleOrig.Text = "Original text";
            // 
            // titleOutput
            // 
            this.titleOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.titleOutput.Location = new System.Drawing.Point(15, 220);
            this.titleOutput.Name = "titleOutput";
            this.titleOutput.Size = new System.Drawing.Size(880, 15);
            this.titleOutput.TabIndex = 6;
            this.titleOutput.Text = "Output";
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (84)))), ((int) (((byte) (84)))));
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textOutput.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.textOutput.Location = new System.Drawing.Point(15, 240);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(880, 175);
            this.textOutput.TabIndex = 7;
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(785, 20);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Padding = new System.Windows.Forms.Padding(5);
            this.btnTrans.Size = new System.Drawing.Size(105, 25);
            this.btnTrans.TabIndex = 9;
            this.btnTrans.Text = "Translate [↵]";
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (66)))), ((int) (((byte) (82)))));
            this.btnClear.Location = new System.Drawing.Point(45, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5);
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.copyBtn.Location = new System.Drawing.Point(760, 450);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Padding = new System.Windows.Forms.Padding(5);
            this.copyBtn.Size = new System.Drawing.Size(135, 25);
            this.copyBtn.TabIndex = 11;
            this.copyBtn.Text = "Copy to clipboard";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // langLabel
            // 
            this.langLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.langLabel.Location = new System.Drawing.Point(200, 25);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(175, 15);
            this.langLabel.TabIndex = 12;
            this.langLabel.Text = "Language: Wynnic";
            // 
            // cred
            // 
            this.cred.ActiveLinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (191)))), ((int) (((byte) (97)))), ((int) (((byte) (106)))));
            this.cred.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cred.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (192)))), ((int) (((byte) (208)))));
            this.cred.Location = new System.Drawing.Point(555, 455);
            this.cred.Name = "cred";
            this.cred.Size = new System.Drawing.Size(200, 15);
            this.cred.TabIndex = 13;
            this.cred.TabStop = true;
            this.cred.Text = "Made with ❤ by AlphaNecron";
            this.cred.VisitedLinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (208)))), ((int) (((byte) (135)))), ((int) (((byte) (112)))));
            // 
            // sepBottom
            // 
            this.sepBottom.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sepBottom.Location = new System.Drawing.Point(15, 435);
            this.sepBottom.Name = "sepBottom";
            this.sepBottom.Size = new System.Drawing.Size(880, 2);
            this.sepBottom.TabIndex = 14;
            // 
            // cbRestrict
            // 
            this.cbRestrict.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.cbRestrict.Checked = true;
            this.cbRestrict.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRestrict.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbRestrict.Location = new System.Drawing.Point(550, 20);
            this.cbRestrict.Name = "cbRestrict";
            this.cbRestrict.Size = new System.Drawing.Size(225, 25);
            this.cbRestrict.TabIndex = 15;
            this.cbRestrict.Text = "Only accept allowed characters";
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.contextMenu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.contextMenu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.itemCheatsheet, this.itemHistory, this.toolStripSeparator1, this.itemQuit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(145, 77);
            // 
            // itemCheatsheet
            // 
            this.itemCheatsheet.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.itemCheatsheet.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.itemCheatsheet.Name = "itemCheatsheet";
            this.itemCheatsheet.Size = new System.Drawing.Size(144, 22);
            this.itemCheatsheet.Text = "Cheatsheet";
            // 
            // itemHistory
            // 
            this.itemHistory.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.itemHistory.Enabled = false;
            this.itemHistory.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.itemHistory.Name = "itemHistory";
            this.itemHistory.Size = new System.Drawing.Size(144, 22);
            this.itemHistory.Text = "History";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // itemQuit
            // 
            this.itemQuit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.itemQuit.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.itemQuit.Name = "itemQuit";
            this.itemQuit.Size = new System.Drawing.Size(144, 22);
            this.itemQuit.Text = "Quit";
            // 
            // btnContext
            // 
            this.btnContext.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (66)))), ((int) (((byte) (82)))));
            this.btnContext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnContext.Location = new System.Drawing.Point(15, 450);
            this.btnContext.Name = "btnContext";
            this.btnContext.Padding = new System.Windows.Forms.Padding(5);
            this.btnContext.Size = new System.Drawing.Size(25, 25);
            this.btnContext.TabIndex = 16;
            this.btnContext.Text = "⋮";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnTrans;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (63)))), ((int) (((byte) (65)))));
            this.ClientSize = new System.Drawing.Size(909, 486);
            this.Controls.Add(this.btnContext);
            this.Controls.Add(this.cbRestrict);
            this.Controls.Add(this.sepBottom);
            this.Controls.Add(this.cred);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.titleOutput);
            this.Controls.Add(this.titleOrig);
            this.Controls.Add(this.textOrig);
            this.Controls.Add(this.gavellianToggler);
            this.Controls.Add(this.wynnicToggler);
            this.Controls.Add(this.sep);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(925, 525);
            this.MinimumSize = new System.Drawing.Size(925, 525);
            this.Name = "MainWindow";
            this.Text = "Wynntrans";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private DarkUI.Controls.DarkButton btnContext;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem itemCheatsheet;
        private System.Windows.Forms.ToolStripMenuItem itemHistory;

        private System.Windows.Forms.ToolStripMenuItem itemQuit;

        private DarkUI.Controls.DarkContextMenu contextMenu;

        private DarkUI.Controls.DarkCheckBox cbRestrict;

        private DarkUI.Controls.DarkSeparator sepBottom;

        private System.Windows.Forms.LinkLabel cred;

        private DarkUI.Controls.DarkLabel langLabel;

        private DarkUI.Controls.DarkButton copyBtn;

        private DarkUI.Controls.DarkButton btnClear;

        private DarkUI.Controls.DarkButton btnTrans;

        private DarkUI.Controls.DarkTextBox textOutput;

        private DarkUI.Controls.DarkTitle titleOutput;

        private DarkUI.Controls.DarkTitle titleOrig;

        private DarkUI.Controls.DarkTextBox textOrig;

        private DarkUI.Controls.DarkButton gavellianToggler;

        private DarkUI.Controls.DarkButton wynnicToggler;

        private DarkUI.Controls.DarkSeparator sep;


        #endregion
    }
}