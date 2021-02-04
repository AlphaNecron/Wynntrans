using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using WynnicTranslator.Core;

namespace WynnicTranslator
{
    public partial class SymbolCsWindow : DarkForm
    {
        private DarkTreeNode _craftingProfessionNode;
        private DarkTreeNode _gamemodeNode;
        private DarkTreeNode _gatheringProfessionNode;
        private DarkTreeNode _professionNode;
        private DarkTreeNode _selectedNode;

        public SymbolCsWindow()
        {
            InitializeComponent();
            AddNodes();
            tree.SelectedNodesChanged += OnSelected;
        }

        private string[] Gamemodes { get; } = {"Hardcore", "Ironman", "Craftsman", "Hunted"};
        private char[] GamemodeIcons { get; } = {'☠', '❂', '✿', '⚔'};
        private string[] GatheringProfessions { get; } = {"Woodcutting", "Mining", "Farming", "Fishing"};
        private char[] GatheringIcons { get; } = {'Ⓒ', 'Ⓑ', 'Ⓙ', 'Ⓚ'};

        private string[] CraftingProfessions { get; } =
            {"Armouring", "Weaponsmithing", "Tailoring", "Woodworking", "Jeweling", "Cooking", "Scribing", "Alchemism"};

        private char[] CraftingIcons { get; } = {'Ⓗ', 'Ⓖ', 'Ⓕ', 'Ⓘ', 'Ⓓ', 'Ⓐ', 'Ⓔ', 'Ⓛ'};

        private char GetIcon(object i)
        {
            switch (_selectedNode.Tag)
            {
                case "gm":
                    return GamemodeIcons[Array.IndexOf(Gamemodes, (string) i)];
                case "gprof":
                    return GatheringIcons[Array.IndexOf(GatheringProfessions, (string) i)];
                case "cprof":
                    return CraftingIcons[Array.IndexOf(CraftingProfessions, (string) i)];
                default:
                    return (char) 0;
            }
        }

        private void CopyToClipboard(object i)
        {
            if (_selectedNode == null || i == null) return;
            Clipboard.SetText(GetIcon((string) i).ToString());
        }

        private void OnSelected(object i, object o)
        {
            var sender = (DarkTreeView) i;
            _selectedNode = sender.SelectedNodes.FirstOrDefault();
            string iconPath = null;
            try
            {
                tbPreview.Text = GetIcon(_selectedNode?.Text).ToString();
                iconPath = Path.Combine(Utils.App.ResFolder, "icons",
                    _selectedNode?.Tag.ToString().ToLower() ?? string.Empty,
                    _selectedNode?.Text.ToLower() + ".png");
                Logger.Log(iconPath, "PATH");
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException) Logger.Log($@"Icon not found: {iconPath}", "ERROR");
                Logger.Log(ex.ToString(), "EXCEPTION");
                previewer.BackgroundImage = null;
                return;
            }

            if (string.IsNullOrEmpty(_selectedNode?.Tag as string) || !File.Exists(iconPath) ||
                _selectedNode.Equals(null))
            {
                previewer.BackgroundImage = null;
                return;
            }

            var image = Image.FromFile(iconPath);
            previewer.BackgroundImage = image;
        }

        private void AddNodes()
        {
            _professionNode = new DarkTreeNode("Professions");
            _gamemodeNode = new DarkTreeNode("Gamemodes");
            _craftingProfessionNode = new DarkTreeNode("Crafting professions");
            _gatheringProfessionNode = new DarkTreeNode("Gathering professions");
            foreach (var gamemode in Gamemodes)
                _gamemodeNode.Nodes.Add(new DarkTreeNode(gamemode)
                {
                    Tag = "gm"
                });

            foreach (var prof in GatheringProfessions)
                _gatheringProfessionNode.Nodes.Add(new DarkTreeNode(prof)
                {
                    Tag = "gprof"
                });

            foreach (var prof in CraftingProfessions)
                _craftingProfessionNode.Nodes.Add(new DarkTreeNode(prof)
                {
                    Tag = "cprof"
                });
            _professionNode.Nodes.Add(_gatheringProfessionNode);
            _professionNode.Nodes.Add(_craftingProfessionNode);
            tree.Nodes.Add(_professionNode);
            tree.Nodes.Add(_gamemodeNode);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                CopyToClipboard(_selectedNode.Text);
            }
            catch (NullReferenceException ex)
            {
                Logger.Log(ex.ToString(), "EXCEPTION");
            }
        }
    }
}