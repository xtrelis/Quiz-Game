namespace QuizGame
{
    partial class FrmQuizGame
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
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.MediumBlue;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Location = new System.Drawing.Point(179, 258);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(120, 50);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.MediumBlue;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.Location = new System.Drawing.Point(12, 299);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(120, 50);
            this.BtnInfo.TabIndex = 2;
            this.BtnInfo.Text = "Info";
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MediumBlue;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(352, 299);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(120, 50);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmQuizGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizGame.Properties.Resources.frmQuizImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.BtnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuizGame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quiz Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnExit;
    }
}

