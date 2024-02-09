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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            menuStrip1 = new MenuStrip();
            languageToolStripMenuItem = new ToolStripMenuItem();
            russianToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // emf5
            // 
            resources.ApplyResources(emf5, "emf5");
            emf5.Name = "emf5";
            emf5.UseVisualStyleBackColor = true;
            emf5.Click += emf5_Click;
            // 
            // spirit_box
            // 
            resources.ApplyResources(spirit_box, "spirit_box");
            spirit_box.Name = "spirit_box";
            spirit_box.UseVisualStyleBackColor = true;
            spirit_box.Click += spirit_box_Click;
            // 
            // uv
            // 
            resources.ApplyResources(uv, "uv");
            uv.Name = "uv";
            uv.UseVisualStyleBackColor = true;
            uv.Click += uv_Click;
            // 
            // orbs
            // 
            resources.ApplyResources(orbs, "orbs");
            orbs.Name = "orbs";
            orbs.UseVisualStyleBackColor = true;
            orbs.Click += orbs_Click;
            // 
            // writing
            // 
            resources.ApplyResources(writing, "writing");
            writing.Name = "writing";
            writing.UseVisualStyleBackColor = true;
            writing.Click += writing_Click;
            // 
            // low_temp
            // 
            resources.ApplyResources(low_temp, "low_temp");
            low_temp.Name = "low_temp";
            low_temp.UseVisualStyleBackColor = true;
            low_temp.Click += low_temp_Click;
            // 
            // dots
            // 
            resources.ApplyResources(dots, "dots");
            dots.Name = "dots";
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
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            // 
            // clear_button
            // 
            resources.ApplyResources(clear_button, "clear_button");
            clear_button.Name = "clear_button";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(clear_button);
            tabPage1.Controls.Add(textBox1);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.BackColor = SystemColors.ControlLight;
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { russianToolStripMenuItem, englishToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // russianToolStripMenuItem
            // 
            russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(russianToolStripMenuItem, "russianToolStripMenuItem");
            russianToolStripMenuItem.Click += russianToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(englishToolStripMenuItem, "englishToolStripMenuItem");
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(this, "$this");
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem russianToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
    }
}