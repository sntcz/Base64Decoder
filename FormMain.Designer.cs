namespace Base64Decoder
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButton = new System.Windows.Forms.Panel();
            this.textBase64 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDecode64 = new System.Windows.Forms.Button();
            this.splitter = new System.Windows.Forms.Splitter();
            this.hexBox = new Be.Windows.Forms.HexBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusByteDec = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusByteBin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusWeb = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelButton.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.textBase64);
            this.panelButton.Controls.Add(this.buttonClear);
            this.panelButton.Controls.Add(this.buttonDecode64);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(800, 222);
            this.panelButton.TabIndex = 1;
            // 
            // textBase64
            // 
            this.textBase64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBase64.Location = new System.Drawing.Point(0, 0);
            this.textBase64.Multiline = true;
            this.textBase64.Name = "textBase64";
            this.textBase64.PlaceholderText = "Type (or paste) Base64 string here...";
            this.textBase64.Size = new System.Drawing.Size(800, 174);
            this.textBase64.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(638, 184);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 26);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDecode64
            // 
            this.buttonDecode64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDecode64.Location = new System.Drawing.Point(12, 184);
            this.buttonDecode64.Name = "buttonDecode64";
            this.buttonDecode64.Size = new System.Drawing.Size(150, 26);
            this.buttonDecode64.TabIndex = 0;
            this.buttonDecode64.Text = "Decode";
            this.buttonDecode64.UseVisualStyleBackColor = true;
            this.buttonDecode64.Click += new System.EventHandler(this.buttonDecode64_Click);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 222);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(800, 3);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // hexBox
            // 
            this.hexBox.ColumnInfoVisible = true;
            this.hexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexBox.LineInfoVisible = true;
            this.hexBox.Location = new System.Drawing.Point(0, 225);
            this.hexBox.Name = "hexBox";
            this.hexBox.ReadOnly = true;
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(800, 203);
            this.hexBox.StringViewVisible = true;
            this.hexBox.TabIndex = 3;
            this.hexBox.UseFixedBytesPerLine = true;
            this.hexBox.VScrollBarVisible = true;
            this.hexBox.CurrentLineChanged += new System.EventHandler(this.hexBox_CurrentLineChanged);
            this.hexBox.CurrentPositionInLineChanged += new System.EventHandler(this.hexBox_CurrentPositionInLineChanged);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPosition,
            this.toolStripStatusByteDec,
            this.toolStripStatusByteBin,
            this.toolStripStatusSpring,
            this.toolStripStatusWeb});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusPosition
            // 
            this.toolStripStatusPosition.Name = "toolStripStatusPosition";
            this.toolStripStatusPosition.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusPosition.Text = "Position: 0";
            // 
            // toolStripStatusByteDec
            // 
            this.toolStripStatusByteDec.Margin = new System.Windows.Forms.Padding(12, 3, 0, 2);
            this.toolStripStatusByteDec.Name = "toolStripStatusByteDec";
            this.toolStripStatusByteDec.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusByteDec.Text = "?";
            // 
            // toolStripStatusByteBin
            // 
            this.toolStripStatusByteBin.Margin = new System.Windows.Forms.Padding(12, 3, 0, 2);
            this.toolStripStatusByteBin.Name = "toolStripStatusByteBin";
            this.toolStripStatusByteBin.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusByteBin.Text = "???? ????";
            // 
            // toolStripStatusSpring
            // 
            this.toolStripStatusSpring.Name = "toolStripStatusSpring";
            this.toolStripStatusSpring.Size = new System.Drawing.Size(559, 17);
            this.toolStripStatusSpring.Spring = true;
            // 
            // toolStripStatusWeb
            // 
            this.toolStripStatusWeb.IsLink = true;
            this.toolStripStatusWeb.Name = "toolStripStatusWeb";
            this.toolStripStatusWeb.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusWeb.Text = "www.sntcz.cz";
            this.toolStripStatusWeb.Click += new System.EventHandler(this.toolStripStatusWeb_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.panelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Decode from Base64 format";
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelButton;
        private Button buttonClear;
        private Button buttonDecode64;
        private Splitter splitter;
        private Be.Windows.Forms.HexBox hexBox;
        private TextBox textBase64;
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusPosition;
        private ToolStripStatusLabel toolStripStatusByteDec;
        private ToolStripStatusLabel toolStripStatusByteBin;
        private ToolStripStatusLabel toolStripStatusSpring;
        private ToolStripStatusLabel toolStripStatusWeb;
    }
}