namespace Checkers
{
    partial class Field
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pawn = new Checkers.Pawn();
            this.LeftBorderPanel = new System.Windows.Forms.Panel();
            this.RightBorderPanel = new System.Windows.Forms.Panel();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Pawn
            // 
            this.Pawn.BackColor = System.Drawing.Color.Transparent;
            this.Pawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pawn.Location = new System.Drawing.Point(0, 0);
            this.Pawn.Margin = new System.Windows.Forms.Padding(0);
            this.Pawn.Name = "Pawn";
            this.Pawn.Size = new System.Drawing.Size(60, 60);
            this.Pawn.TabIndex = 0;
            // 
            // LeftBorderPanel
            // 
            this.LeftBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorderPanel.Location = new System.Drawing.Point(0, 1);
            this.LeftBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftBorderPanel.Name = "LeftBorderPanel";
            this.LeftBorderPanel.Size = new System.Drawing.Size(1, 58);
            this.LeftBorderPanel.TabIndex = 2;
            // 
            // RightBorderPanel
            // 
            this.RightBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightBorderPanel.Location = new System.Drawing.Point(59, 0);
            this.RightBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightBorderPanel.Name = "RightBorderPanel";
            this.RightBorderPanel.Size = new System.Drawing.Size(1, 60);
            this.RightBorderPanel.TabIndex = 4;
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(60, 1);
            this.TopBorderPanel.TabIndex = 5;
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel.Location = new System.Drawing.Point(0, 59);
            this.BottomBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(60, 1);
            this.BottomBorderPanel.TabIndex = 6;
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LeftBorderPanel);
            this.Controls.Add(this.RightBorderPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.Pawn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Field";
            this.Size = new System.Drawing.Size(60, 60);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Field_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        public Pawn Pawn;
        private System.Windows.Forms.Panel LeftBorderPanel;
        private System.Windows.Forms.Panel RightBorderPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel BottomBorderPanel;
    }
}
