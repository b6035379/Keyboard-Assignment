namespace Keyboard_Assignment
{
    partial class FormMainWindow
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
            this.lstMode = new System.Windows.Forms.ListBox();
            this.btnEmpty1 = new System.Windows.Forms.Button();
            this.btnAsterix = new System.Windows.Forms.Button();
            this.btn000 = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEmpty2 = new System.Windows.Forms.Button();
            this.btnSendPredicted = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.rtxtBuilder = new System.Windows.Forms.RichTextBox();
            this.txtNotepad = new System.Windows.Forms.TextBox();
            this.txtCharChosen = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMode
            // 
            this.lstMode.FormattingEnabled = true;
            this.lstMode.Items.AddRange(new object[] {
            "Multi-Press",
            "Prediction"});
            this.lstMode.Location = new System.Drawing.Point(519, 281);
            this.lstMode.Name = "lstMode";
            this.lstMode.Size = new System.Drawing.Size(64, 69);
            this.lstMode.TabIndex = 105;
            this.lstMode.Visible = false;
            // 
            // btnEmpty1
            // 
            this.btnEmpty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEmpty1.Location = new System.Drawing.Point(192, 108);
            this.btnEmpty1.Name = "btnEmpty1";
            this.btnEmpty1.Size = new System.Drawing.Size(61, 53);
            this.btnEmpty1.TabIndex = 92;
            this.btnEmpty1.UseVisualStyleBackColor = false;
            // 
            // btnAsterix
            // 
            this.btnAsterix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAsterix.Location = new System.Drawing.Point(9, 214);
            this.btnAsterix.Name = "btnAsterix";
            this.btnAsterix.Size = new System.Drawing.Size(61, 53);
            this.btnAsterix.TabIndex = 91;
            this.btnAsterix.Text = "* - _";
            this.btnAsterix.UseVisualStyleBackColor = false;
            this.btnAsterix.Click += new System.EventHandler(this.btnAsterix_Click);
            // 
            // btn000
            // 
            this.btn000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn000.Location = new System.Drawing.Point(70, 214);
            this.btn000.Name = "btn000";
            this.btn000.Size = new System.Drawing.Size(61, 53);
            this.btn000.TabIndex = 90;
            this.btn000.Text = "000\r\n[_]";
            this.btn000.UseVisualStyleBackColor = false;
            this.btn000.Click += new System.EventHandler(this.btn000_Click);
            // 
            // btnHash
            // 
            this.btnHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHash.Location = new System.Drawing.Point(131, 214);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(61, 53);
            this.btnHash.TabIndex = 89;
            this.btnHash.Text = "#\r\n0 00";
            this.btnHash.UseVisualStyleBackColor = false;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(192, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(61, 20);
            this.txtStatus.TabIndex = 88;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnter.Location = new System.Drawing.Point(192, 161);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(61, 106);
            this.btnEnter.TabIndex = 87;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnEmpty2
            // 
            this.btnEmpty2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEmpty2.Location = new System.Drawing.Point(192, 56);
            this.btnEmpty2.Name = "btnEmpty2";
            this.btnEmpty2.Size = new System.Drawing.Size(61, 53);
            this.btnEmpty2.TabIndex = 86;
            this.btnEmpty2.UseVisualStyleBackColor = false;
            // 
            // btnSendPredicted
            // 
            this.btnSendPredicted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSendPredicted.Location = new System.Drawing.Point(192, 3);
            this.btnSendPredicted.Name = "btnSendPredicted";
            this.btnSendPredicted.Size = new System.Drawing.Size(61, 53);
            this.btnSendPredicted.TabIndex = 85;
            this.btnSendPredicted.Text = "Send\r\nPre-\r\ndicted";
            this.btnSendPredicted.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn1.Location = new System.Drawing.Point(9, 162);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 53);
            this.btn1.TabIndex = 84;
            this.btn1.Text = "1\r\nPQRS";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn2.Location = new System.Drawing.Point(70, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 53);
            this.btn2.TabIndex = 83;
            this.btn2.Text = "2\r\nTUV";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn3.Location = new System.Drawing.Point(131, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 53);
            this.btn3.TabIndex = 82;
            this.btn3.Text = "3\r\nWXYZ";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn4.Location = new System.Drawing.Point(9, 109);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(61, 53);
            this.btn4.TabIndex = 81;
            this.btn4.Text = "4\r\nGHI";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn5.Location = new System.Drawing.Point(70, 109);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(61, 53);
            this.btn5.TabIndex = 80;
            this.btn5.Text = "5\r\nJKL";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn6.Location = new System.Drawing.Point(131, 109);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(61, 53);
            this.btn6.TabIndex = 79;
            this.btn6.Text = "6\r\nMNO";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn7.Location = new System.Drawing.Point(9, 56);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(61, 53);
            this.btn7.TabIndex = 78;
            this.btn7.Text = "7\r\n.,\"";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn8.Location = new System.Drawing.Point(70, 56);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(61, 53);
            this.btn8.TabIndex = 77;
            this.btn8.Text = "8\r\nABC";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn9.Location = new System.Drawing.Point(131, 56);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(61, 53);
            this.btn9.TabIndex = 76;
            this.btn9.Text = "9\r\nDEF";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Aqua;
            this.btnPrevious.Location = new System.Drawing.Point(131, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(61, 53);
            this.btnPrevious.TabIndex = 75;
            this.btnPrevious.Text = "Prev-\r\nious";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Aqua;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(70, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 53);
            this.btnNext.TabIndex = 74;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.Aqua;
            this.btnMode.Location = new System.Drawing.Point(9, 3);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(61, 53);
            this.btnMode.TabIndex = 73;
            this.btnMode.Text = "Mode";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // rtxtBuilder
            // 
            this.rtxtBuilder.Location = new System.Drawing.Point(9, 4);
            this.rtxtBuilder.Name = "rtxtBuilder";
            this.rtxtBuilder.Size = new System.Drawing.Size(177, 20);
            this.rtxtBuilder.TabIndex = 72;
            this.rtxtBuilder.Text = "";
            // 
            // txtNotepad
            // 
            this.txtNotepad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotepad.Location = new System.Drawing.Point(12, 9);
            this.txtNotepad.Multiline = true;
            this.txtNotepad.Name = "txtNotepad";
            this.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotepad.Size = new System.Drawing.Size(663, 194);
            this.txtNotepad.TabIndex = 71;
            this.txtNotepad.TextChanged += new System.EventHandler(this.txtNotepad_TextChanged);
            // 
            // txtCharChosen
            // 
            this.txtCharChosen.Location = new System.Drawing.Point(509, 387);
            this.txtCharChosen.Name = "txtCharChosen";
            this.txtCharChosen.Size = new System.Drawing.Size(106, 20);
            this.txtCharChosen.TabIndex = 106;
            this.txtCharChosen.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 107;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "&Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnMode);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnEmpty1);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btnAsterix);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn000);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnHash);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnEmpty2);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnSendPredicted);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(209, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 274);
            this.panel1.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.rtxtBuilder);
            this.panel2.Location = new System.Drawing.Point(209, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 30);
            this.panel2.TabIndex = 109;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtNotepad);
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 215);
            this.panel3.TabIndex = 110;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(692, 587);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCharChosen);
            this.Controls.Add(this.lstMode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyboard Application";
            this.Load += new System.EventHandler(this.Form_MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMode;
        private System.Windows.Forms.Button btnEmpty1;
        private System.Windows.Forms.Button btnAsterix;
        private System.Windows.Forms.Button btn000;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEmpty2;
        private System.Windows.Forms.Button btnSendPredicted;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.RichTextBox rtxtBuilder;
        private System.Windows.Forms.TextBox txtNotepad;
        private System.Windows.Forms.TextBox txtCharChosen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

    }
}

