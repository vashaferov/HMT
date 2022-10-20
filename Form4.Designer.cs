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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.steepNumTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.testNumTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultL = new System.Windows.Forms.Label();
            this.timerCB_min = new System.Windows.Forms.CheckBox();
            this.linkToPaint = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // steepNumTB
            // 
            resources.ApplyResources(this.steepNumTB, "steepNumTB");
            this.steepNumTB.Name = "steepNumTB";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testNumTB
            // 
            resources.ApplyResources(this.testNumTB, "testNumTB");
            this.testNumTB.Name = "testNumTB";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // resultL
            // 
            resources.ApplyResources(this.resultL, "resultL");
            this.resultL.Name = "resultL";
            // 
            // timerCB_min
            // 
            resources.ApplyResources(this.timerCB_min, "timerCB_min");
            this.timerCB_min.Name = "timerCB_min";
            this.timerCB_min.UseVisualStyleBackColor = true;
            // 
            // linkToPaint
            // 
            resources.ApplyResources(this.linkToPaint, "linkToPaint");
            this.linkToPaint.Name = "linkToPaint";
            this.linkToPaint.TabStop = true;
            this.linkToPaint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToPaint_LinkClicked);
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkToPaint);
            this.Controls.Add(this.timerCB_min);
            this.Controls.Add(this.resultL);
            this.Controls.Add(this.testNumTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.steepNumTB);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
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
        private LinkLabel linkToPaint;
    }
}