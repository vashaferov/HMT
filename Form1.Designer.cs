﻿namespace HMT
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
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.steepTextBox = new System.Windows.Forms.TextBox();
            this.screanshotButton = new System.Windows.Forms.Button();
            this.resultButtonPane = new System.Windows.Forms.FlowLayoutPanel();
            this.resultTextBox = new System.Windows.Forms.Label();
            this.envGB = new System.Windows.Forms.GroupBox();
            this.intRB = new System.Windows.Forms.RadioButton();
            this.nextRB = new System.Windows.Forms.RadioButton();
            this.realRB = new System.Windows.Forms.RadioButton();
            this.sectionGB = new System.Windows.Forms.GroupBox();
            this.logRB = new System.Windows.Forms.RadioButton();
            this.linkRB = new System.Windows.Forms.RadioButton();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.envGB.SuspendLayout();
            this.sectionGB.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Выбор нового элемента";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(522, 24);
            this.miniToolStrip.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер шага:";
            // 
            // steepTextBox
            // 
            this.steepTextBox.Location = new System.Drawing.Point(138, 291);
            this.steepTextBox.Name = "steepTextBox";
            this.steepTextBox.Size = new System.Drawing.Size(56, 23);
            this.steepTextBox.TabIndex = 1;
            this.steepTextBox.Tag = "steepTextBox";
            // 
            // screanshotButton
            // 
            this.screanshotButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screanshotButton.Location = new System.Drawing.Point(200, 262);
            this.screanshotButton.Name = "screanshotButton";
            this.screanshotButton.Size = new System.Drawing.Size(75, 52);
            this.screanshotButton.TabIndex = 2;
            this.screanshotButton.Tag = "screanshotButton";
            this.screanshotButton.Text = "Скриншот";
            this.screanshotButton.UseVisualStyleBackColor = true;
            this.screanshotButton.Click += new System.EventHandler(this.screanshotButton_Click);
            // 
            // resultButtonPane
            // 
            this.resultButtonPane.Location = new System.Drawing.Point(134, 27);
            this.resultButtonPane.Name = "resultButtonPane";
            this.resultButtonPane.Size = new System.Drawing.Size(385, 206);
            this.resultButtonPane.TabIndex = 6;
            this.resultButtonPane.Tag = "resultButtonPane";
            // 
            // resultTextBox
            // 
            this.resultTextBox.AutoSize = true;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(281, 301);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(0, 13);
            this.resultTextBox.TabIndex = 7;
            this.resultTextBox.Tag = "resultTextBox";
            // 
            // envGB
            // 
            this.envGB.Controls.Add(this.intRB);
            this.envGB.Controls.Add(this.nextRB);
            this.envGB.Controls.Add(this.realRB);
            this.envGB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // sectionGB
            // 
            this.sectionGB.Controls.Add(this.logRB);
            this.sectionGB.Controls.Add(this.linkRB);
            this.sectionGB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sectionGB.Location = new System.Drawing.Point(9, 134);
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
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(138, 262);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(56, 23);
            this.testTextBox.TabIndex = 11;
            this.testTextBox.Tag = "steepTextBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите номер теста:";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.testTextBox);
            this.mainPanel.Controls.Add(this.sectionGB);
            this.mainPanel.Controls.Add(this.envGB);
            this.mainPanel.Controls.Add(this.resultTextBox);
            this.mainPanel.Controls.Add(this.resultButtonPane);
            this.mainPanel.Controls.Add(this.screanshotButton);
            this.mainPanel.Controls.Add(this.steepTextBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.menuStrip2);
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(530, 334);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Tag = "mainPanel";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(530, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 333);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.miniToolStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMT";
            this.envGB.ResumeLayout(false);
            this.envGB.PerformLayout();
            this.sectionGB.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip miniToolStrip;
        private Label label1;
        private TextBox steepTextBox;
        private Button screanshotButton;
        private FlowLayoutPanel resultButtonPane;
        public Label resultTextBox;
        private GroupBox envGB;
        private RadioButton intRB;
        private RadioButton nextRB;
        private RadioButton realRB;
        private GroupBox sectionGB;
        private RadioButton logRB;
        private RadioButton linkRB;
        private TextBox testTextBox;
        private Label label2;
        private Panel mainPanel;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem настройкиToolStripMenuItem1;
    }
}