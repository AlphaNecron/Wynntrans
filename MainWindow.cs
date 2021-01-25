using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using WynnicTranslator.Core;

namespace WynnicTranslator
{
    public partial class MainWindow : DarkForm
    {
        private int Lang = 0;
        private bool Restriction = true;
        public MainWindow()
        {
            InitializeComponent();
            Utils.FontUtils.LoadFont();
            cred.LinkClicked += (i, o) => System.Diagnostics.Process.Start("https://github.com/AlphaNecron");
            textOutput.Font = Utils.FontUtils.WynnicFont;
            this.Icon = new Icon(Path.Combine(Application.StartupPath, "res", "wynn.ico"));
            wynnicToggler.Click += (i, o) =>
            {
                textOutput.Font = Utils.FontUtils.WynnicFont;
                textOrig.Clear();
                textOutput.Clear();
                Lang = 0;
                wynnicToggler.Enabled = false;
                gavellianToggler.Enabled = true;
                langLabel.Text = "Language: Wynnic";
            };
            gavellianToggler.Click += (i, o) =>
            {
                textOutput.Font = new Font("Consolas", 10F, FontStyle.Bold);
                textOutput.Clear();
                textOrig.Clear();
                Lang = 1;
                wynnicToggler.Enabled = true;
                gavellianToggler.Enabled = false;
                langLabel.Text = "Language: Gavellian";
                MessageBox.Show("Currently, Gavellian preview doesn't work properly because the Gavellian font is not available.\nFalling back to Consolas font.");
            };
            cbRestrict.CheckedChanged += (i, o) =>
            {
                Restriction = (i as DarkCheckBox).Checked;
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textOrig.Clear();
            textOutput.Clear();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            var convertedText = "";
            var origText = textOrig.Text;
            switch (Lang)
            {
                case 1: 
                    convertedText = Translator.Gavellian.Translate(origText);
                    break;
                default:
                    convertedText = Translator.Wynnic.Translate(origText);
                    break;
            }
            if (!string.IsNullOrEmpty(convertedText))
            {
                Clipboard.SetText(convertedText);   
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOrig.Text;
        }

        private void textOrig_KeyPress(object sender, KeyPressEventArgs e)
        {
        if (Restriction) {
            if (Lang == 0)
            {
                if (!Translator.Wynnic.CheckForAllowedChar(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
            else if (Lang == 1)
            {
                if (!Translator.Gavellian.CheckForAllowedChar(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
        }
        }
    }
}