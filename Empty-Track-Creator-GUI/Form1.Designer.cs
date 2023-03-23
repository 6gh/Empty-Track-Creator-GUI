namespace Empty_Track_Creator_GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputPathTXT = new System.Windows.Forms.TextBox();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MelodyTrackCount = new System.Windows.Forms.NumericUpDown();
            this.ArtTracksCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BPMNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PPQBox = new System.Windows.Forms.ComboBox();
            this.DrumsChk = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommandTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.InputBrowseBTN = new System.Windows.Forms.Button();
            this.InputPathTXT = new System.Windows.Forms.TextBox();
            this.enableTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MelodyTrackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtTracksCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPMNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputPathTXT
            // 
            this.OutputPathTXT.AllowDrop = true;
            this.OutputPathTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPathTXT.Location = new System.Drawing.Point(93, 60);
            this.OutputPathTXT.Name = "OutputPathTXT";
            this.OutputPathTXT.Size = new System.Drawing.Size(276, 23);
            this.OutputPathTXT.TabIndex = 0;
            this.OutputPathTXT.Text = "output.mid";
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBTN.Location = new System.Drawing.Point(375, 59);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(100, 23);
            this.BrowseBTN.TabIndex = 1;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Melody Tracks:";
            // 
            // MelodyTrackCount
            // 
            this.MelodyTrackCount.Location = new System.Drawing.Point(103, 103);
            this.MelodyTrackCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MelodyTrackCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MelodyTrackCount.Name = "MelodyTrackCount";
            this.MelodyTrackCount.Size = new System.Drawing.Size(120, 23);
            this.MelodyTrackCount.TabIndex = 2;
            this.MelodyTrackCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // ArtTracksCount
            // 
            this.ArtTracksCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtTracksCount.Location = new System.Drawing.Point(355, 103);
            this.ArtTracksCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ArtTracksCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArtTracksCount.Name = "ArtTracksCount";
            this.ArtTracksCount.Size = new System.Drawing.Size(120, 23);
            this.ArtTracksCount.TabIndex = 3;
            this.ArtTracksCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Art Tracks:";
            // 
            // BPMNum
            // 
            this.BPMNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BPMNum.Location = new System.Drawing.Point(355, 141);
            this.BPMNum.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.BPMNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BPMNum.Name = "BPMNum";
            this.BPMNum.Size = new System.Drawing.Size(120, 23);
            this.BPMNum.TabIndex = 5;
            this.BPMNum.Value = new decimal(new int[] {
            138,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "BPM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "PPQ:";
            // 
            // PPQBox
            // 
            this.PPQBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PPQBox.FormattingEnabled = true;
            this.PPQBox.Items.AddRange(new object[] {
            "96",
            "192",
            "240",
            "480",
            "960",
            "1920",
            "3840",
            "8192"});
            this.PPQBox.Location = new System.Drawing.Point(103, 140);
            this.PPQBox.Name = "PPQBox";
            this.PPQBox.Size = new System.Drawing.Size(120, 23);
            this.PPQBox.TabIndex = 4;
            // 
            // DrumsChk
            // 
            this.DrumsChk.AutoSize = true;
            this.DrumsChk.Location = new System.Drawing.Point(12, 182);
            this.DrumsChk.Name = "DrumsChk";
            this.DrumsChk.Size = new System.Drawing.Size(144, 19);
            this.DrumsChk.TabIndex = 6;
            this.DrumsChk.Text = "Allow Drums channel?";
            this.DrumsChk.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(6, 45);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(451, 143);
            this.OutputBox.TabIndex = 8;
            this.OutputBox.Text = "";
            // 
            // CreateBTN
            // 
            this.CreateBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBTN.Location = new System.Drawing.Point(12, 215);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(463, 23);
            this.CreateBTN.TabIndex = 7;
            this.CreateBTN.Text = "Create";
            this.CreateBTN.UseVisualStyleBackColor = true;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CommandTXT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OutputBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 194);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // CommandTXT
            // 
            this.CommandTXT.Location = new System.Drawing.Point(79, 16);
            this.CommandTXT.Name = "CommandTXT";
            this.CommandTXT.ReadOnly = true;
            this.CommandTXT.Size = new System.Drawing.Size(378, 23);
            this.CommandTXT.TabIndex = 10;
            this.CommandTXT.Text = "Waiting";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Command:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableTimerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Input Path:";
            // 
            // InputBrowseBTN
            // 
            this.InputBrowseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBrowseBTN.Location = new System.Drawing.Point(375, 30);
            this.InputBrowseBTN.Name = "InputBrowseBTN";
            this.InputBrowseBTN.Size = new System.Drawing.Size(100, 23);
            this.InputBrowseBTN.TabIndex = 18;
            this.InputBrowseBTN.Text = "Browse";
            this.InputBrowseBTN.UseVisualStyleBackColor = true;
            this.InputBrowseBTN.Click += new System.EventHandler(this.InputBrowseBTN_Click);
            // 
            // InputPathTXT
            // 
            this.InputPathTXT.AllowDrop = true;
            this.InputPathTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPathTXT.Location = new System.Drawing.Point(93, 31);
            this.InputPathTXT.Name = "InputPathTXT";
            this.InputPathTXT.Size = new System.Drawing.Size(276, 23);
            this.InputPathTXT.TabIndex = 17;
            // 
            // enableTimerToolStripMenuItem
            // 
            this.enableTimerToolStripMenuItem.CheckOnClick = true;
            this.enableTimerToolStripMenuItem.Name = "enableTimerToolStripMenuItem";
            this.enableTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableTimerToolStripMenuItem.Text = "Enable timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 446);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InputBrowseBTN);
            this.Controls.Add(this.InputPathTXT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.DrumsChk);
            this.Controls.Add(this.PPQBox);
            this.Controls.Add(this.BPMNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArtTracksCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MelodyTrackCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.OutputPathTXT);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Empty Track Creator GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MelodyTrackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtTracksCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPMNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputPathTXT;
        private Button BrowseBTN;
        private Label label1;
        private Label label2;
        private NumericUpDown MelodyTrackCount;
        private NumericUpDown ArtTracksCount;
        private Label label3;
        private NumericUpDown BPMNum;
        private Label label4;
        private Label label5;
        private ComboBox PPQBox;
        private CheckBox DrumsChk;
        private ToolTip toolTip1;
        private RichTextBox OutputBox;
        private Button CreateBTN;
        private GroupBox groupBox1;
        private TextBox CommandTXT;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label7;
        private Button InputBrowseBTN;
        private TextBox InputPathTXT;
        private ToolStripMenuItem enableTimerToolStripMenuItem;
    }
}