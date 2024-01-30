using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace phasmo_helper
{
    public partial class Form1 : Form
    {
        private List<Ghost> ghosts;

        public Form1()
        {
            InitializeComponent();
            InitializeGhosts();
        }

        private void InitializeGhosts()
        {
            ghosts = new List<Ghost>
            {
                new Ghost("Дух", new List<string> { "ЭМП-5", "Записи в блокноте", "Радиоприёмник" }),
                new Ghost("Мираж", new List<string> { "ЭМП-5", "Радиоприёмник", "Лазерный проектор" }),
                new Ghost("Фантом", new List<string> { "Радиоприёмник", "Ультрафиолет", "Лазерный проектор" }),
                new Ghost("Полтергейст", new List<string> { "Радиоприёмник", "Ультрафиолет", "Записи в блокноте" }),
                new Ghost("Банши", new List<string> { "Ультрафиолет", "Призрачный огонёк", "Лазерный проектор" }),
                new Ghost("Джинн", new List<string> { "ЭМП-5", "Ультрафиолет", "Минусовая температура" }),
                new Ghost("Мара", new List<string> { "Радиоприёмник", "Призрачный огонёк", "Записи в блокноте" }),
                new Ghost("Ревенант", new List<string> { "Призрачный огонёк", "Записи в блокноте", "Минусовая температура" }),
                new Ghost("Тень", new List<string> { "ЭМП-5", "Записи в блокноте", "Минусовая температура" }),
                new Ghost("Демон", new List<string> { "Ультрафиолет", "Записи в блокноте", "Минусовая температура" }),
                new Ghost("Юрэй", new List<string> { "Призрачный огонёк", "Минусовая температура", "Лазерный проектор" }),
                new Ghost("Они", new List<string> { "ЭМП-5", "Минусовая температура", "Лазерный проектор" }),
                new Ghost("Ёкай", new List<string> { "Радиоприёмник", "Призрачный огонёк", "Лазерный проектор" }),
                new Ghost("Ханту", new List<string> { "Ультрафиолет", "Призрачный огонёк", "Минусовая температура" }),
                new Ghost("Горё", new List<string> { "ЭМП-5", "Ультрафиолет", "Лазерный проектор" }),
                new Ghost("Мюллинг", new List<string> { "ЭМП-5", "Ультрафиолет", "Записи в блокноте" }),
                new Ghost("Онрё", new List<string> { "Радиоприёмник", "Призрачный огонёк", "Минусовая температура" }),
                new Ghost("Близнецы", new List<string> { "ЭМП-5", "Радиоприёмник", "Минусовая температура" }),
                new Ghost("Райдзю", new List<string> { "ЭМП-5", "Призрачный огонёк", "Лазерный прожектор" }),
                new Ghost("Обакэ", new List<string> { "ЭМП-5", "Ультрафиолет", "Призрачный огонёк" }),
                new Ghost("Мимик", new List<string> { "Радиоприёмник", "Ультрафиолет", "Минусовая температура", "Призрачный огонёк" }),
                new Ghost("Морой", new List<string> { "Радиоприёмник", "Записи в блокноте", "Минусовая температура" }),
                new Ghost("Деоген", new List<string> { "Радиоприёмник", "Записи в блокноте", "Лазерный проектор" }),
                new Ghost("Тайэ", new List<string> { "Призрачный огонёк", "Записи в блокноте", "" }),
            };
        }

        private void HandleClueButtonClick(string clue)
        {
            ghosts = ghosts.Where(ghost => ghost.Clues.Contains(clue)).ToList();
            UpdateClueButtons();
            UpdateResultTextBox();
        }

        private void UpdateButtonColor(Button button)
        {
            button.BackColor = button.Enabled ? Color.LightSlateGray : Color.Gray;
        }

        private void UpdateClueButtons()
        {
            emf5.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("ЭМП-5"));
            spirit_box.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("Радиоприёмник"));
            uv.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("Ультрафиолет"));
            orbs.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("Призрачный огонёк"));
            writing.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("Записи в блокноте"));
            low_temp.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("Минусовая температура"));
            dots.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("Лазерный проектор"));

            //UpdateButtonColor(emf5);
            //UpdateButtonColor(spirit_box);
            //UpdateButtonColor(uv);
            //UpdateButtonColor(orbs);
            //UpdateButtonColor(writing);
            //UpdateButtonColor(low_temp);
            //UpdateButtonColor(dots);
        }

        private void UpdateResultTextBox()
        {
            if (ghosts.Count == 1)
            {
                textBox1.Text = $"Тип призрака: {ghosts[0].Name}";
            }
            else if (ghosts.Count > 1)
            {
                textBox1.Text = "Предполагаемые призраки:\r\n" + string.Join(", ", ghosts.Select(ghost => ghost.Name));
            }
            else
            {
                textBox1.Text = "Нет точного совпадения";
            }
        }

        private void emf5_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("ЭМП-5");
            UpdateButtonColor(emf5);
        }

        private void spirit_box_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Радиоприёмник");
            UpdateButtonColor(spirit_box);
        }

        private void uv_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Ультрафиолет");
            UpdateButtonColor(uv);
        }

        private void orbs_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Призрачный огонёк");
            UpdateButtonColor(orbs);
        }

        private void writing_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Записи в блокноте");
            UpdateButtonColor(writing);
        }

        private void low_temp_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Минусовая температура");
            UpdateButtonColor(low_temp);
        }

        private void dots_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("Лазерный проектор");
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
        }
    }

    public class Ghost
    {
        public string Name { get; set; }
        public List<string> Clues { get; set; }

        public Ghost(string name, List<string> clues)
        {
            Name = name;
            Clues = clues;
        }
    }
}
