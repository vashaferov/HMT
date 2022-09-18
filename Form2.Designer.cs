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
            this.processTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuProcessRB = new System.Windows.Forms.RadioButton();
            this.menuMonitorRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainMonitor = new System.Windows.Forms.RadioButton();
            this.primaryMonitor = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.releaseTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numOnScreenNegRB = new System.Windows.Forms.RadioButton();
            this.numOnScreenPosRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.screenPathTB.Size = new System.Drawing.Size(299, 23);
            this.screenPathTB.TabIndex = 0;
            // 
            // configPathTB
            // 
            this.configPathTB.Location = new System.Drawing.Point(12, 75);
            this.configPathTB.Name = "configPathTB";
            this.configPathTB.Size = new System.Drawing.Size(299, 23);
            this.configPathTB.TabIndex = 1;
            // 
            // processTB
            // 
            this.processTB.Location = new System.Drawing.Point(10, 261);
            this.processTB.Name = "processTB";
            this.processTB.Size = new System.Drawing.Size(299, 23);
            this.processTB.TabIndex = 2;
            this.processTB.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Скриншот процесса: ";
            this.label3.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(234, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuProcessRB
            // 
            this.menuProcessRB.AutoSize = true;
            this.menuProcessRB.Location = new System.Drawing.Point(6, 16);
            this.menuProcessRB.Name = "menuProcessRB";
            this.menuProcessRB.Size = new System.Drawing.Size(138, 19);
            this.menuProcessRB.TabIndex = 8;
            this.menuProcessRB.TabStop = true;
            this.menuProcessRB.Text = "Скриншот процесса";
            this.menuProcessRB.UseVisualStyleBackColor = true;
            this.menuProcessRB.CheckedChanged += new System.EventHandler(this.menuScreenRB_CheckedChanged);
            // 
            // menuMonitorRB
            // 
            this.menuMonitorRB.AutoSize = true;
            this.menuMonitorRB.Location = new System.Drawing.Point(156, 16);
            this.menuMonitorRB.Name = "menuMonitorRB";
            this.menuMonitorRB.Size = new System.Drawing.Size(141, 19);
            this.menuMonitorRB.TabIndex = 9;
            this.menuMonitorRB.TabStop = true;
            this.menuMonitorRB.Text = "Скриншот монитора";
            this.menuMonitorRB.UseVisualStyleBackColor = true;
            this.menuMonitorRB.CheckedChanged += new System.EventHandler(this.menuScreenRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuProcessRB);
            this.groupBox1.Controls.Add(this.menuMonitorRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 41);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод создания скриншота:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainMonitor);
            this.groupBox2.Controls.Add(this.primaryMonitor);
            this.groupBox2.Location = new System.Drawing.Point(10, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 41);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Монитор:";
            this.groupBox2.Visible = false;
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
            this.groupBox3.Size = new System.Drawing.Size(216, 41);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.releaseTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processTB);
            this.Controls.Add(this.configPathTB);
            this.Controls.Add(this.screenPathTB);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        public TextBox processTB;
        public TextBox configPathTB;
        public TextBox screenPathTB;
        private Button saveButton;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton menuProcessRB;
        private RadioButton menuMonitorRB;
        private GroupBox groupBox2;
        private RadioButton mainMonitor;
        private RadioButton primaryMonitor;
        public TextBox releaseTB;
        private Label label4;
        private GroupBox groupBox3;
        private RadioButton numOnScreenPosRB;
        private RadioButton numOnScreenNegRB;
    }
}