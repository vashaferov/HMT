namespace HMT
{
    partial class Form2
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.screenPathTB = new System.Windows.Forms.TextBox();
            this.configPathTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.releaseTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numOnScreenNegRB = new System.Windows.Forms.RadioButton();
            this.numOnScreenPosRB = new System.Windows.Forms.RadioButton();
            this.primaryMonitor = new System.Windows.Forms.RadioButton();
            this.mainMonitor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // screenPathTB
            // 
            this.screenPathTB.Location = new System.Drawing.Point(12, 31);
            this.screenPathTB.Name = "screenPathTB";
            this.screenPathTB.Size = new System.Drawing.Size(245, 23);
            this.screenPathTB.TabIndex = 0;
            // 
            // configPathTB
            // 
            this.configPathTB.Location = new System.Drawing.Point(12, 75);
            this.configPathTB.Name = "configPathTB";
            this.configPathTB.Size = new System.Drawing.Size(245, 23);
            this.configPathTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь для сохранения скриншотов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Путь к файлу конфига:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(247, 241);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Релиз:";
            // 
            // releaseTB
            // 
            this.releaseTB.Location = new System.Drawing.Point(12, 119);
            this.releaseTB.Name = "releaseTB";
            this.releaseTB.Size = new System.Drawing.Size(299, 23);
            this.releaseTB.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numOnScreenNegRB);
            this.groupBox3.Controls.Add(this.numOnScreenPosRB);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 41);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Номер теста и шага на скриншоте:";
            // 
            // numOnScreenNegRB
            // 
            this.numOnScreenNegRB.AutoSize = true;
            this.numOnScreenNegRB.Location = new System.Drawing.Point(165, 17);
            this.numOnScreenNegRB.Name = "numOnScreenNegRB";
            this.numOnScreenNegRB.Size = new System.Drawing.Size(45, 19);
            this.numOnScreenNegRB.TabIndex = 1;
            this.numOnScreenNegRB.TabStop = true;
            this.numOnScreenNegRB.Text = "Нет";
            this.numOnScreenNegRB.UseVisualStyleBackColor = true;
            this.numOnScreenNegRB.CheckedChanged += new System.EventHandler(this.numOnScreenRB_CheckedChanged);
            // 
            // numOnScreenPosRB
            // 
            this.numOnScreenPosRB.AutoSize = true;
            this.numOnScreenPosRB.Location = new System.Drawing.Point(7, 17);
            this.numOnScreenPosRB.Name = "numOnScreenPosRB";
            this.numOnScreenPosRB.Size = new System.Drawing.Size(39, 19);
            this.numOnScreenPosRB.TabIndex = 0;
            this.numOnScreenPosRB.TabStop = true;
            this.numOnScreenPosRB.Text = "Да";
            this.numOnScreenPosRB.UseVisualStyleBackColor = true;
            this.numOnScreenPosRB.CheckedChanged += new System.EventHandler(this.numOnScreenRB_CheckedChanged);
            // 
            // primaryMonitor
            // 
            this.primaryMonitor.AutoSize = true;
            this.primaryMonitor.Location = new System.Drawing.Point(109, 16);
            this.primaryMonitor.Name = "primaryMonitor";
            this.primaryMonitor.Size = new System.Drawing.Size(122, 19);
            this.primaryMonitor.TabIndex = 9;
            this.primaryMonitor.TabStop = true;
            this.primaryMonitor.Text = "Дополнительный";
            this.primaryMonitor.UseVisualStyleBackColor = true;
            this.primaryMonitor.CheckedChanged += new System.EventHandler(this.monitor_CheckedChanged);
            // 
            // mainMonitor
            // 
            this.mainMonitor.AutoSize = true;
            this.mainMonitor.Location = new System.Drawing.Point(6, 16);
            this.mainMonitor.Name = "mainMonitor";
            this.mainMonitor.Size = new System.Drawing.Size(81, 19);
            this.mainMonitor.TabIndex = 8;
            this.mainMonitor.TabStop = true;
            this.mainMonitor.Text = "Основной";
            this.mainMonitor.UseVisualStyleBackColor = true;
            this.mainMonitor.CheckedChanged += new System.EventHandler(this.monitor_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainMonitor);
            this.groupBox2.Controls.Add(this.primaryMonitor);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 41);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Монитор:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.releaseTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configPathTB);
            this.Controls.Add(this.screenPathTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        public TextBox configPathTB;
        public TextBox screenPathTB;
        private Button saveButton;
        private Label label2;
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
        private Button button2;
        private OpenFileDialog openFileDialog1;
    }
}