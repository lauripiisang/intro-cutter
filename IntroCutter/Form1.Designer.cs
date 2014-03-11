namespace IntroCutter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.patternText = new System.Windows.Forms.TextBox();
            this.patternLabel = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathSelectButton = new System.Windows.Forms.Button();
            this.inFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.patternHelpProvider = new System.Windows.Forms.HelpProvider();
            this.patternToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sourceVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.rootFileLabel = new System.Windows.Forms.Label();
            this.sourceVideoName = new System.Windows.Forms.TextBox();
            this.selectSourceVideo = new System.Windows.Forms.Button();                        
            this.SuspendLayout();
            // 
            // patternText
            // 
            this.patternText.Location = new System.Drawing.Point(109, 97);
            this.patternText.Name = "patternText";
            this.patternText.Size = new System.Drawing.Size(100, 20);
            this.patternText.TabIndex = 0;
            this.patternText.Text = "*.avi";
            this.patternToolTip.SetToolTip(this.patternText, "Use patterns in format: *.avi,*.mp4");
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(14, 97);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(89, 13);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "File name Pattern";
            this.patternLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(413, 12);
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugText.Size = new System.Drawing.Size(793, 525);
            this.debugText.TabIndex = 2;
            this.debugText.Text = "Debug log";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(282, 414);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(114, 43);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(21, 59);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(82, 13);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "Select Directory";
            this.pathLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(109, 55);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(100, 20);
            this.pathText.TabIndex = 4;
            this.pathText.Text = "C:\\";
            // 
            // pathSelectButton
            // 
            this.pathSelectButton.Location = new System.Drawing.Point(215, 55);
            this.pathSelectButton.Name = "pathSelectButton";
            this.pathSelectButton.Size = new System.Drawing.Size(31, 20);
            this.pathSelectButton.TabIndex = 6;
            this.pathSelectButton.Text = "...";
            this.pathSelectButton.UseVisualStyleBackColor = true;
            this.pathSelectButton.Click += new System.EventHandler(this.pathSelectButton_Click);
            // 
            // inFolderBrowser
            // 
            this.inFolderBrowser.Description = "Folder browser";
            this.inFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyVideos;
            // 
            // patternToolTip
            // 
            this.patternToolTip.ShowAlways = true;
            this.patternToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.patternToolTip.ToolTipTitle = "Use patterns in format: *.avi,*.mp4";
            // 
            // sourceVideoDialog
            // 
            this.sourceVideoDialog.FileName = "openFileDialog1";
            // 
            // rootFileLabel
            // 
            this.rootFileLabel.AutoSize = true;
            this.rootFileLabel.Location = new System.Drawing.Point(14, 125);
            this.rootFileLabel.Name = "rootFileLabel";
            this.rootFileLabel.Size = new System.Drawing.Size(87, 13);
            this.rootFileLabel.TabIndex = 7;
            this.rootFileLabel.Text = "Source Video file";
            // 
            // sourceVideoName
            // 
            this.sourceVideoName.Location = new System.Drawing.Point(109, 125);
            this.sourceVideoName.Name = "sourceVideoName";
            this.sourceVideoName.ReadOnly = true;
            this.sourceVideoName.Size = new System.Drawing.Size(100, 20);
            this.sourceVideoName.TabIndex = 8;
            // 
            // selectSourceVideo
            // 
            this.selectSourceVideo.Location = new System.Drawing.Point(216, 124);
            this.selectSourceVideo.Name = "selectSourceVideo";
            this.selectSourceVideo.Size = new System.Drawing.Size(30, 21);
            this.selectSourceVideo.TabIndex = 9;
            this.selectSourceVideo.Text = "...";
            this.selectSourceVideo.UseVisualStyleBackColor = true;
            this.selectSourceVideo.Click += new System.EventHandler(this.selectSourceVideo_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 549);            
            this.Controls.Add(this.selectSourceVideo);
            this.Controls.Add(this.sourceVideoName);
            this.Controls.Add(this.rootFileLabel);
            this.Controls.Add(this.pathSelectButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.patternText);
            this.Name = "Form1";
            this.Text = "Form1";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patternText;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button pathSelectButton;
        public System.Windows.Forms.FolderBrowserDialog inFolderBrowser;
        private System.Windows.Forms.HelpProvider patternHelpProvider;
        private System.Windows.Forms.ToolTip patternToolTip;
        private System.Windows.Forms.OpenFileDialog sourceVideoDialog;
        private System.Windows.Forms.Label rootFileLabel;
        private System.Windows.Forms.TextBox sourceVideoName;
        private System.Windows.Forms.Button selectSourceVideo;
    }
}

