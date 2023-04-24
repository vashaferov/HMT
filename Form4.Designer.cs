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
            label1 = new Label();
            steepNumTB = new TextBox();
            button1 = new Button();
            testNumTB = new TextBox();
            label3 = new Label();
            resultL = new Label();
            timerCB_min = new CheckBox();
            linkToPaint = new LinkLabel();
            zipButtonFM = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // steepNumTB
            // 
            resources.ApplyResources(steepNumTB, "steepNumTB");
            steepNumTB.Name = "steepNumTB";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testNumTB
            // 
            resources.ApplyResources(testNumTB, "testNumTB");
            testNumTB.Name = "testNumTB";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // resultL
            // 
            resources.ApplyResources(resultL, "resultL");
            resultL.Name = "resultL";
            // 
            // timerCB_min
            // 
            resources.ApplyResources(timerCB_min, "timerCB_min");
            timerCB_min.Name = "timerCB_min";
            timerCB_min.UseVisualStyleBackColor = true;
            // 
            // linkToPaint
            // 
            resources.ApplyResources(linkToPaint, "linkToPaint");
            linkToPaint.Name = "linkToPaint";
            linkToPaint.TabStop = true;
            linkToPaint.LinkClicked += linkToPaint_LinkClicked;
            // 
            // zipButtonFM
            // 
            resources.ApplyResources(zipButtonFM, "zipButtonFM");
            zipButtonFM.Name = "zipButtonFM";
            zipButtonFM.UseVisualStyleBackColor = true;
            zipButtonFM.Click += zipButtonFM_Click;
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(zipButtonFM);
            Controls.Add(linkToPaint);
            Controls.Add(timerCB_min);
            Controls.Add(resultL);
            Controls.Add(testNumTB);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(steepNumTB);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "Form4";
            FormClosed += Form4_FormClosed;
            KeyDown += Form4_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox steepNumTB;
        private Button button1;
        private TextBox testNumTB;
        private Label label3;
        private Label resultL;
        private CheckBox timerCB_min;
        private LinkLabel linkToPaint;
        private Button zipButtonFM;
    }
}