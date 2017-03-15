namespace QuizGame
{
    partial class FrmPlay
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
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.cbxDifficulty = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxLife3 = new System.Windows.Forms.PictureBox();
            this.picBoxLife2 = new System.Windows.Forms.PictureBox();
            this.picBoxLife1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.Color.MediumBlue;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbxCategory.ForeColor = System.Drawing.Color.White;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(13, 47);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 33);
            this.cbxCategory.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(421, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(117, 31);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Count: 0";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtQuestion.Location = new System.Drawing.Point(13, 275);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(560, 60);
            this.txtQuestion.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtMessage.Location = new System.Drawing.Point(12, 539);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(560, 60);
            this.txtMessage.TabIndex = 8;
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.White;
            this.BtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnA.Location = new System.Drawing.Point(13, 353);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(200, 70);
            this.BtnA.TabIndex = 9;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.BackColor = System.Drawing.Color.White;
            this.BtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnB.Location = new System.Drawing.Point(12, 447);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(200, 70);
            this.BtnB.TabIndex = 10;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = false;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.White;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnC.Location = new System.Drawing.Point(372, 353);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(200, 70);
            this.BtnC.TabIndex = 11;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.BackColor = System.Drawing.Color.White;
            this.BtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnD.Location = new System.Drawing.Point(372, 447);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(200, 70);
            this.BtnD.TabIndex = 12;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = false;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.White;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnNext.Location = new System.Drawing.Point(233, 409);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(120, 50);
            this.BtnNext.TabIndex = 13;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // cbxDifficulty
            // 
            this.cbxDifficulty.BackColor = System.Drawing.Color.MediumBlue;
            this.cbxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbxDifficulty.ForeColor = System.Drawing.Color.White;
            this.cbxDifficulty.FormattingEnabled = true;
            this.cbxDifficulty.Location = new System.Drawing.Point(13, 139);
            this.cbxDifficulty.Name = "cbxDifficulty";
            this.cbxDifficulty.Size = new System.Drawing.Size(121, 33);
            this.cbxDifficulty.TabIndex = 14;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(421, 96);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(115, 31);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(421, 150);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 31);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "Timer: 0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 27);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // picBoxLife3
            // 
            this.picBoxLife3.BackgroundImage = global::QuizGame.Properties.Resources.heartPicture;
            this.picBoxLife3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLife3.Location = new System.Drawing.Point(354, 219);
            this.picBoxLife3.Name = "picBoxLife3";
            this.picBoxLife3.Size = new System.Drawing.Size(50, 50);
            this.picBoxLife3.TabIndex = 7;
            this.picBoxLife3.TabStop = false;
            // 
            // picBoxLife2
            // 
            this.picBoxLife2.BackgroundImage = global::QuizGame.Properties.Resources.heartPicture;
            this.picBoxLife2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLife2.Location = new System.Drawing.Point(268, 219);
            this.picBoxLife2.Name = "picBoxLife2";
            this.picBoxLife2.Size = new System.Drawing.Size(50, 50);
            this.picBoxLife2.TabIndex = 6;
            this.picBoxLife2.TabStop = false;
            // 
            // picBoxLife1
            // 
            this.picBoxLife1.BackgroundImage = global::QuizGame.Properties.Resources.heartPicture;
            this.picBoxLife1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLife1.Location = new System.Drawing.Point(179, 219);
            this.picBoxLife1.Name = "picBoxLife1";
            this.picBoxLife1.Size = new System.Drawing.Size(50, 50);
            this.picBoxLife1.TabIndex = 5;
            this.picBoxLife1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuizGame.Properties.Resources.frmPlayImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(165, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.cbxDifficulty);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.picBoxLife3);
            this.Controls.Add(this.picBoxLife2);
            this.Controls.Add(this.picBoxLife1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quiz Game - Play";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.PictureBox picBoxLife1;
        private System.Windows.Forms.PictureBox picBoxLife2;
        private System.Windows.Forms.PictureBox picBoxLife3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.ComboBox cbxDifficulty;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}