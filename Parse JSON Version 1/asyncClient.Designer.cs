namespace Parse_JSON_Version_1
{
    partial class asyncClient
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
            this.uxDone = new System.Windows.Forms.Button();
            this.uxResponseLabel = new System.Windows.Forms.Label();
            this.uxRequestLabel = new System.Windows.Forms.Label();
            this.uxGo = new System.Windows.Forms.Button();
            this.uxAsyncURL = new System.Windows.Forms.TextBox();
            this.uxList = new System.Windows.Forms.ListBox();
            this.uxAVLTree = new System.Windows.Forms.Button();
            this.uxSearchAVL = new System.Windows.Forms.Button();
            this.uxAllPlayerURL = new System.Windows.Forms.Button();
            this.uxAllRosterURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDone
            // 
            this.uxDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxDone.Location = new System.Drawing.Point(12, 390);
            this.uxDone.Name = "uxDone";
            this.uxDone.Size = new System.Drawing.Size(106, 38);
            this.uxDone.TabIndex = 11;
            this.uxDone.Text = "Done";
            this.uxDone.UseVisualStyleBackColor = true;
            // 
            // uxResponseLabel
            // 
            this.uxResponseLabel.AutoSize = true;
            this.uxResponseLabel.Location = new System.Drawing.Point(25, 72);
            this.uxResponseLabel.Name = "uxResponseLabel";
            this.uxResponseLabel.Size = new System.Drawing.Size(80, 17);
            this.uxResponseLabel.TabIndex = 10;
            this.uxResponseLabel.Text = "Response: ";
            // 
            // uxRequestLabel
            // 
            this.uxRequestLabel.AutoSize = true;
            this.uxRequestLabel.Location = new System.Drawing.Point(25, 29);
            this.uxRequestLabel.Name = "uxRequestLabel";
            this.uxRequestLabel.Size = new System.Drawing.Size(93, 17);
            this.uxRequestLabel.TabIndex = 9;
            this.uxRequestLabel.Text = "Request URL";
            // 
            // uxGo
            // 
            this.uxGo.Location = new System.Drawing.Point(675, 12);
            this.uxGo.Name = "uxGo";
            this.uxGo.Size = new System.Drawing.Size(113, 51);
            this.uxGo.TabIndex = 8;
            this.uxGo.Text = "async List";
            this.uxGo.UseVisualStyleBackColor = true;
            this.uxGo.Click += new System.EventHandler(this.uxGo_Click);
            // 
            // uxAsyncURL
            // 
            this.uxAsyncURL.Location = new System.Drawing.Point(124, 26);
            this.uxAsyncURL.Name = "uxAsyncURL";
            this.uxAsyncURL.Size = new System.Drawing.Size(545, 22);
            this.uxAsyncURL.TabIndex = 6;
            // 
            // uxList
            // 
            this.uxList.FormattingEnabled = true;
            this.uxList.ItemHeight = 16;
            this.uxList.Location = new System.Drawing.Point(124, 72);
            this.uxList.Name = "uxList";
            this.uxList.Size = new System.Drawing.Size(783, 356);
            this.uxList.TabIndex = 12;
            // 
            // uxAVLTree
            // 
            this.uxAVLTree.Location = new System.Drawing.Point(794, 12);
            this.uxAVLTree.Name = "uxAVLTree";
            this.uxAVLTree.Size = new System.Drawing.Size(113, 51);
            this.uxAVLTree.TabIndex = 13;
            this.uxAVLTree.Text = "async AVL Tree";
            this.uxAVLTree.UseVisualStyleBackColor = true;
            this.uxAVLTree.Click += new System.EventHandler(this.uxAVLTree_Click);
            // 
            // uxSearchAVL
            // 
            this.uxSearchAVL.Location = new System.Drawing.Point(5, 255);
            this.uxSearchAVL.Name = "uxSearchAVL";
            this.uxSearchAVL.Size = new System.Drawing.Size(113, 51);
            this.uxSearchAVL.TabIndex = 14;
            this.uxSearchAVL.Text = "Search AVL Tree";
            this.uxSearchAVL.UseVisualStyleBackColor = true;
            this.uxSearchAVL.Click += new System.EventHandler(this.uxSearchAVL_Click);
            // 
            // uxAllPlayerURL
            // 
            this.uxAllPlayerURL.Location = new System.Drawing.Point(5, 92);
            this.uxAllPlayerURL.Name = "uxAllPlayerURL";
            this.uxAllPlayerURL.Size = new System.Drawing.Size(113, 51);
            this.uxAllPlayerURL.TabIndex = 15;
            this.uxAllPlayerURL.Text = "All Player URL";
            this.uxAllPlayerURL.UseVisualStyleBackColor = true;
            this.uxAllPlayerURL.Click += new System.EventHandler(this.uxAllPlayerURL_Click);
            // 
            // uxAllRosterURL
            // 
            this.uxAllRosterURL.Location = new System.Drawing.Point(5, 149);
            this.uxAllRosterURL.Name = "uxAllRosterURL";
            this.uxAllRosterURL.Size = new System.Drawing.Size(113, 51);
            this.uxAllRosterURL.TabIndex = 16;
            this.uxAllRosterURL.Text = "All Roster URL";
            this.uxAllRosterURL.UseVisualStyleBackColor = true;
            this.uxAllRosterURL.Click += new System.EventHandler(this.uxAllRosterURL_Click);
            // 
            // asyncClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.uxAllRosterURL);
            this.Controls.Add(this.uxAllPlayerURL);
            this.Controls.Add(this.uxSearchAVL);
            this.Controls.Add(this.uxAVLTree);
            this.Controls.Add(this.uxList);
            this.Controls.Add(this.uxDone);
            this.Controls.Add(this.uxResponseLabel);
            this.Controls.Add(this.uxRequestLabel);
            this.Controls.Add(this.uxGo);
            this.Controls.Add(this.uxAsyncURL);
            this.Name = "asyncClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "asyncClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxDone;
        private System.Windows.Forms.Label uxResponseLabel;
        private System.Windows.Forms.Label uxRequestLabel;
        private System.Windows.Forms.Button uxGo;
        private System.Windows.Forms.TextBox uxAsyncURL;
        private System.Windows.Forms.ListBox uxList;
        private System.Windows.Forms.Button uxAVLTree;
        private System.Windows.Forms.Button uxSearchAVL;
        private System.Windows.Forms.Button uxAllPlayerURL;
        private System.Windows.Forms.Button uxAllRosterURL;
    }
}