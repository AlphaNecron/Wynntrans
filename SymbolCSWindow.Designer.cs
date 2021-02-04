using System.ComponentModel;

namespace WynnicTranslator
{
    partial class SymbolCsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tree = new DarkUI.Controls.DarkTreeView();
            this.panelTree = new DarkUI.Controls.DarkSectionPanel();
            this.previewer = new System.Windows.Forms.PictureBox();
            this.btnCopy = new DarkUI.Controls.DarkButton();
            this.tbPreview = new DarkUI.Controls.DarkTextBox();
            this.panelTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.previewer)).BeginInit();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(0, 26);
            this.tree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tree.MaxDragChange = 20;
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(430, 286);
            this.tree.TabIndex = 0;
            this.tree.Text = "List";
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.tree);
            this.panelTree.Location = new System.Drawing.Point(13, 12);
            this.panelTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTree.Name = "panelTree";
            this.panelTree.SectionHeader = "Icons";
            this.panelTree.Size = new System.Drawing.Size(430, 312);
            this.panelTree.TabIndex = 1;
            // 
            // previewer
            // 
            this.previewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewer.Location = new System.Drawing.Point(470, 30);
            this.previewer.Name = "previewer";
            this.previewer.Size = new System.Drawing.Size(200, 200);
            this.previewer.TabIndex = 2;
            this.previewer.TabStop = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(595, 302);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(5);
            this.btnCopy.Size = new System.Drawing.Size(75, 22);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbPreview
            // 
            this.tbPreview.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (69)))), ((int) (((byte) (73)))), ((int) (((byte) (74)))));
            this.tbPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbPreview.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (220)))), ((int) (((byte) (220)))));
            this.tbPreview.Location = new System.Drawing.Point(470, 302);
            this.tbPreview.MaxLength = 1;
            this.tbPreview.Name = "tbPreview";
            this.tbPreview.ReadOnly = true;
            this.tbPreview.Size = new System.Drawing.Size(119, 22);
            this.tbPreview.TabIndex = 1;
            this.tbPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SymbolCsWindow
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(699, 336);
            this.Controls.Add(this.tbPreview);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.previewer);
            this.Controls.Add(this.panelTree);
            this.FlatBorder = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SymbolCsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Icon cheatsheet";
            this.panelTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.previewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private DarkUI.Controls.DarkTextBox tbPreview;

        private DarkUI.Controls.DarkButton btnCopy;

        private System.Windows.Forms.PictureBox previewer;

        private DarkUI.Controls.DarkSectionPanel panelTree;

        private DarkUI.Controls.DarkTreeView tree;

        #endregion
    }
}