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
                new Ghost("���", new List<string> { "���-5", "������ � ��������", "������������" }),
                new Ghost("�����", new List<string> { "���-5", "������������", "�������� ��������" }),
                new Ghost("������", new List<string> { "������������", "������������", "�������� ��������" }),
                new Ghost("�����������", new List<string> { "������������", "������������", "������ � ��������" }),
                new Ghost("�����", new List<string> { "������������", "���������� �����", "�������� ��������" }),
                new Ghost("�����", new List<string> { "���-5", "������������", "��������� �����������" }),
                new Ghost("����", new List<string> { "������������", "���������� �����", "������ � ��������" }),
                new Ghost("��������", new List<string> { "���������� �����", "������ � ��������", "��������� �����������" }),
                new Ghost("����", new List<string> { "���-5", "������ � ��������", "��������� �����������" }),
                new Ghost("�����", new List<string> { "������������", "������ � ��������", "��������� �����������" }),
                new Ghost("����", new List<string> { "���������� �����", "��������� �����������", "�������� ��������" }),
                new Ghost("���", new List<string> { "���-5", "��������� �����������", "�������� ��������" }),
                new Ghost("����", new List<string> { "������������", "���������� �����", "�������� ��������" }),
                new Ghost("�����", new List<string> { "������������", "���������� �����", "��������� �����������" }),
                new Ghost("���", new List<string> { "���-5", "������������", "�������� ��������" }),
                new Ghost("�������", new List<string> { "���-5", "������������", "������ � ��������" }),
                new Ghost("���", new List<string> { "������������", "���������� �����", "��������� �����������" }),
                new Ghost("��������", new List<string> { "���-5", "������������", "��������� �����������" }),
                new Ghost("������", new List<string> { "���-5", "���������� �����", "�������� ���������" }),
                new Ghost("�����", new List<string> { "���-5", "������������", "���������� �����" }),
                new Ghost("�����", new List<string> { "������������", "������������", "��������� �����������", "���������� �����" }),
                new Ghost("�����", new List<string> { "������������", "������ � ��������", "��������� �����������" }),
                new Ghost("������", new List<string> { "������������", "������ � ��������", "�������� ��������" }),
                new Ghost("����", new List<string> { "���������� �����", "������ � ��������", "" }),
            };
        }
        private void InitializeGhostDescriptions()
        {
            ghostDescriptions = new Dictionary<string, string>
            {
                { "���", "���� ��� �������������, �� �� �� c����� ��������� 3 ������." },
                { "�����", "����� ����������������� � ������ ����� ���� ���, � ����� ��������� � ���� � ������� (�� ������ � ������������� �������, ���������� �� ����� �������). �� ������� �� �������� � ����." },
                { "������", "���� �� ���� ��������, �������� ��������� �������. �� �������� � ����������, �� ������ ��� �� �������� ���� ������." },
                { "�����������","�� ����� ����� ���������������. ������ ����� ��������� � ����� �� ������� ����������, ����� ������ �����. ���������� � ������ ��������." },
                { "�����","� ������������ �������� ���� ���� ���������� ������. ��� ����� ������������� ������ �� �������� ��������� ������, � �� �� �����. ��������� ����� �� �������. � ��������� ���� ��� ���� ���� ����� �� ����, �������� ��� ������� �������. ����� ������������ �������� ����� �������� ������ ����." },
                { "�����","����� ��������� �������, �� ������ �������� ��������, ����� ��� ���� ������. �� ����� ������� ���������� �������� �����������. ���� ��������� �������� - ��������� ������������ ��������." },
                { "����", "����� �������. ������� ��� 60% ��������, ����� ���� � ������� ��������. ��� 40%, ����� �������." },
                { "��������", "�� ����� ���������, ����� �� ����� ������. ����� ����� - ����� �������." },
                { "����", "���������. ����� ��������� �� 35% �������� � ����, �� �� �������� �����, ����� ���-�� ��������� � ��� �������." },
                { "�����","�������� ����, ��� ������ �������� � ����� ������ ����� ���������� �� ������ ��������. ������ ������ �������� ��������." },
                { "����","��� ������� �� ����� ������ ������ ��������. ���� �������������, �� �������� ���������� ��������� �� ����." },
                { "���", "����� �������. �� ����� ����� ����� �� ��������. �� ����� ������� ������� �����." },
                { "����", "����� ������ ����� �� 80% ��������, ���� ������� � ��� �����. �� ����� ����� ����, ���� � ���� - �������� ������ ����������������� � �����������/������ ������." },
                { "�����", "�� ������ ����� �������, � ��������� ������ ���� - ���������. ����� �� ������ ����� ������� �������� ������� � ����� �������� (����� �� ��� � ������)." },
                { "���", "����� ����� ������ ���� ������� (����������� �������). ��� �������� �������� ����� ������ �� ������� + �� ��� �� �������, ���� � ������� ���������� � ��� �������." },
                { "�������", "����� ���� �����. ����� ����� ����� �������������� ����� � ������������ ���������." },
                { "���", "����� ������ ����� ��� �������� 60% � ����. �� ����� ������� ��� ����� ������ ��������, ���� ������ 3 �����." },
                { "��������", "�� ��������� ����. ���� �� ��� ���������, ��� ������ ��������, ������ - �������. ����� ����������������� � ������� ���������� (����� � � ������ ��������) ������������." },
                { "������", "����� ������ ����� �� 65% ��������, ���� ����� �������� ����������� (������ ������������ �������, ���� � ���� ��� ����������� � �� ����������� �� ���������). �� ���� ����������� �� �������� � ����������� ��������. �������� ������ ���������������� � ����������� ������." },
                { "�����", "����� ���� � 25% �� �������� ���������. ����� ����� ������ ���������� ��������� ����." },
                { "�����", "��������� �������� ��������� ������ ���������. ����� ���������� �����, ������� ��������� � ���� �� ������, � �������." },
                { "�����", "����� �������� - ���������, ���� �������� - ����� �������. ���������� �������� �� 45% �������� � ����. ��� ������ ����� ������������ ��� ��� ��������� ����� ������������ ��������� ����� ������� �� ������ ���������, ��� ������� � �������������� �������� ��������." },
                { "������","����� ��������� �� 40% �������� � ����. �� ���� ���������� ����������. �� ����� �����, ����� �� ����� ����, �� ������� ����� ���������� ��������� ���������, ��� �� ���� ����� ���� ������. ����� ������ ���� ������ ����� ������������." },
                { "����", "����� ������ ��������� �� 75% ��������, �� � ������� ���� �������. � ����� ������ ����� ������ ����� ������ ����� ���������� ������� ���� 15% ��������." },
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
            emf5.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("���-5"));
            spirit_box.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("������������"));
            uv.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("������������"));
            orbs.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("���������� �����"));
            writing.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("������ � ��������"));
            low_temp.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("��������� �����������"));
            dots.Enabled = ghosts.Any(ghost => ghost.Clues.Contains("�������� ��������"));
        }

        private void UpdateResultTextBox()
        {
            if (ghosts.Count == 1)
            {
                textBox1.Text = $"��� ��������: {ghosts[0].Name}";
                textBox2.Text = GetGhostDescription(ghosts[0].Name);
            }
            else if (ghosts.Count > 1)
            {
                textBox1.Text = "�������������� ��������:\r\n" + string.Join(", ", ghosts.Select(ghost => ghost.Name));
                textBox2.Text = string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
            }
            else
            {
                textBox1.Text = "��� ������� ����������";
                textBox2.Text = String.Empty;
            }
        }
        private void UpdateDescriptionTextBox()
        {
            textBox2.Text = string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
            // textBox2.Text = "����� ��������� ��������� ��������� ��� - bit.ly/phasmo_helper_ru \r\n\r\n" + string.Join("\r\n\r\n", ghosts.Select(ghost => $"{GetGhostDescription(ghost.Name)}"));
        }
        private string GetGhostDescription(string ghostName)
        {
            if (ghostDescriptions.ContainsKey(ghostName))
            {
                return $"�������� �������� {ghostName}:\r\n{ghostDescriptions[ghostName]}";
            }
            else
            {
                return $"�������� �������� {ghostName} �����������";
            }
        }

        private void emf5_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("���-5");
            UpdateButtonColor(emf5);
        }

        private void spirit_box_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("������������");
            UpdateButtonColor(spirit_box);
        }

        private void uv_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("������������");
            UpdateButtonColor(uv);
        }

        private void orbs_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("���������� �����");
            UpdateButtonColor(orbs);
        }

        private void writing_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("������ � ��������");
            UpdateButtonColor(writing);
        }

        private void low_temp_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("��������� �����������");
            UpdateButtonColor(low_temp);
        }

        private void dots_Click(object sender, EventArgs e)
        {
            HandleClueButtonClick("�������� ��������");
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
