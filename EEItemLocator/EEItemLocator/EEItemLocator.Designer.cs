namespace EEItemLocator
{
    partial class EEItemLocator
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
            this.Find = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnvironmentList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExperienceEdge = new System.Windows.Forms.RichTextBox();
            this.Preview = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(772, 132);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 31);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(112, 132);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(654, 31);
            this.Path.TabIndex = 3;
            this.Path.Text = "{4D2E6585-8F60-4E8D-8D25-A250B22260D0}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Environment:";
            // 
            // EnvironmentList
            // 
            this.EnvironmentList.FormattingEnabled = true;
            this.EnvironmentList.Items.AddRange(new object[] {
            "SIT",
            "UAT",
            "PROD"});
            this.EnvironmentList.Location = new System.Drawing.Point(112, 43);
            this.EnvironmentList.Name = "EnvironmentList";
            this.EnvironmentList.Size = new System.Drawing.Size(121, 24);
            this.EnvironmentList.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ExperienceEdge);
            this.groupBox2.Controls.Add(this.Preview);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 53);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endpoints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Experience Edge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Preview";
            // 
            // ExperienceEdge
            // 
            this.ExperienceEdge.Location = new System.Drawing.Point(228, 12);
            this.ExperienceEdge.Name = "ExperienceEdge";
            this.ExperienceEdge.Size = new System.Drawing.Size(30, 30);
            this.ExperienceEdge.TabIndex = 13;
            this.ExperienceEdge.Text = "";
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(100, 12);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(30, 30);
            this.Preview.TabIndex = 12;
            this.Preview.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Language:";
            // 
            // Language
            // 
            this.Language.Location = new System.Drawing.Point(112, 86);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(654, 31);
            this.Language.TabIndex = 10;
            this.Language.Text = "en";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EEItemLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EnvironmentList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Find);
            this.Name = "EEItemLocator";
            this.Text = "XMC Item Detector";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.RichTextBox Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EnvironmentList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Language;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ExperienceEdge;
        private System.Windows.Forms.RichTextBox Preview;
        private System.Windows.Forms.Button button1;
    }
}

