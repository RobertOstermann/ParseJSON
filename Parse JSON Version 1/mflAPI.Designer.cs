namespace Parse_JSON_Version_1
{
    partial class mflAPI
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
            this.uxPlayerList = new System.Windows.Forms.ListBox();
            this.uxAccessMFL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxDisplayDictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPlayerList
            // 
            this.uxPlayerList.FormattingEnabled = true;
            this.uxPlayerList.ItemHeight = 16;
            this.uxPlayerList.Location = new System.Drawing.Point(12, 80);
            this.uxPlayerList.Name = "uxPlayerList";
            this.uxPlayerList.Size = new System.Drawing.Size(776, 356);
            this.uxPlayerList.TabIndex = 0;
            // 
            // uxAccessMFL
            // 
            this.uxAccessMFL.Location = new System.Drawing.Point(12, 12);
            this.uxAccessMFL.Name = "uxAccessMFL";
            this.uxAccessMFL.Size = new System.Drawing.Size(776, 38);
            this.uxAccessMFL.TabIndex = 1;
            this.uxAccessMFL.Text = "Access MFL API";
            this.uxAccessMFL.UseVisualStyleBackColor = true;
            this.uxAccessMFL.Click += new System.EventHandler(this.uxAccessMFL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NFL Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "MFL Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(767, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // uxDisplayDictionary
            // 
            this.uxDisplayDictionary.Location = new System.Drawing.Point(12, 442);
            this.uxDisplayDictionary.Name = "uxDisplayDictionary";
            this.uxDisplayDictionary.Size = new System.Drawing.Size(776, 38);
            this.uxDisplayDictionary.TabIndex = 7;
            this.uxDisplayDictionary.Text = "Display Dictionary";
            this.uxDisplayDictionary.UseVisualStyleBackColor = true;
            this.uxDisplayDictionary.Click += new System.EventHandler(this.button1_Click);
            // 
            // mflAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.uxDisplayDictionary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxAccessMFL);
            this.Controls.Add(this.uxPlayerList);
            this.Name = "mflAPI";
            this.Text = "mflAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxPlayerList;
        private System.Windows.Forms.Button uxAccessMFL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uxDisplayDictionary;
    }
}