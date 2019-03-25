namespace Parse_JSON_Version_1
{
    partial class restClient
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
            this.uxRestURL = new System.Windows.Forms.TextBox();
            this.uxResponse = new System.Windows.Forms.TextBox();
            this.uxGo = new System.Windows.Forms.Button();
            this.uxRequestLabel = new System.Windows.Forms.Label();
            this.uxResponseLabel = new System.Windows.Forms.Label();
            this.uxDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxRestURL
            // 
            this.uxRestURL.Location = new System.Drawing.Point(124, 26);
            this.uxRestURL.Name = "uxRestURL";
            this.uxRestURL.Size = new System.Drawing.Size(545, 22);
            this.uxRestURL.TabIndex = 0;
            // 
            // uxResponse
            // 
            this.uxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxResponse.Location = new System.Drawing.Point(124, 69);
            this.uxResponse.MaxLength = 1000000000;
            this.uxResponse.Multiline = true;
            this.uxResponse.Name = "uxResponse";
            this.uxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResponse.Size = new System.Drawing.Size(664, 369);
            this.uxResponse.TabIndex = 1;
            // 
            // uxGo
            // 
            this.uxGo.Location = new System.Drawing.Point(675, 12);
            this.uxGo.Name = "uxGo";
            this.uxGo.Size = new System.Drawing.Size(113, 51);
            this.uxGo.TabIndex = 2;
            this.uxGo.Text = "GO!";
            this.uxGo.UseVisualStyleBackColor = true;
            this.uxGo.Click += new System.EventHandler(this.uxGo_Click);
            // 
            // uxRequestLabel
            // 
            this.uxRequestLabel.AutoSize = true;
            this.uxRequestLabel.Location = new System.Drawing.Point(25, 29);
            this.uxRequestLabel.Name = "uxRequestLabel";
            this.uxRequestLabel.Size = new System.Drawing.Size(93, 17);
            this.uxRequestLabel.TabIndex = 3;
            this.uxRequestLabel.Text = "Request URL";
            // 
            // uxResponseLabel
            // 
            this.uxResponseLabel.AutoSize = true;
            this.uxResponseLabel.Location = new System.Drawing.Point(25, 72);
            this.uxResponseLabel.Name = "uxResponseLabel";
            this.uxResponseLabel.Size = new System.Drawing.Size(80, 17);
            this.uxResponseLabel.TabIndex = 4;
            this.uxResponseLabel.Text = "Response: ";
            // 
            // uxDone
            // 
            this.uxDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxDone.Location = new System.Drawing.Point(12, 400);
            this.uxDone.Name = "uxDone";
            this.uxDone.Size = new System.Drawing.Size(106, 38);
            this.uxDone.TabIndex = 5;
            this.uxDone.Text = "Done";
            this.uxDone.UseVisualStyleBackColor = true;
            // 
            // restClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDone);
            this.Controls.Add(this.uxResponseLabel);
            this.Controls.Add(this.uxRequestLabel);
            this.Controls.Add(this.uxGo);
            this.Controls.Add(this.uxResponse);
            this.Controls.Add(this.uxRestURL);
            this.Name = "restClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "restClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxRestURL;
        private System.Windows.Forms.TextBox uxResponse;
        private System.Windows.Forms.Button uxGo;
        private System.Windows.Forms.Label uxRequestLabel;
        private System.Windows.Forms.Label uxResponseLabel;
        private System.Windows.Forms.Button uxDone;
    }
}