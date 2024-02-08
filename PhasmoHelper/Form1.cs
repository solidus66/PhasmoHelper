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
        private Dictionary<string, string> ghostDescriptions;

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
        private void InitializeGhostDescriptions()
        {
            ghostDescriptions = new Dictionary<string, string>
            {
                { "Дух", "Если его заблаговонять, то он не cможет охотиться 3 минуты." },
                { "Мираж", "Может телепортироваться к игрогу через весь дом, а затем вернуться к себе в комнату (не путать с телепортацией ивентом, неподалеку от своей комнаты). Он никогда не наступит в соль." },
                { "Фантом", "Если на него смотреть, рассудок понжается быстрее. Он исчезает с фотографий, но делает это не прерывая звук ивента." },
                { "Полтергейст","Он очень много взаимодействует. Кидает много предметов и порой на большие расстояния, часто дёргает двери. Бесполезен в пустых комнатах." },
                { "Банши","В мультиплеере выбирает себе одну конкретную жертву. При атаке ориентируется только на рассудок выбранной жертвы, а не на общий. Постоянно ходит за жертвой. В одиночной игре или если цель вышла из дома, работает как обычный призрак. Через Направленный Микрофон можно услышать особый крик." },
                { "Джинн","Когда генератор включен, он сильно повышает скорость, когда его цель далеко. На более близком расстоянии скорость уменьшается. Если генератор отключен - поведение стандартного призрака." },
                { "Мара", "Любит темноту. Атакует при 60% рассудка, когда свет в комнате выключен. При 40%, когда включен." },
                { "Ревенант", "Он очень медленный, когда не видит игрока. Когда видит - очень быстрый." },
                { "Тень", "Стесняшка. Может охотиться от 35% рассудка и ниже, но не начинает охоту, когда кто-то находится в его комнате." },
                { "Демон","Охотится чаще, чем другие призраки и может начать охоту независимо от уровня рассудка. Радиус работы распятия увеличен." },
                { "Юрэй","При ивентах он очень сильно сажает рассудок. Если заблаговонять, то временно перестанет слоняться по дому." },
                { "Они", "Очень активен. Во время охоты почти не исчезает. Не может сделать шаровой ивент." },
                { "Ёкай", "Может начать охоту от 80% рассудка, если болтать с ним рядом. Во время охоты глух, глуп и слеп - уменьшен радиус чувствивтельности к электронике/звукам игрока." },
                { "Ханту", "На холоде ходит быстрее, в прогретых частях дома - медленнее. Также на холоде можно увидеть морозное дыхание у этого призрака (такое же как у игрока)." },
                { "Горё", "Очень редко меняет свою комнату (практически никогда). Его Лазерный Проектор видим только на камерах + он его не покажет, если с камерой находиться в его комнате." },
                { "Мюллинг", "Очень тихо ходит. Более часто издаёт паранормальные звуки в Направленном Микрофоне." },
                { "Онрё", "Может начать охоту при рассудке 60% и ниже. Но также атакует при любом уровне рассудка, если задует 3 свечи." },
                { "Близнецы", "Их буквально двое. Один из них медленнее, чем другие призраки, другой - быстрее. Могут взаимодействовать с разными предметами (порой и в разных комнатах) одновременно." },
                { "Райдзю", "Может начать охоту от 65% рассудка, если рядом включена электроника (только оборудование игроков, свет в доме или находящаяся в нём электроника не считается). От этой электроники он питается и увеличивает скорость. Увеличен радиус чувствительности к электронике игрока." },
                { "Обакэ", "Имеет шанс в 25% не оставить отпечатки. Также имеет особый шестипалый отпечаток руки." },
                { "Мимик", "Полностью копирует поведение других призраков. Имеет Призрачный Огонёк, который считается у него не уликой, а абилкой." },
                { "Морой", "Много рассудка - медленный, мало рассудка - очень быстрый. Ускоряться начинает от 45% рассудка и ниже. При ответе через радиоприёмник или при разговоре через направленный миркрофон может наслать на игрока проклятие, что приведёт к стремительному снижению рассудка." },
                { "Деоген","Может охотиться от 40% рассудка и ниже. От него невозможно спрятаться. Он очень быстр, когда не видит цель, но подходя ближе становится медленным настолько, что от него можно уйти пешком. Имеет особый звук ответа через радиоприёмник." },
                { "Тайэ", "Может начать озотиться от 75% рассудка, но в течение игры стареет. В конце концов может начать охоту только после достижения отметки ниже 15% рассудка." },
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
        }

        private void UpdateResultTextBox()
        {
            if (ghosts.Count == 1)
            {
                textBox1.Text = $"Тип призрака: {ghosts[0].Name}";
                textBox2.Text = GetGhostDescription(ghosts[0].Name);
            }
            else if (ghosts.Count > 1)
            {
                textBox1.Text = "Предполагаемые призраки:\r\n" + string.Join(", ", ghosts.Select(ghost => ghost.Name));
                textBox2.Text = string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
            }
            else
            {
                textBox1.Text = "Нет точного совпадения";
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
            if (ghostDescriptions.ContainsKey(ghostName))
            {
                return $"Описание призрака {ghostName}:\r\n{ghostDescriptions[ghostName]}";
            }
            else
            {
                return $"Описание призрака {ghostName} отсутствует";
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
            UpdateDescriptionTextBox();
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("rus");
            this.Controls.Clear();
            this.clear_button_Click(sender, e);
            InitializeComponent();
            UpdateDescriptionTextBox();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            this.clear_button_Click(sender, e);
            InitializeComponent();
            UpdateDescriptionTextBox();
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
