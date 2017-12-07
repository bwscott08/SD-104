namespace Hangman_GUI
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPlayer = new System.Windows.Forms.TextBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.pnlCreatePlayer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnWhosPlaying = new System.Windows.Forms.Label();
            this.btnSelectPlayer = new System.Windows.Forms.Button();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.pnlCreatePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // txtNewPlayer
            // 
            this.txtNewPlayer.Location = new System.Drawing.Point(223, 27);
            this.txtNewPlayer.Name = "txtNewPlayer";
            this.txtNewPlayer.Size = new System.Drawing.Size(228, 20);
            this.txtNewPlayer.TabIndex = 1;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreatePlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreatePlayer.Location = new System.Drawing.Point(352, 193);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(306, 63);
            this.btnCreatePlayer.TabIndex = 2;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = false;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // pnlCreatePlayer
            // 
            this.pnlCreatePlayer.Controls.Add(this.btnCancel);
            this.pnlCreatePlayer.Controls.Add(this.btnCreatePlayer);
            this.pnlCreatePlayer.Controls.Add(this.txtNewPlayer);
            this.pnlCreatePlayer.Controls.Add(this.label1);
            this.pnlCreatePlayer.Location = new System.Drawing.Point(88, 238);
            this.pnlCreatePlayer.Name = "pnlCreatePlayer";
            this.pnlCreatePlayer.Size = new System.Drawing.Size(661, 259);
            this.pnlCreatePlayer.TabIndex = 3;
            this.pnlCreatePlayer.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(0, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(306, 63);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnWhosPlaying
            // 
            this.btnWhosPlaying.AutoSize = true;
            this.btnWhosPlaying.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhosPlaying.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWhosPlaying.Location = new System.Drawing.Point(146, 103);
            this.btnWhosPlaying.Name = "btnWhosPlaying";
            this.btnWhosPlaying.Size = new System.Drawing.Size(138, 27);
            this.btnWhosPlaying.TabIndex = 4;
            this.btnWhosPlaying.Text = "Who\'s Playing:";
            // 
            // btnSelectPlayer
            // 
            this.btnSelectPlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelectPlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelectPlayer.Location = new System.Drawing.Point(311, 160);
            this.btnSelectPlayer.Name = "btnSelectPlayer";
            this.btnSelectPlayer.Size = new System.Drawing.Size(105, 63);
            this.btnSelectPlayer.TabIndex = 5;
            this.btnSelectPlayer.Text = "Ok";
            this.btnSelectPlayer.UseVisualStyleBackColor = false;
            this.btnSelectPlayer.Click += new System.EventHandler(this.btnSelectPlayer_Click);
            // 
            // cbPlayer
            // 
            this.cbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(311, 108);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(228, 21);
            this.cbPlayer.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(860, 563);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.btnSelectPlayer);
            this.Controls.Add(this.btnWhosPlaying);
            this.Controls.Add(this.pnlCreatePlayer);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCreatePlayer.ResumeLayout(false);
            this.pnlCreatePlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPlayer;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Panel pnlCreatePlayer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label btnWhosPlaying;
        private System.Windows.Forms.Button btnSelectPlayer;
        private System.Windows.Forms.ComboBox cbPlayer;
    }
}