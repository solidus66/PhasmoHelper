using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Policy;
using System.Windows.Forms;
using phasmo_helper.Resources;

namespace phasmo_helper
{
    public partial class Form1 : Form
    {
        private List<Ghost> ghosts;
        private List<GhostDescription> ghostDescriptions;

        public Form1()
        {
            InitializeComponent();
            InitializeGhosts();
            InitializeGhostDescriptions();
            UpdateDescriptionTextBox();
        }

        private void InitializeGhosts()
        {
            ghosts = new List<Ghost>
            {
                new Ghost(Resources.GhostResources.GhostName_Spirit, new List<string> { "EMF-5", "Ghost Writing", "Spirit Box" }),
                new Ghost(Resources.GhostResources.GhostName_Wraith, new List<string> { "EMF-5", "Spirit Box", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Phantom, new List<string> { "Spirit Box", "UV", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Poltergeist, new List<string> { "Spirit Box", "UV", "Ghost Writing" }),
                new Ghost(Resources.GhostResources.GhostName_Banshee, new List<string> { "UV", "Orb", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Jinn, new List<string> { "EMF-5", "UV", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Mare, new List<string> { "Spirit Box", "Orb", "Ghost Writing" }),
                new Ghost(Resources.GhostResources.GhostName_Revenant, new List<string> { "Orb", "Ghost Writing", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Shade, new List<string> { "EMF-5", "Ghost Writing", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Demon, new List<string> { "UV", "Ghost Writing", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Yurei, new List<string> { "Orb", "Freezing", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Oni, new List<string> { "EMF-5", "Freezing", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Yokai, new List<string> { "Spirit Box", "Orb", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Hantu, new List<string> { "UV", "Orb", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Goryo, new List<string> { "EMF-5", "UV", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Myling, new List<string> { "EMF-5", "UV", "Ghost Writing" }),
                new Ghost(Resources.GhostResources.GhostName_Onryo, new List<string> { "Spirit Box", "Orb", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_TheTwins, new List<string> { "EMF-5", "Spirit Box", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Raiju, new List<string> { "EMF-5", "Orb", "Лазерный прожектор" }),
                new Ghost(Resources.GhostResources.GhostName_Obake, new List<string> { "EMF-5", "UV", "Orb" }),
                new Ghost(Resources.GhostResources.GhostName_TheMimic, new List<string> { "Spirit Box", "UV", "Freezing", "Orb" }),
                new Ghost(Resources.GhostResources.GhostName_Moroi, new List<string> { "Spirit Box", "Ghost Writing", "Freezing" }),
                new Ghost(Resources.GhostResources.GhostName_Deogen, new List<string> { "Spirit Box", "Ghost Writing", "DOTS" }),
                new Ghost(Resources.GhostResources.GhostName_Thaye, new List<string> { "Orb", "Ghost Writing", "DOTS" }),
            };
        }
        private void InitializeGhostDescriptions()
        {
            ghostDescriptions = new List<GhostDescription>
            {
                new GhostDescription(Resources.GhostResources.GhostName_Spirit, Resources.DescriptionResources.Description_Spirit),
                new GhostDescription(Resources.GhostResources.GhostName_Wraith, Resources.DescriptionResources.Description_Wraith),
                new GhostDescription(Resources.GhostResources.GhostName_Phantom, Resources.DescriptionResources.Description_Phantom),
                new GhostDescription(Resources.GhostResources.GhostName_Poltergeist, Resources.DescriptionResources.Description_Poltergeist),
                new GhostDescription(Resources.GhostResources.GhostName_Banshee, Resources.DescriptionResources.Description_Banshee),
                new GhostDescription(Resources.GhostResources.GhostName_Jinn, Resources.DescriptionResources.Description_Jinn),
                new GhostDescription(Resources.GhostResources.GhostName_Mare, Resources.DescriptionResources.Description_Mare),
                new GhostDescription(Resources.GhostResources.GhostName_Revenant, Resources.DescriptionResources.Description_Revenant),
                new GhostDescription(Resources.GhostResources.GhostName_Shade, Resources.DescriptionResources.Description_Shade),
                new GhostDescription(Resources.GhostResources.GhostName_Demon, Resources.DescriptionResources.Description_Demon),
                new GhostDescription(Resources.GhostResources.GhostName_Yurei, Resources.DescriptionResources.Description_Yurei),
                new GhostDescription(Resources.GhostResources.GhostName_Oni, Resources.DescriptionResources.Description_Oni),
                new GhostDescription(Resources.GhostResources.GhostName_Yokai, Resources.DescriptionResources.Description_Yokai),
                new GhostDescription(Resources.GhostResources.GhostName_Hantu, Resources.DescriptionResources.Description_Hantu),
                new GhostDescription(Resources.GhostResources.GhostName_Goryo, Resources.DescriptionResources.Description_Goryo),
                new GhostDescription(Resources.GhostResources.GhostName_Myling, Resources.DescriptionResources.Description_Myling),
                new GhostDescription(Resources.GhostResources.GhostName_Onryo, Resources.DescriptionResources.Description_Onryo),
                new GhostDescription(Resources.GhostResources.GhostName_TheTwins, Resources.DescriptionResources.Description_TheTwins),
                new GhostDescription(Resources.GhostResources.GhostName_Raiju, Resources.DescriptionResources.Description_Raiju),
                new GhostDescription(Resources.GhostResources.GhostName_Obake, Resources.DescriptionResources.Description_Obake),
                new GhostDescription(Resources.GhostResources.GhostName_TheMimic, Resources.DescriptionResources.Description_TheMimic),
                new GhostDescription(Resources.GhostResources.GhostName_Moroi, Resources.DescriptionResources.Description_Moroi),
                new GhostDescription(Resources.GhostResources.GhostName_Deogen, Resources.DescriptionResources.Description_Deogen),
                new GhostDescription(Resources.GhostResources.GhostName_Thaye, Resources.DescriptionResources.Description_Thaye),
            };
        }

        private void HandleClueButtonClick(string evidence)
        {
            ghosts = ghosts.Where(ghost => ghost.Evidence.Contains(evidence)).ToList();
            UpdateClueButtons();
            UpdateResultTextBox();
        }

        private void UpdateButtonColor(Button button)
        {
            button.BackColor = button.Enabled ? Color.LightSlateGray : Color.Gray;
        }

        private void UpdateClueButtons()
        {
            emf5.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("EMF-5"));
            spirit_box.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("Spirit Box"));
            uv.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("UV"));
            orbs.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("Orb"));
            writing.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("Ghost Writing"));
            low_temp.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("Freezing"));
            dots.Enabled = ghosts.Any(ghost => ghost.Evidence.Contains("DOTS"));
        }

        private void UpdateResultTextBox()
        {
            if (ghosts.Count == 1)
            {
                textBox1.Text = Resources.PhrasesResource.Ghost_Type + string.Join(", ", ghosts.Select(ghost => ghost.Name));
                textBox2.Text = GetGhostDescription(ghosts[0].Name);
            }
            else if (ghosts.Count > 1)
            {
                textBox1.Text = Resources.PhrasesResource.Possible_Ghost + string.Join(", ", ghosts.Select(ghost => ghost.Name));
                textBox2.Text = string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
            }
            else
            {
                textBox1.Text = Resources.PhrasesResource.No_Match;
                textBox2.Text = String.Empty;
            }
        }
        private void UpdateDescriptionTextBox()
        {
            textBox2.Text = string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
            // textBox2.Text = "Более подробная шпаргалка находится тут - bit.ly/phasmo_helper_ru \r\n\r\n" + string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
        }
        private string GetGhostDescription(string ghostName)
        {
            GhostDescription ghost = ghostDescriptions.Find(g => g.Name == ghostName);

            if (ghost != null)
            {
                return Resources.PhrasesResource.Description + ghostName + $":\r\n{ghost.Description}";
            }
            else
            {
                return Resources.PhrasesResource.No_Description + ghostName;
            }
        }


        private void emf5_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("EMF-5");
            UpdateButtonColor(emf5);
        }

        private void spirit_box_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Spirit Box");
            UpdateButtonColor(spirit_box);
        }

        private void uv_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("UV");
            UpdateButtonColor(uv);
        }

        private void orbs_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Orb");
            UpdateButtonColor(orbs);
        }

        private void writing_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Ghost Writing");
            UpdateButtonColor(writing);
        }

        private void low_temp_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Freezing");
            UpdateButtonColor(low_temp);
        }

        private void dots_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("DOTS");
            UpdateButtonColor(dots);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            emf5.Enabled = true;
            spirit_box.Enabled = true;
            uv.Enabled = true;
            orbs.Enabled = true;
            writing.Enabled = true;
            low_temp.Enabled = true;
            dots.Enabled = true;

            emf5.BackColor = SystemColors.Control;
            spirit_box.BackColor = SystemColors.Control;
            uv.BackColor = SystemColors.Control;
            orbs.BackColor = SystemColors.Control;
            writing.BackColor = SystemColors.Control;
            low_temp.BackColor = SystemColors.Control;
            dots.BackColor = SystemColors.Control;

            textBox1.Text = String.Empty;
            InitializeGhosts();
            UpdateDescriptionTextBox();
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("rus");
            this.Controls.Clear();
            this.clear_button_Click(sender, e);
            InitializeComponent();
            InitializeGhostDescriptions();
            UpdateDescriptionTextBox();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            this.clear_button_Click(sender, e);
            InitializeComponent();
            InitializeGhostDescriptions();
            UpdateDescriptionTextBox();
        }
    }

    public class Ghost
    {
        public string Name { get; set; }
        public List<string> Evidence { get; set; }

        public Ghost(string ghostName, List<string> evidence)
        {
            Name = ghostName;
            Evidence = evidence;
        }
    }
    public class GhostDescription
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public GhostDescription(string ghostName, string description)
        {
            Name = ghostName;
            Description = description;
        }
    }
}