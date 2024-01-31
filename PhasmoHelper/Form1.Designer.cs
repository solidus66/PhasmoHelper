namespace phasmo_helper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emf5 = new Button();
            spirit_box = new Button();
            uv = new Button();
            orbs = new Button();
            writing = new Button();
            low_temp = new Button();
            dots = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            clear_button = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // emf5
            // 
            emf5.Location = new Point(88, 16);
            emf5.Name = "emf5";
            emf5.Size = new Size(140, 48);
            emf5.TabIndex = 0;
            emf5.Text = "ЭМП-5";
            emf5.UseVisualStyleBackColor = true;
            emf5.Click += emf5_Click;
            // 
            // spirit_box
            // 
            spirit_box.Location = new Point(248, 16);
            spirit_box.Name = "spirit_box";
            spirit_box.Size = new Size(140, 48);
            spirit_box.TabIndex = 1;
            spirit_box.Text = "Радиоприёмник";
            spirit_box.UseVisualStyleBackColor = true;
            spirit_box.Click += spirit_box_Click;
            // 
            // uv
            // 
            uv.Location = new Point(408, 16);
            uv.Name = "uv";
            uv.Size = new Size(140, 48);
            uv.TabIndex = 2;
            uv.Text = "Ультрафиолет";
            uv.UseVisualStyleBackColor = true;
            uv.Click += uv_Click;
            // 
            // orbs
            // 
            orbs.Location = new Point(568, 16);
            orbs.Name = "orbs";
            orbs.Size = new Size(140, 48);
            orbs.TabIndex = 3;
            orbs.Text = "Призрачный огонёк";
            orbs.UseVisualStyleBackColor = true;
            orbs.Click += orbs_Click;
            // 
            // writing
            // 
            writing.Location = new Point(160, 80);
            writing.Name = "writing";
            writing.Size = new Size(140, 48);
            writing.TabIndex = 4;
            writing.Text = "Записи в блокноте";
            writing.UseVisualStyleBackColor = true;
            writing.Click += writing_Click;
            // 
            // low_temp
            // 
            low_temp.Location = new Point(328, 80);
            low_temp.Name = "low_temp";
            low_temp.Size = new Size(140, 48);
            low_temp.TabIndex = 5;
            low_temp.Text = "Минусовая температура";
            low_temp.UseVisualStyleBackColor = true;
            low_temp.Click += low_temp_Click;
            // 
            // dots
            // 
            dots.Location = new Point(496, 80);
            dots.Name = "dots";
            dots.Size = new Size(140, 48);
            dots.TabIndex = 6;
            dots.Text = "Лазерный проектор";
            dots.UseVisualStyleBackColor = true;
            dots.Click += dots_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(orbs);
            panel1.Controls.Add(dots);
            panel1.Controls.Add(emf5);
            panel1.Controls.Add(low_temp);
            panel1.Controls.Add(spirit_box);
            panel1.Controls.Add(writing);
            panel1.Controls.Add(uv);
            panel1.Location = new Point(0, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 144);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(160, 192);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(496, 64);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(336, 272);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(140, 48);
            clear_button.TabIndex = 9;
            clear_button.Text = "Сбросить";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(clear_button);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(792, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Улики";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 415);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Описания";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(792, 424);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Name = "Form1";
            Text = "Phasmo Helper";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button emf5;
        private Button spirit_box;
        private Button uv;
        private Button orbs;
        private Button writing;
        private Button low_temp;
        private Button dots;
        private Panel panel1;
        private TextBox textBox1;
        private Button clear_button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2;
    }
}