namespace Parse_JSON_Version_1
{
    partial class JSONParser
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
            this.uxRawJSON = new System.Windows.Forms.GroupBox();
            this.uxSerializedString = new System.Windows.Forms.TextBox();
            this.uxDeserialize = new System.Windows.Forms.Button();
            this.uxClearDebug = new System.Windows.Forms.Button();
            this.uxDebugOutput = new System.Windows.Forms.GroupBox();
            this.uxOutput = new System.Windows.Forms.TextBox();
            this.uxRest = new System.Windows.Forms.Button();
            this.uxAsync = new System.Windows.Forms.Button();
            this.uxMFLApi = new System.Windows.Forms.Button();
            this.uxRawJSON.SuspendLayout();
            this.uxDebugOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxRawJSON
            // 
            this.uxRawJSON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRawJSON.Controls.Add(this.uxSerializedString);
            this.uxRawJSON.Location = new System.Drawing.Point(13, 13);
            this.uxRawJSON.Name = "uxRawJSON";
            this.uxRawJSON.Size = new System.Drawing.Size(762, 194);
            this.uxRawJSON.TabIndex = 0;
            this.uxRawJSON.TabStop = false;
            this.uxRawJSON.Text = "Raw JSON (Serialized String)";
            // 
            // uxSerializedString
            // 
            this.uxSerializedString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSerializedString.Location = new System.Drawing.Point(7, 22);
            this.uxSerializedString.MaxLength = 1000000000;
            this.uxSerializedString.Multiline = true;
            this.uxSerializedString.Name = "uxSerializedString";
            this.uxSerializedString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxSerializedString.Size = new System.Drawing.Size(749, 166);
            this.uxSerializedString.TabIndex = 0;
            // 
            // uxDeserialize
            // 
            this.uxDeserialize.Location = new System.Drawing.Point(13, 214);
            this.uxDeserialize.Name = "uxDeserialize";
            this.uxDeserialize.Size = new System.Drawing.Size(122, 37);
            this.uxDeserialize.TabIndex = 1;
            this.uxDeserialize.Text = "Deserialize";
            this.uxDeserialize.UseVisualStyleBackColor = true;
            this.uxDeserialize.Click += new System.EventHandler(this.uxDeserialize_Click);
            // 
            // uxClearDebug
            // 
            this.uxClearDebug.Location = new System.Drawing.Point(141, 214);
            this.uxClearDebug.Name = "uxClearDebug";
            this.uxClearDebug.Size = new System.Drawing.Size(122, 37);
            this.uxClearDebug.TabIndex = 2;
            this.uxClearDebug.Text = "Clear Debug";
            this.uxClearDebug.UseVisualStyleBackColor = true;
            this.uxClearDebug.Click += new System.EventHandler(this.uxClearDebug_Click);
            // 
            // uxDebugOutput
            // 
            this.uxDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDebugOutput.Controls.Add(this.uxOutput);
            this.uxDebugOutput.Location = new System.Drawing.Point(12, 257);
            this.uxDebugOutput.Name = "uxDebugOutput";
            this.uxDebugOutput.Size = new System.Drawing.Size(762, 194);
            this.uxDebugOutput.TabIndex = 1;
            this.uxDebugOutput.TabStop = false;
            this.uxDebugOutput.Text = "Debug Output";
            // 
            // uxOutput
            // 
            this.uxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOutput.Location = new System.Drawing.Point(6, 22);
            this.uxOutput.MaxLength = 1000000000;
            this.uxOutput.Multiline = true;
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxOutput.Size = new System.Drawing.Size(749, 166);
            this.uxOutput.TabIndex = 1;
            // 
            // uxRest
            // 
            this.uxRest.Location = new System.Drawing.Point(647, 213);
            this.uxRest.Name = "uxRest";
            this.uxRest.Size = new System.Drawing.Size(122, 37);
            this.uxRest.TabIndex = 3;
            this.uxRest.Text = "REST API";
            this.uxRest.UseVisualStyleBackColor = true;
            this.uxRest.Click += new System.EventHandler(this.uxRest_Click);
            // 
            // uxAsync
            // 
            this.uxAsync.Location = new System.Drawing.Point(519, 213);
            this.uxAsync.Name = "uxAsync";
            this.uxAsync.Size = new System.Drawing.Size(122, 37);
            this.uxAsync.TabIndex = 4;
            this.uxAsync.Text = "async API";
            this.uxAsync.UseVisualStyleBackColor = true;
            this.uxAsync.Click += new System.EventHandler(this.uxAsync_Click);
            // 
            // uxMFLApi
            // 
            this.uxMFLApi.Location = new System.Drawing.Point(391, 213);
            this.uxMFLApi.Name = "uxMFLApi";
            this.uxMFLApi.Size = new System.Drawing.Size(122, 37);
            this.uxMFLApi.TabIndex = 5;
            this.uxMFLApi.Text = "MFL API";
            this.uxMFLApi.UseVisualStyleBackColor = true;
            this.uxMFLApi.Click += new System.EventHandler(this.uxMFLApi_Click);
            // 
            // JSONParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.uxMFLApi);
            this.Controls.Add(this.uxAsync);
            this.Controls.Add(this.uxRest);
            this.Controls.Add(this.uxDebugOutput);
            this.Controls.Add(this.uxClearDebug);
            this.Controls.Add(this.uxDeserialize);
            this.Controls.Add(this.uxRawJSON);
            this.Name = "JSONParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON Parser";
            this.uxRawJSON.ResumeLayout(false);
            this.uxRawJSON.PerformLayout();
            this.uxDebugOutput.ResumeLayout(false);
            this.uxDebugOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox uxRawJSON;
        private System.Windows.Forms.Button uxDeserialize;
        private System.Windows.Forms.Button uxClearDebug;
        private System.Windows.Forms.GroupBox uxDebugOutput;
        private System.Windows.Forms.TextBox uxSerializedString;
        private System.Windows.Forms.TextBox uxOutput;
        private System.Windows.Forms.Button uxRest;
        private System.Windows.Forms.Button uxAsync;
        private System.Windows.Forms.Button uxMFLApi;
    }
}

