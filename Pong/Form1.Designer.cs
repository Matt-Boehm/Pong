namespace Pong
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
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.CPU = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerScore = new System.Windows.Forms.Label();
            this.CPUScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Player1.Location = new System.Drawing.Point(12, 186);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(27, 127);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ball.Location = new System.Drawing.Point(434, 239);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(27, 26);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // CPU
            // 
            this.CPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CPU.Location = new System.Drawing.Point(897, 230);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(27, 127);
            this.CPU.TabIndex = 2;
            this.CPU.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerScore.Location = new System.Drawing.Point(105, 9);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(38, 25);
            this.PlayerScore.TabIndex = 3;
            this.PlayerScore.Text = "00";
            this.PlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUScore
            // 
            this.CPUScore.AutoSize = true;
            this.CPUScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CPUScore.Location = new System.Drawing.Point(735, 9);
            this.CPUScore.Name = "CPUScore";
            this.CPUScore.Size = new System.Drawing.Size(38, 25);
            this.CPUScore.TabIndex = 4;
            this.CPUScore.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.CPUScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player1);
            this.Name = "Form1";
            this.Text = "Pong Game";
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Player1;
        private PictureBox Ball;
        private PictureBox CPU;
        private System.Windows.Forms.Timer GameTimer;
        private Label PlayerScore;
        private Label CPUScore;
    }
}