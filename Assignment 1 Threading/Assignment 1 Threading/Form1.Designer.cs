namespace Assignment_1_Threading
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Display_Stop = new System.Windows.Forms.Button();
            this.btn_Display_Start = new System.Windows.Forms.Button();
            this.pnl_Display = new System.Windows.Forms.Panel();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Triangle_Stop = new System.Windows.Forms.Button();
            this.btn_Triangle_Start = new System.Windows.Forms.Button();
            this.pnl_Rectangle = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_Display.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_FilePath);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.btn_Play);
            this.groupBox1.Controls.Add(this.btn_Open);
            this.groupBox1.Location = new System.Drawing.Point(50, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Music Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Path:";
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(161, 62);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(0, 20);
            this.lbl_FilePath.TabIndex = 3;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(445, 132);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(117, 37);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(308, 132);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(105, 37);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(165, 132);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(103, 37);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Display_Stop);
            this.groupBox2.Controls.Add(this.btn_Display_Start);
            this.groupBox2.Controls.Add(this.pnl_Display);
            this.groupBox2.Location = new System.Drawing.Point(50, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Message";
            // 
            // btn_Display_Stop
            // 
            this.btn_Display_Stop.Location = new System.Drawing.Point(219, 273);
            this.btn_Display_Stop.Name = "btn_Display_Stop";
            this.btn_Display_Stop.Size = new System.Drawing.Size(101, 38);
            this.btn_Display_Stop.TabIndex = 2;
            this.btn_Display_Stop.Text = "Pause";
            this.btn_Display_Stop.UseVisualStyleBackColor = true;
            this.btn_Display_Stop.Click += new System.EventHandler(this.btn_Display_Stop_Click);
            // 
            // btn_Display_Start
            // 
            this.btn_Display_Start.Location = new System.Drawing.Point(77, 273);
            this.btn_Display_Start.Name = "btn_Display_Start";
            this.btn_Display_Start.Size = new System.Drawing.Size(108, 38);
            this.btn_Display_Start.TabIndex = 1;
            this.btn_Display_Start.Text = "Start";
            this.btn_Display_Start.UseVisualStyleBackColor = true;
            this.btn_Display_Start.Click += new System.EventHandler(this.btn_Display_Start_Click);
            // 
            // pnl_Display
            // 
            this.pnl_Display.Controls.Add(this.lbl_Message);
            this.pnl_Display.Location = new System.Drawing.Point(6, 25);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(455, 242);
            this.pnl_Display.TabIndex = 0;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(179, 119);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 20);
            this.lbl_Message.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Triangle_Stop);
            this.groupBox3.Controls.Add(this.btn_Triangle_Start);
            this.groupBox3.Controls.Add(this.pnl_Rectangle);
            this.groupBox3.Location = new System.Drawing.Point(604, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 323);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangle Thread";
            // 
            // btn_Triangle_Stop
            // 
            this.btn_Triangle_Stop.Location = new System.Drawing.Point(221, 273);
            this.btn_Triangle_Stop.Name = "btn_Triangle_Stop";
            this.btn_Triangle_Stop.Size = new System.Drawing.Size(103, 38);
            this.btn_Triangle_Stop.TabIndex = 2;
            this.btn_Triangle_Stop.Text = "Pause";
            this.btn_Triangle_Stop.UseVisualStyleBackColor = true;
            this.btn_Triangle_Stop.Click += new System.EventHandler(this.btn_Triangle_Stop_Click);
            // 
            // btn_Triangle_Start
            // 
            this.btn_Triangle_Start.Location = new System.Drawing.Point(93, 273);
            this.btn_Triangle_Start.Name = "btn_Triangle_Start";
            this.btn_Triangle_Start.Size = new System.Drawing.Size(104, 38);
            this.btn_Triangle_Start.TabIndex = 1;
            this.btn_Triangle_Start.Text = "Start";
            this.btn_Triangle_Start.UseVisualStyleBackColor = true;
            this.btn_Triangle_Start.Click += new System.EventHandler(this.btn_Triangle_Start_Click);
            // 
            // pnl_Rectangle
            // 
            this.pnl_Rectangle.Location = new System.Drawing.Point(7, 26);
            this.pnl_Rectangle.Name = "pnl_Rectangle";
            this.pnl_Rectangle.Size = new System.Drawing.Size(427, 241);
            this.pnl_Rectangle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "JPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnl_Display.ResumeLayout(false);
            this.pnl_Display.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Display_Stop;
        private System.Windows.Forms.Button btn_Display_Start;
        private System.Windows.Forms.Panel pnl_Display;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Triangle_Stop;
        private System.Windows.Forms.Button btn_Triangle_Start;
        private System.Windows.Forms.Panel pnl_Rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Message;
    }
}

