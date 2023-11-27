namespace HMT
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            label1 = new Label();
            steepNumTB = new TextBox();
            button1 = new Button();
            testNumTB = new TextBox();
            label3 = new Label();
            resultL = new Label();
            timerCB_min = new CheckBox();
            linkToPaint = new LinkLabel();
            zipButtonFM = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(toolStripMenuItem3, "toolStripMenuItem3");
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
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
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            TopMost = true;
            KeyDown += Form4_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}