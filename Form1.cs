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
                textBox1.Text = $"��� ��������: {ghosts[0].Name}";
            }
            else if (ghosts.Count > 1)
            {
                textBox1.Text = "�������������� ��������:\r\n" + string.Join(", ", ghosts.Select(ghost => ghost.Name));
            }
            else
            {
                textBox1.Text = "��� ������� ����������";
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
