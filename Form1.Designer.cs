namespace HMT
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.sectionGB = new System.Windows.Forms.GroupBox();
            this.logRB = new System.Windows.Forms.RadioButton();
            this.linkRB = new System.Windows.Forms.RadioButton();
            this.envGB = new System.Windows.Forms.GroupBox();
            this.intRB = new System.Windows.Forms.RadioButton();
            this.nextRB = new System.Windows.Forms.RadioButton();
            this.realRB = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.Label();
            this.resultButtonPane = new System.Windows.Forms.FlowLayoutPanel();
            this.screanshotButton = new System.Windows.Forms.Button();
            this.steepTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.sectionGB.SuspendLayout();
            this.envGB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.testTextBox);
            this.mainPanel.Controls.Add(this.sectionGB);
            this.mainPanel.Controls.Add(this.envGB);
            this.mainPanel.Controls.Add(this.resultTextBox);
            this.mainPanel.Controls.Add(this.resultButtonPane);
            this.mainPanel.Controls.Add(this.screanshotButton);
            this.mainPanel.Controls.Add(this.steepTextBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 437);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Tag = "mainPanel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите номер теста:";
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(153, 364);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(56, 23);
            this.testTextBox.TabIndex = 11;
            this.testTextBox.Tag = "steepTextBox";
            // 
            // sectionGB
            // 
            this.sectionGB.Controls.Add(this.logRB);
            this.sectionGB.Controls.Add(this.linkRB);
            this.sectionGB.Location = new System.Drawing.Point(111, 27);
            this.sectionGB.Name = "sectionGB";
            this.sectionGB.Size = new System.Drawing.Size(98, 82);
            this.sectionGB.TabIndex = 9;
            this.sectionGB.TabStop = false;
            this.sectionGB.Tag = "sectionGB";
            this.sectionGB.Text = "Раздел:";
            this.sectionGB.Visible = false;
            // 
            // logRB
            // 
            this.logRB.Location = new System.Drawing.Point(13, 49);
            this.logRB.Name = "logRB";
            this.logRB.Size = new System.Drawing.Size(79, 24);
            this.logRB.TabIndex = 2;
            this.logRB.TabStop = true;
            this.logRB.Tag = "logRB";
            this.logRB.Text = "Логи";
            this.logRB.UseVisualStyleBackColor = true;
            this.logRB.CheckedChanged += new System.EventHandler(this.sectionGB_mouseClick);
            // 
            // linkRB
            // 
            this.linkRB.Location = new System.Drawing.Point(13, 19);
            this.linkRB.Name = "linkRB";
            this.linkRB.Size = new System.Drawing.Size(79, 24);
            this.linkRB.TabIndex = 1;
            this.linkRB.TabStop = true;
            this.linkRB.Tag = "linkRB";
            this.linkRB.Text = "Ссылки";
            this.linkRB.UseVisualStyleBackColor = true;
            this.linkRB.CheckedChanged += new System.EventHandler(this.sectionGB_mouseClick);
            // 
            // envGB
            // 
            this.envGB.Controls.Add(this.intRB);
            this.envGB.Controls.Add(this.nextRB);
            this.envGB.Controls.Add(this.realRB);
            this.envGB.Location = new System.Drawing.Point(9, 27);
            this.envGB.Name = "envGB";
            this.envGB.Size = new System.Drawing.Size(96, 101);
            this.envGB.TabIndex = 8;
            this.envGB.TabStop = false;
            this.envGB.Tag = "envGB";
            this.envGB.Text = "Стенд:";
            // 
            // intRB
            // 
            this.intRB.Location = new System.Drawing.Point(6, 70);
            this.intRB.Name = "intRB";
            this.intRB.Size = new System.Drawing.Size(67, 24);
            this.intRB.TabIndex = 3;
            this.intRB.TabStop = true;
            this.intRB.Tag = "intRB";
            this.intRB.Text = "Int";
            this.intRB.UseVisualStyleBackColor = true;
            this.intRB.CheckedChanged += new System.EventHandler(this.eventGB_mouseClick);
            // 
            // nextRB
            // 
            this.nextRB.Location = new System.Drawing.Point(6, 15);
            this.nextRB.Name = "nextRB";
            this.nextRB.Size = new System.Drawing.Size(84, 24);
            this.nextRB.TabIndex = 1;
            this.nextRB.TabStop = true;
            this.nextRB.Tag = "nextRB";
            this.nextRB.Text = "Next";
            this.nextRB.UseVisualStyleBackColor = true;
            this.nextRB.CheckedChanged += new System.EventHandler(this.eventGB_mouseClick);
            // 
            // realRB
            // 
            this.realRB.AutoSize = true;
            this.realRB.Location = new System.Drawing.Point(6, 45);
            this.realRB.Name = "realRB";
            this.realRB.Size = new System.Drawing.Size(47, 19);
            this.realRB.TabIndex = 2;
            this.realRB.TabStop = true;
            this.realRB.Tag = "realRB";
            this.realRB.Text = "Real";
            this.realRB.UseVisualStyleBackColor = true;
            this.realRB.CheckedChanged += new System.EventHandler(this.eventGB_mouseClick);
            // 
            // resultTextBox
            // 
            this.resultTextBox.AutoSize = true;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(345, 388);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(0, 28);
            this.resultTextBox.TabIndex = 7;
            this.resultTextBox.Tag = "resultTextBox";
            // 
            // resultButtonPane
            // 
            this.resultButtonPane.Location = new System.Drawing.Point(329, 27);
            this.resultButtonPane.Name = "resultButtonPane";
            this.resultButtonPane.Size = new System.Drawing.Size(458, 303);
            this.resultButtonPane.TabIndex = 6;
            this.resultButtonPane.Tag = "resultButtonPane";
            // 
            // screanshotButton
            // 
            this.screanshotButton.Location = new System.Drawing.Point(238, 364);
            this.screanshotButton.Name = "screanshotButton";
            this.screanshotButton.Size = new System.Drawing.Size(75, 52);
            this.screanshotButton.TabIndex = 2;
            this.screanshotButton.Tag = "screanshotButton";
            this.screanshotButton.Text = "Скриншот";
            this.screanshotButton.UseVisualStyleBackColor = true;
            this.screanshotButton.Click += new System.EventHandler(this.screanshotButton_Click);
            // 
            // steepTextBox
            // 
            this.steepTextBox.Location = new System.Drawing.Point(153, 393);
            this.steepTextBox.Name = "steepTextBox";
            this.steepTextBox.Size = new System.Drawing.Size(56, 23);
            this.steepTextBox.TabIndex = 1;
            this.steepTextBox.Tag = "steepTextBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер шага:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HMT";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.sectionGB.ResumeLayout(false);
            this.envGB.ResumeLayout(false);
            this.envGB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Button screanshotButton;
        private TextBox steepTextBox;
        private RadioButton nextRB;
        private RadioButton realRB;
        private RadioButton intRB;
        private FlowLayoutPanel resultButtonPane;
        private RadioButton linkRB;
        private RadioButton logRB;
        private GroupBox sectionGB;
        private GroupBox envGB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        public Label resultTextBox;
        private TextBox testTextBox;
        private Label label2;
    }
}