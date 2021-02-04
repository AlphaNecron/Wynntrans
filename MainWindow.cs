using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using WynnicTranslator.Core;
using static WynnicTranslator.Core.Translator.TransUtils;
using static WynnicTranslator.Core.Utils;

namespace WynnicTranslator
{
    public partial class MainWindow : DarkForm
    {
        private readonly ToolTip _toolTip = new ToolTip
        {
            ReshowDelay = 10000
        };

        private int _lang;
        private bool _restriction = true;
        private string _translatedText;

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            FontUtils.Init();
            Logger.Init();
            textOutput.Font = FontUtils.WynnicFont;
            // Events
            cred.LinkClicked += (i, o) => Process.Start("https://github.com/AlphaNecron/Wynntrans");
            itemCheatsheet.Click += (i, o) => new SymbolCsWindow().ShowDialog();
            itemQuit.Click += (i, o) => Application.Exit();
            wynnicToggler.Click += ChangeLanguage;
            gavellianToggler.Click += ChangeLanguage;
            btnContext.Click += (i, o) => contextMenu.Show(btnContext, btnContext.PointToClient(Cursor.Position));
            cbRestrict.CheckedChanged += (i, o) => _restriction = ((DarkCheckBox) i).Checked;
            textOutput.MouseMove += (i, o) =>
            {
                var sender = i as DarkTextBox;
                _toolTip.SetToolTip(sender ?? new DarkTextBox(), sender?.Text);
            };
            Text = $@"{Application.ProductName} - {Application.ProductVersion}";
            Icon = new Icon(Path.Combine(App.ResFolder, "scroll.ico"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textOrig.Clear();
            textOutput.Clear();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_translatedText)) Clipboard.SetText(_translatedText);
        }

        private void ChangeLanguage(object i, object o)
        {
            var sender = (DarkButton) i;
            textOutput.Font = (string) sender.Tag == "Wynnic"
                ? FontUtils.WynnicFont
                : FontUtils.FallbackFont;
            _lang = (string) sender.Tag == "Wynnic" ? 0 : 1;
            textOrig.Clear();
            textOutput.Clear();
            gavellianToggler.Enabled = (string) sender.Tag == "Wynnic";
            wynnicToggler.Enabled = !gavellianToggler.Enabled;
            langLabel.Text = $@"Language: {sender.Tag}";
            if ((string) sender.Tag == "Gavellian")
                MessageBox.Show(@"Gavellian preview will not work because a valid Gavellian font was not found.",
                    @"Note",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            _translatedText = Translator.Translate((Lang) _lang, textOrig.Text);
            textOutput.Text = textOrig.Text;
        }

        private void textOrig_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (_restriction)
            {
                case true:
                    switch (char.IsControl(e.KeyChar))
                    {
                        case false when e.KeyChar != ' ':
                        {
                            if (!CheckForAllowedChar(e.KeyChar,
                                (Lang) _lang)) e.Handled = true;
                            break;
                        }
                    }

                    break;
            }
        }
    }
}