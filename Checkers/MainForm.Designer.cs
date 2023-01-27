namespace Checkers
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            this.TilebarPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BgPanel = new System.Windows.Forms.Panel();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.MoveCounterLabel = new System.Windows.Forms.Label();
            this.MoveCountLabel = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.Turn1Label = new System.Windows.Forms.Label();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.TilebarPanel.SuspendLayout();
            this.BgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TilebarPanel
            // 
            this.TilebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.TilebarPanel.Controls.Add(this.MinimizeBtn);
            this.TilebarPanel.Controls.Add(this.TitleLabel);
            this.TilebarPanel.Controls.Add(this.ExitBtn);
            this.TilebarPanel.Location = new System.Drawing.Point(1, 1);
            this.TilebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TilebarPanel.Name = "TilebarPanel";
            this.TilebarPanel.Size = new System.Drawing.Size(798, 31);
            this.TilebarPanel.TabIndex = 0;
            this.TilebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.MinimizeBtn.Location = new System.Drawing.Point(706, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(43, 31);
            this.MinimizeBtn.TabIndex = 3;
            this.MinimizeBtn.Text = "−";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLabel.Location = new System.Drawing.Point(8, 2);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(89, 25);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Warcaby";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitBtn.Location = new System.Drawing.Point(757, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(43, 31);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "✕";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BgPanel
            // 
            this.BgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.BgPanel.Controls.Add(this.WinnerLabel);
            this.BgPanel.Controls.Add(this.MoveCounterLabel);
            this.BgPanel.Controls.Add(this.MoveCountLabel);
            this.BgPanel.Controls.Add(this.RestartBtn);
            this.BgPanel.Controls.Add(this.TurnLabel);
            this.BgPanel.Controls.Add(this.Turn1Label);
            this.BgPanel.Controls.Add(this.BoardPanel);
            this.BgPanel.Location = new System.Drawing.Point(1, 32);
            this.BgPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BgPanel.Name = "BgPanel";
            this.BgPanel.Size = new System.Drawing.Size(798, 567);
            this.BgPanel.TabIndex = 1;
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinnerLabel.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinnerLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.WinnerLabel.Location = new System.Drawing.Point(513, 239);
            this.WinnerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(0, 35);
            this.WinnerLabel.TabIndex = 8;
            // 
            // MoveCounterLabel
            // 
            this.MoveCounterLabel.AutoSize = true;
            this.MoveCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoveCounterLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveCounterLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.MoveCounterLabel.Location = new System.Drawing.Point(622, 174);
            this.MoveCounterLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MoveCounterLabel.Name = "MoveCounterLabel";
            this.MoveCounterLabel.Size = new System.Drawing.Size(34, 39);
            this.MoveCounterLabel.TabIndex = 7;
            this.MoveCounterLabel.Text = "0";
            // 
            // MoveCountLabel
            // 
            this.MoveCountLabel.AutoSize = true;
            this.MoveCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoveCountLabel.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MoveCountLabel.Location = new System.Drawing.Point(550, 179);
            this.MoveCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MoveCountLabel.Name = "MoveCountLabel";
            this.MoveCountLabel.Size = new System.Drawing.Size(72, 28);
            this.MoveCountLabel.TabIndex = 6;
            this.MoveCountLabel.Text = "tury:";
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.Transparent;
            this.RestartBtn.FlatAppearance.BorderSize = 0;
            this.RestartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RestartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.RestartBtn.Location = new System.Drawing.Point(550, 464);
            this.RestartBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(199, 34);
            this.RestartBtn.TabIndex = 4;
            this.RestartBtn.Text = "Zrestartuj gre!";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.BackColor = System.Drawing.Color.Transparent;
            this.TurnLabel.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnLabel.ForeColor = System.Drawing.Color.Red;
            this.TurnLabel.Location = new System.Drawing.Point(641, 61);
            this.TurnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(143, 35);
            this.TurnLabel.TabIndex = 4;
            this.TurnLabel.Text = "Czerwony";
            // 
            // Turn1Label
            // 
            this.Turn1Label.AutoSize = true;
            this.Turn1Label.BackColor = System.Drawing.Color.Transparent;
            this.Turn1Label.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Turn1Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.Turn1Label.Location = new System.Drawing.Point(546, 61);
            this.Turn1Label.Margin = new System.Windows.Forms.Padding(0);
            this.Turn1Label.Name = "Turn1Label";
            this.Turn1Label.Size = new System.Drawing.Size(95, 35);
            this.Turn1Label.TabIndex = 3;
            this.Turn1Label.Text = "Tura:";
            // 
            // BoardPanel
            // 
            this.BoardPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.BoardPanel.Location = new System.Drawing.Point(25, 25);
            this.BoardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(482, 482);
            this.BoardPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BgPanel);
            this.Controls.Add(this.TilebarPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Warcaby";
            this.TilebarPanel.ResumeLayout(false);
            this.TilebarPanel.PerformLayout();
            this.BgPanel.ResumeLayout(false);
            this.BgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TilebarPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel BgPanel;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Label Turn1Label;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label MoveCounterLabel;
        private System.Windows.Forms.Label MoveCountLabel;
        private System.Windows.Forms.Label WinnerLabel;
    }
}
