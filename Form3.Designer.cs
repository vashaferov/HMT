namespace HMT
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.sectionGB = new System.Windows.Forms.GroupBox();
            this.logRB = new System.Windows.Forms.RadioButton();
            this.linkRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nextTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.realTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sectionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sectionGB
            // 
            this.sectionGB.Controls.Add(this.logRB);
            this.sectionGB.Controls.Add(this.linkRB);
            this.sectionGB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sectionGB.Location = new System.Drawing.Point(3, 2);
            this.sectionGB.Name = "sectionGB";
            this.sectionGB.Size = new System.Drawing.Size(182, 45);
            this.sectionGB.TabIndex = 10;
            this.sectionGB.TabStop = false;
            this.sectionGB.Tag = "sectionGB";
            this.sectionGB.Text = "Раздел:";
            // 
            // logRB
            // 
            this.logRB.Location = new System.Drawing.Point(97, 19);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(3, 68);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(313, 23);
            this.nameTB.TabIndex = 12;
            // 
            // nextTB
            // 
            this.nextTB.Location = new System.Drawing.Point(3, 114);
            this.nextTB.Name = "nextTB";
            this.nextTB.Size = new System.Drawing.Size(313, 23);
            this.nextTB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Next";
            // 
            // realTB
            // 
            this.realTB.Location = new System.Drawing.Point(3, 159);
            this.realTB.Name = "realTB";
            this.realTB.Size = new System.Drawing.Size(313, 23);
            this.realTB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Real";
            // 
            // intTB
            // 
            this.intTB.Location = new System.Drawing.Point(3, 204);
            this.intTB.Name = "intTB";
            this.intTB.Size = new System.Drawing.Size(313, 23);
            this.intTB.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Int";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 274);
            this.Controls.Add(this.intTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.realTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectionGB);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.sectionGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

        }

        #endregion

        private Button button1;
        private GroupBox sectionGB;
        private RadioButton logRB;
        private RadioButton linkRB;
        private Label label1;
        private TextBox nameTB;
        private TextBox nextTB;
        private Label label2;
        private TextBox realTB;
        private Label label3;
        private TextBox intTB;
        private Label label4;
    }
}