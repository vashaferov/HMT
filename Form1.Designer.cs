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
            miniToolStrip = new MenuStrip();
            menuStrip2 = new MenuStrip();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            настройкиToolStripMenuItem1 = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            добавлениеToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            компактныйтолькоСкриншотыToolStripMenuItem = new ToolStripMenuItem();
            учетВремениToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            steepTextBox = new TextBox();
            screanshotButton = new Button();
            resultButtonPane = new FlowLayoutPanel();
            resultTextBox = new Label();
            envGB = new GroupBox();
            intRB = new RadioButton();
            nextRB = new RadioButton();
            realRB = new RadioButton();
            sectionGB = new GroupBox();
            logRB = new RadioButton();
            linkRB = new RadioButton();
            testTextBox = new TextBox();
            label2 = new Label();
            timerCB = new CheckBox();
            browserGB = new GroupBox();
            chromeRB = new RadioButton();
            IEexplorerRB = new RadioButton();
            linkToPaint = new LinkLabel();
            zipButton = new Button();
            mainPanel = new Panel();
            lastScreenLabel = new Label();
            pictureBox1 = new PictureBox();
            mailButton = new Button();
            menuStrip2.SuspendLayout();
            envGB.SuspendLayout();
            sectionGB.SuspendLayout();
            browserGB.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Выбор нового элемента";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Location = new Point(0, 0);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(522, 24);
            miniToolStrip.TabIndex = 10;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem1, добавлениеToolStripMenuItem, видToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(616, 24);
            menuStrip2.TabIndex = 13;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem1, справкаToolStripMenuItem });
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(48, 20);
            файлToolStripMenuItem1.Text = "Файл";
            // 
            // настройкиToolStripMenuItem1
            // 
            настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            настройкиToolStripMenuItem1.Size = new Size(134, 22);
            настройкиToolStripMenuItem1.Text = "Настройки";
            настройкиToolStripMenuItem1.Click += настройкиToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(134, 22);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // добавлениеToolStripMenuItem
            // 
            добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            добавлениеToolStripMenuItem.Size = new Size(130, 20);
            добавлениеToolStripMenuItem.Text = "Добавление ссылок";
            добавлениеToolStripMenuItem.Click += добавлениеToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { компактныйтолькоСкриншотыToolStripMenuItem, учетВремениToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // компактныйтолькоСкриншотыToolStripMenuItem
            // 
            компактныйтолькоСкриншотыToolStripMenuItem.Name = "компактныйтолькоСкриншотыToolStripMenuItem";
            компактныйтолькоСкриншотыToolStripMenuItem.Size = new Size(261, 22);
            компактныйтолькоСкриншотыToolStripMenuItem.Text = "Компактный (только скриншоты)";
            компактныйтолькоСкриншотыToolStripMenuItem.Click += компактныйтолькоСкриншотыToolStripMenuItem_Click;
            // 
            // учетВремениToolStripMenuItem
            // 
            учетВремениToolStripMenuItem.Name = "учетВремениToolStripMenuItem";
            учетВремениToolStripMenuItem.Size = new Size(261, 22);
            учетВремениToolStripMenuItem.Text = "Учет времени";
            учетВремениToolStripMenuItem.Click += учетВремениToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 298);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите номер шага:";
            // 
            // steepTextBox
            // 
            steepTextBox.Location = new Point(136, 295);
            steepTextBox.Name = "steepTextBox";
            steepTextBox.Size = new Size(56, 23);
            steepTextBox.TabIndex = 1;
            steepTextBox.Tag = "steepTextBox";
            // 
            // screanshotButton
            // 
            screanshotButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            screanshotButton.Location = new Point(198, 266);
            screanshotButton.Name = "screanshotButton";
            screanshotButton.Size = new Size(92, 52);
            screanshotButton.TabIndex = 2;
            screanshotButton.Tag = "screanshotButton";
            screanshotButton.Text = "Скриншот";
            screanshotButton.UseVisualStyleBackColor = true;
            screanshotButton.Click += screanshotButton_Click;
            // 
            // resultButtonPane
            // 
            resultButtonPane.Location = new Point(113, 27);
            resultButtonPane.Name = "resultButtonPane";
            resultButtonPane.Size = new Size(492, 182);
            resultButtonPane.TabIndex = 6;
            resultButtonPane.Tag = "resultButtonPane";
            // 
            // resultTextBox
            // 
            resultTextBox.AutoSize = true;
            resultTextBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            resultTextBox.Location = new Point(297, 331);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(0, 13);
            resultTextBox.TabIndex = 7;
            resultTextBox.Tag = "resultTextBox";
            // 
            // envGB
            // 
            envGB.Controls.Add(intRB);
            envGB.Controls.Add(nextRB);
            envGB.Controls.Add(realRB);
            envGB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            envGB.Location = new Point(9, 27);
            envGB.Name = "envGB";
            envGB.Size = new Size(96, 101);
            envGB.TabIndex = 8;
            envGB.TabStop = false;
            envGB.Tag = "envGB";
            envGB.Text = "Стенд:";
            // 
            // intRB
            // 
            intRB.Location = new Point(6, 70);
            intRB.Name = "intRB";
            intRB.Size = new Size(67, 24);
            intRB.TabIndex = 3;
            intRB.TabStop = true;
            intRB.Tag = "intRB";
            intRB.Text = "Int";
            intRB.UseVisualStyleBackColor = true;
            intRB.CheckedChanged += eventGB_mouseClick;
            // 
            // nextRB
            // 
            nextRB.Location = new Point(6, 15);
            nextRB.Name = "nextRB";
            nextRB.Size = new Size(84, 24);
            nextRB.TabIndex = 1;
            nextRB.TabStop = true;
            nextRB.Tag = "nextRB";
            nextRB.Text = "Next";
            nextRB.UseVisualStyleBackColor = true;
            nextRB.CheckedChanged += eventGB_mouseClick;
            // 
            // realRB
            // 
            realRB.AutoSize = true;
            realRB.Location = new Point(6, 45);
            realRB.Name = "realRB";
            realRB.Size = new Size(47, 19);
            realRB.TabIndex = 2;
            realRB.TabStop = true;
            realRB.Tag = "realRB";
            realRB.Text = "Real";
            realRB.UseVisualStyleBackColor = true;
            realRB.CheckedChanged += eventGB_mouseClick;
            // 
            // sectionGB
            // 
            sectionGB.Controls.Add(logRB);
            sectionGB.Controls.Add(linkRB);
            sectionGB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sectionGB.Location = new Point(9, 127);
            sectionGB.Name = "sectionGB";
            sectionGB.Size = new Size(98, 82);
            sectionGB.TabIndex = 9;
            sectionGB.TabStop = false;
            sectionGB.Tag = "sectionGB";
            sectionGB.Text = "Раздел:";
            sectionGB.Visible = false;
            // 
            // logRB
            // 
            logRB.Location = new Point(6, 49);
            logRB.Name = "logRB";
            logRB.Size = new Size(79, 24);
            logRB.TabIndex = 2;
            logRB.TabStop = true;
            logRB.Tag = "logRB";
            logRB.Text = "Логи";
            logRB.UseVisualStyleBackColor = true;
            logRB.CheckedChanged += sectionGB_mouseClick;
            // 
            // linkRB
            // 
            linkRB.Location = new Point(6, 19);
            linkRB.Name = "linkRB";
            linkRB.Size = new Size(79, 24);
            linkRB.TabIndex = 1;
            linkRB.TabStop = true;
            linkRB.Tag = "linkRB";
            linkRB.Text = "Ссылки";
            linkRB.UseVisualStyleBackColor = true;
            linkRB.CheckedChanged += sectionGB_mouseClick;
            // 
            // testTextBox
            // 
            testTextBox.Location = new Point(136, 266);
            testTextBox.Name = "testTextBox";
            testTextBox.Size = new Size(56, 23);
            testTextBox.TabIndex = 11;
            testTextBox.Tag = "steepTextBox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 269);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 12;
            label2.Text = "Введите номер теста:";
            // 
            // timerCB
            // 
            timerCB.AutoSize = true;
            timerCB.Location = new Point(11, 324);
            timerCB.Name = "timerCB";
            timerCB.Size = new Size(180, 19);
            timerCB.TabIndex = 14;
            timerCB.Text = "Установить таймер 5 секунд";
            timerCB.UseVisualStyleBackColor = true;
            // 
            // browserGB
            // 
            browserGB.Controls.Add(chromeRB);
            browserGB.Controls.Add(IEexplorerRB);
            browserGB.Location = new Point(9, 215);
            browserGB.Name = "browserGB";
            browserGB.Size = new Size(206, 44);
            browserGB.TabIndex = 15;
            browserGB.TabStop = false;
            browserGB.Text = "Выбор браузера:";
            browserGB.Visible = false;
            // 
            // chromeRB
            // 
            chromeRB.AutoSize = true;
            chromeRB.Location = new Point(123, 19);
            chromeRB.Name = "chromeRB";
            chromeRB.Size = new Size(68, 19);
            chromeRB.TabIndex = 1;
            chromeRB.TabStop = true;
            chromeRB.Text = "Chrome";
            chromeRB.UseVisualStyleBackColor = true;
            // 
            // IEexplorerRB
            // 
            IEexplorerRB.AutoSize = true;
            IEexplorerRB.Location = new Point(6, 19);
            IEexplorerRB.Name = "IEexplorerRB";
            IEexplorerRB.Size = new Size(112, 19);
            IEexplorerRB.TabIndex = 0;
            IEexplorerRB.TabStop = true;
            IEexplorerRB.Text = "Internet Explorer";
            IEexplorerRB.UseVisualStyleBackColor = true;
            // 
            // linkToPaint
            // 
            linkToPaint.AutoSize = true;
            linkToPaint.Location = new Point(348, 236);
            linkToPaint.Name = "linkToPaint";
            linkToPaint.Size = new Size(93, 15);
            linkToPaint.TabIndex = 16;
            linkToPaint.TabStop = true;
            linkToPaint.Text = "Открыть в Paint";
            linkToPaint.Visible = false;
            linkToPaint.LinkClicked += linkLabel1_LinkClicked;
            // 
            // zipButton
            // 
            zipButton.Location = new Point(198, 323);
            zipButton.Name = "zipButton";
            zipButton.Size = new Size(93, 23);
            zipButton.TabIndex = 17;
            zipButton.Text = "Архивировать";
            zipButton.UseVisualStyleBackColor = true;
            zipButton.Click += zipButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(mailButton);
            mainPanel.Controls.Add(lastScreenLabel);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(zipButton);
            mainPanel.Controls.Add(linkToPaint);
            mainPanel.Controls.Add(browserGB);
            mainPanel.Controls.Add(timerCB);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(testTextBox);
            mainPanel.Controls.Add(sectionGB);
            mainPanel.Controls.Add(envGB);
            mainPanel.Controls.Add(resultTextBox);
            mainPanel.Controls.Add(resultButtonPane);
            mainPanel.Controls.Add(screanshotButton);
            mainPanel.Controls.Add(steepTextBox);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(menuStrip2);
            mainPanel.Location = new Point(1, 1);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(616, 351);
            mainPanel.TabIndex = 0;
            mainPanel.Tag = "mainPanel";
            // 
            // lastScreenLabel
            // 
            lastScreenLabel.AutoSize = true;
            lastScreenLabel.Location = new Point(310, 218);
            lastScreenLabel.Name = "lastScreenLabel";
            lastScreenLabel.Size = new Size(131, 15);
            lastScreenLabel.TabIndex = 19;
            lastScreenLabel.Text = "Последний скриншот:";
            lastScreenLabel.TextAlign = ContentAlignment.BottomRight;
            lastScreenLabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(443, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 113);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // mailButton
            // 
            mailButton.Location = new Point(319, 268);
            mailButton.Name = "mailButton";
            mailButton.Size = new Size(75, 23);
            mailButton.TabIndex = 20;
            mailButton.Text = "button1";
            mailButton.UseVisualStyleBackColor = true;
            mailButton.Click += mailButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 353);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MainMenuStrip = miniToolStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMT";
            KeyDown += Form1_KeyDown;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            envGB.ResumeLayout(false);
            envGB.PerformLayout();
            sectionGB.ResumeLayout(false);
            browserGB.ResumeLayout(false);
            browserGB.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip miniToolStrip;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem настройкиToolStripMenuItem1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem компактныйтолькоСкриншотыToolStripMenuItem;
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
        private Label label2;
        private CheckBox timerCB;
        private GroupBox browserGB;
        private RadioButton chromeRB;
        private RadioButton IEexplorerRB;
        private LinkLabel linkToPaint;
        private Button zipButton;
        private Panel mainPanel;
        private PictureBox pictureBox1;
        private Label lastScreenLabel;
        private ToolStripMenuItem учетВремениToolStripMenuItem;
        public TextBox testTextBox;
        private Button mailButton;
    }
}