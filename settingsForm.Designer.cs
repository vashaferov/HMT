namespace HMT
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            screenPathTB = new TextBox();
            label1 = new Label();
            saveButton = new Button();
            label4 = new Label();
            releaseTB = new TextBox();
            groupBox3 = new GroupBox();
            numOnScreenNegRB = new RadioButton();
            numOnScreenPosRB = new RadioButton();
            primaryMonitor = new RadioButton();
            mainMonitor = new RadioButton();
            groupBox2 = new GroupBox();
            processCB = new ComboBox();
            processRB = new RadioButton();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // screenPathTB
            // 
            screenPathTB.Location = new Point(12, 26);
            screenPathTB.Name = "screenPathTB";
            screenPathTB.Size = new Size(221, 23);
            screenPathTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(198, 15);
            label1.TabIndex = 3;
            label1.Text = "Путь для сохранения скриншотов:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(214, 253);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 12;
            label4.Text = "Релиз:";
            // 
            // releaseTB
            // 
            releaseTB.Location = new Point(12, 69);
            releaseTB.Name = "releaseTB";
            releaseTB.Size = new Size(277, 23);
            releaseTB.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numOnScreenNegRB);
            groupBox3.Controls.Add(numOnScreenPosRB);
            groupBox3.Location = new Point(12, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(216, 41);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Номер теста и шага на скриншоте:";
            // 
            // numOnScreenNegRB
            // 
            numOnScreenNegRB.AutoSize = true;
            numOnScreenNegRB.Location = new Point(165, 17);
            numOnScreenNegRB.Name = "numOnScreenNegRB";
            numOnScreenNegRB.Size = new Size(45, 19);
            numOnScreenNegRB.TabIndex = 1;
            numOnScreenNegRB.TabStop = true;
            numOnScreenNegRB.Text = "Нет";
            numOnScreenNegRB.UseVisualStyleBackColor = true;
            numOnScreenNegRB.CheckedChanged += numOnScreenRB_CheckedChanged;
            // 
            // numOnScreenPosRB
            // 
            numOnScreenPosRB.AutoSize = true;
            numOnScreenPosRB.Location = new Point(6, 17);
            numOnScreenPosRB.Name = "numOnScreenPosRB";
            numOnScreenPosRB.Size = new Size(39, 19);
            numOnScreenPosRB.TabIndex = 0;
            numOnScreenPosRB.TabStop = true;
            numOnScreenPosRB.Text = "Да";
            numOnScreenPosRB.UseVisualStyleBackColor = true;
            numOnScreenPosRB.CheckedChanged += numOnScreenRB_CheckedChanged;
            // 
            // primaryMonitor
            // 
            primaryMonitor.AutoSize = true;
            primaryMonitor.Location = new Point(6, 41);
            primaryMonitor.Name = "primaryMonitor";
            primaryMonitor.Size = new Size(174, 19);
            primaryMonitor.TabIndex = 9;
            primaryMonitor.TabStop = true;
            primaryMonitor.Text = "Дополнительный монитор";
            primaryMonitor.UseVisualStyleBackColor = true;
            primaryMonitor.CheckedChanged += monitor_CheckedChanged;
            // 
            // mainMonitor
            // 
            mainMonitor.AutoSize = true;
            mainMonitor.Location = new Point(6, 16);
            mainMonitor.Name = "mainMonitor";
            mainMonitor.Size = new Size(133, 19);
            mainMonitor.TabIndex = 8;
            mainMonitor.TabStop = true;
            mainMonitor.Text = "Основной монитор";
            mainMonitor.UseVisualStyleBackColor = true;
            mainMonitor.CheckedChanged += monitor_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(processCB);
            groupBox2.Controls.Add(processRB);
            groupBox2.Controls.Add(mainMonitor);
            groupBox2.Controls.Add(primaryMonitor);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 102);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Область захвата экрана:";
            // 
            // processCB
            // 
            processCB.FormattingEnabled = true;
            processCB.Items.AddRange(new object[] { "Удаленный рабочий стол", "Citrix", "Internet Explorer", "Chrome" });
            processCB.Location = new Point(85, 62);
            processCB.Name = "processCB";
            processCB.Size = new Size(184, 23);
            processCB.TabIndex = 11;
            processCB.SelectedIndexChanged += processCB_SelectedIndexChanged;
            // 
            // processRB
            // 
            processRB.AutoSize = true;
            processRB.Location = new Point(6, 66);
            processRB.Name = "processRB";
            processRB.Size = new Size(73, 19);
            processRB.TabIndex = 10;
            processRB.TabStop = true;
            processRB.Text = "Процесс";
            processRB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(239, 25);
            button1.Name = "button1";
            button1.Size = new Size(50, 23);
            button1.TabIndex = 15;
            button1.Text = "Обзор";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // settingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 283);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(releaseTB);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(screenPathTB);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "settingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            TopMost = true;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        public TextBox screenPathTB;
        private Button saveButton;
        public TextBox releaseTB;
        private Label label4;
        private GroupBox groupBox3;
        private RadioButton numOnScreenPosRB;
        private RadioButton numOnScreenNegRB;
        private GroupBox groupBox2;
        private RadioButton mainMonitor;
        private RadioButton primaryMonitor;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private RadioButton processRB;
        private ComboBox processCB;
    }
}