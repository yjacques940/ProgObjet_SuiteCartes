namespace jeuSuites
{
    partial class leJeuDeSuiteForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.timeRemainingGroupBox = new System.Windows.Forms.GroupBox();
            this.timeRemainingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remainingTimeLabel.Location = new System.Drawing.Point(3, 16);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(86, 13);
            this.remainingTimeLabel.TabIndex = 1;
            this.remainingTimeLabel.Text = "[TimeRemaining]";
            // 
            // timeRemainingGroupBox
            // 
            this.timeRemainingGroupBox.Controls.Add(this.remainingTimeLabel);
            this.timeRemainingGroupBox.Location = new System.Drawing.Point(352, 12);
            this.timeRemainingGroupBox.Name = "timeRemainingGroupBox";
            this.timeRemainingGroupBox.Size = new System.Drawing.Size(80, 37);
            this.timeRemainingGroupBox.TabIndex = 2;
            this.timeRemainingGroupBox.TabStop = false;
            this.timeRemainingGroupBox.Text = "Temps ";
            // 
            // leJeuDeSuiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 285);
            this.Controls.Add(this.timeRemainingGroupBox);
            this.Name = "leJeuDeSuiteForm";
            this.Text = "Form1";
            this.timeRemainingGroupBox.ResumeLayout(false);
            this.timeRemainingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.GroupBox timeRemainingGroupBox;
    }
}

