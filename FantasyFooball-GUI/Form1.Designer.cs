namespace FantasyFooball_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbPassYds = new System.Windows.Forms.TextBox();
            this.PassingYDS = new System.Windows.Forms.Label();
            this.Interceptions = new System.Windows.Forms.Label();
            this.PassingTds = new System.Windows.Forms.Label();
            this.RushingYds = new System.Windows.Forms.Label();
            this.RushingTds = new System.Windows.Forms.Label();
            this.ReceivingYds = new System.Windows.Forms.Label();
            this.ReceivingTds = new System.Windows.Forms.Label();
            this.txbInterceptions = new System.Windows.Forms.TextBox();
            this.txbPassTds = new System.Windows.Forms.TextBox();
            this.txbRushingYds = new System.Windows.Forms.TextBox();
            this.txbRushTds = new System.Windows.Forms.TextBox();
            this.txbRecYds = new System.Windows.Forms.TextBox();
            this.txbReceivingTds = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPassYds
            // 
            this.txbPassYds.BackColor = System.Drawing.Color.White;
            this.txbPassYds.Location = new System.Drawing.Point(179, 132);
            this.txbPassYds.Name = "txbPassYds";
            this.txbPassYds.Size = new System.Drawing.Size(100, 20);
            this.txbPassYds.TabIndex = 4;
            // 
            // PassingYDS
            // 
            this.PassingYDS.AutoSize = true;
            this.PassingYDS.BackColor = System.Drawing.Color.Blue;
            this.PassingYDS.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassingYDS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PassingYDS.Location = new System.Drawing.Point(13, 131);
            this.PassingYDS.Name = "PassingYDS";
            this.PassingYDS.Size = new System.Drawing.Size(147, 21);
            this.PassingYDS.TabIndex = 5;
            this.PassingYDS.Text = "Enter passing yards";
            // 
            // Interceptions
            // 
            this.Interceptions.AutoSize = true;
            this.Interceptions.BackColor = System.Drawing.Color.MediumBlue;
            this.Interceptions.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interceptions.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Interceptions.Location = new System.Drawing.Point(11, 278);
            this.Interceptions.Name = "Interceptions";
            this.Interceptions.Size = new System.Drawing.Size(143, 21);
            this.Interceptions.TabIndex = 6;
            this.Interceptions.Text = "Enter interceptions";
            // 
            // PassingTds
            // 
            this.PassingTds.AutoSize = true;
            this.PassingTds.BackColor = System.Drawing.Color.MediumBlue;
            this.PassingTds.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassingTds.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PassingTds.Location = new System.Drawing.Point(13, 202);
            this.PassingTds.Name = "PassingTds";
            this.PassingTds.Size = new System.Drawing.Size(148, 21);
            this.PassingTds.TabIndex = 7;
            this.PassingTds.Text = "Enter passing TD\'s";
            // 
            // RushingYds
            // 
            this.RushingYds.AutoSize = true;
            this.RushingYds.BackColor = System.Drawing.Color.MediumBlue;
            this.RushingYds.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushingYds.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RushingYds.Location = new System.Drawing.Point(9, 348);
            this.RushingYds.Name = "RushingYds";
            this.RushingYds.Size = new System.Drawing.Size(145, 21);
            this.RushingYds.TabIndex = 8;
            this.RushingYds.Text = "Enter rushing yards";
            // 
            // RushingTds
            // 
            this.RushingTds.AutoSize = true;
            this.RushingTds.BackColor = System.Drawing.Color.MediumBlue;
            this.RushingTds.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushingTds.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RushingTds.Location = new System.Drawing.Point(8, 411);
            this.RushingTds.Name = "RushingTds";
            this.RushingTds.Size = new System.Drawing.Size(146, 21);
            this.RushingTds.TabIndex = 9;
            this.RushingTds.Text = "Enter rushing TD\'s";
            // 
            // ReceivingYds
            // 
            this.ReceivingYds.AutoSize = true;
            this.ReceivingYds.BackColor = System.Drawing.Color.MediumBlue;
            this.ReceivingYds.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivingYds.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReceivingYds.Location = new System.Drawing.Point(5, 474);
            this.ReceivingYds.Name = "ReceivingYds";
            this.ReceivingYds.Size = new System.Drawing.Size(155, 21);
            this.ReceivingYds.TabIndex = 10;
            this.ReceivingYds.Text = "Enter receiving yards";
            // 
            // ReceivingTds
            // 
            this.ReceivingTds.AutoSize = true;
            this.ReceivingTds.BackColor = System.Drawing.Color.MediumBlue;
            this.ReceivingTds.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivingTds.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReceivingTds.Location = new System.Drawing.Point(4, 541);
            this.ReceivingTds.Name = "ReceivingTds";
            this.ReceivingTds.Size = new System.Drawing.Size(156, 21);
            this.ReceivingTds.TabIndex = 11;
            this.ReceivingTds.Text = "Enter receiving TD\'s";
            // 
            // txbInterceptions
            // 
            this.txbInterceptions.BackColor = System.Drawing.Color.White;
            this.txbInterceptions.Location = new System.Drawing.Point(179, 279);
            this.txbInterceptions.Name = "txbInterceptions";
            this.txbInterceptions.Size = new System.Drawing.Size(100, 20);
            this.txbInterceptions.TabIndex = 12;
            // 
            // txbPassTds
            // 
            this.txbPassTds.BackColor = System.Drawing.Color.White;
            this.txbPassTds.Location = new System.Drawing.Point(179, 203);
            this.txbPassTds.Name = "txbPassTds";
            this.txbPassTds.Size = new System.Drawing.Size(100, 20);
            this.txbPassTds.TabIndex = 13;
            // 
            // txbRushingYds
            // 
            this.txbRushingYds.BackColor = System.Drawing.Color.White;
            this.txbRushingYds.Location = new System.Drawing.Point(179, 349);
            this.txbRushingYds.Name = "txbRushingYds";
            this.txbRushingYds.Size = new System.Drawing.Size(100, 20);
            this.txbRushingYds.TabIndex = 14;
            // 
            // txbRushTds
            // 
            this.txbRushTds.BackColor = System.Drawing.Color.White;
            this.txbRushTds.Location = new System.Drawing.Point(179, 412);
            this.txbRushTds.Name = "txbRushTds";
            this.txbRushTds.Size = new System.Drawing.Size(100, 20);
            this.txbRushTds.TabIndex = 15;
            // 
            // txbRecYds
            // 
            this.txbRecYds.BackColor = System.Drawing.Color.White;
            this.txbRecYds.Location = new System.Drawing.Point(179, 478);
            this.txbRecYds.Name = "txbRecYds";
            this.txbRecYds.Size = new System.Drawing.Size(100, 20);
            this.txbRecYds.TabIndex = 16;
            // 
            // txbReceivingTds
            // 
            this.txbReceivingTds.BackColor = System.Drawing.Color.White;
            this.txbReceivingTds.Location = new System.Drawing.Point(179, 542);
            this.txbReceivingTds.Name = "txbReceivingTds";
            this.txbReceivingTds.Size = new System.Drawing.Size(100, 20);
            this.txbReceivingTds.TabIndex = 17;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.DarkRed;
            this.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTotal.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTotal.Location = new System.Drawing.Point(425, 401);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(304, 172);
            this.btnTotal.TabIndex = 18;
            this.btnTotal.Text = "Click to get fantasy total!";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "WELCOME TO FANTASY GENIE";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtDisplay.Location = new System.Drawing.Point(387, 358);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(373, 37);
            this.txtDisplay.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(981, 573);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txbReceivingTds);
            this.Controls.Add(this.txbRecYds);
            this.Controls.Add(this.txbRushTds);
            this.Controls.Add(this.txbRushingYds);
            this.Controls.Add(this.txbPassTds);
            this.Controls.Add(this.txbInterceptions);
            this.Controls.Add(this.ReceivingTds);
            this.Controls.Add(this.ReceivingYds);
            this.Controls.Add(this.RushingTds);
            this.Controls.Add(this.RushingYds);
            this.Controls.Add(this.PassingTds);
            this.Controls.Add(this.Interceptions);
            this.Controls.Add(this.PassingYDS);
            this.Controls.Add(this.txbPassYds);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassYds;
        private System.Windows.Forms.Label PassingYDS;
        private System.Windows.Forms.Label Interceptions;
        private System.Windows.Forms.Label PassingTds;
        private System.Windows.Forms.Label RushingYds;
        private System.Windows.Forms.Label RushingTds;
        private System.Windows.Forms.Label ReceivingYds;
        private System.Windows.Forms.Label ReceivingTds;
        private System.Windows.Forms.TextBox txbInterceptions;
        private System.Windows.Forms.TextBox txbPassTds;
        private System.Windows.Forms.TextBox txbRushingYds;
        private System.Windows.Forms.TextBox txbRushTds;
        private System.Windows.Forms.TextBox txbRecYds;
        private System.Windows.Forms.TextBox txbReceivingTds;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

