namespace HMT
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.steepNumTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.testNumTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultL = new System.Windows.Forms.Label();
            this.timerCB_min = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шаг:";
            // 
            // steepNumTB
            // 
            this.steepNumTB.Location = new System.Drawing.Point(44, 32);
            this.steepNumTB.Name = "steepNumTB";
            this.steepNumTB.Size = new System.Drawing.Size(56, 23);
            this.steepNumTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Скриншот";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testNumTB
            // 
            this.testNumTB.Location = new System.Drawing.Point(44, 3);
            this.testNumTB.Name = "testNumTB";
            this.testNumTB.Size = new System.Drawing.Size(56, 23);
            this.testNumTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тест:";
            // 
            // resultL
            // 
            this.resultL.AutoSize = true;
            this.resultL.Location = new System.Drawing.Point(6, 88);
            this.resultL.Name = "resultL";
            this.resultL.Size = new System.Drawing.Size(10, 15);
            this.resultL.TabIndex = 6;
            this.resultL.Text = " ";
            // 
            // timerCB_min
            // 
            this.timerCB_min.AutoSize = true;
            this.timerCB_min.Location = new System.Drawing.Point(6, 61);
            this.timerCB_min.Name = "timerCB_min";
            this.timerCB_min.Size = new System.Drawing.Size(196, 19);
            this.timerCB_min.TabIndex = 7;
            this.timerCB_min.Text = "Установить таймер на 5 секунд";
            this.timerCB_min.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 112);
            this.Controls.Add(this.timerCB_min);
            this.Controls.Add(this.resultL);
            this.Controls.Add(this.testNumTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.steepNumTB);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "HMT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox steepNumTB;
        private Button button1;
        private TextBox testNumTB;
        private Label label3;
        private Label resultL;
        private CheckBox timerCB_min;
    }
}