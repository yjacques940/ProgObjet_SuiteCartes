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
            this.card1Label = new System.Windows.Forms.Label();
            this.card2Label = new System.Windows.Forms.Label();
            this.card3Label = new System.Windows.Forms.Label();
            this.card4Label = new System.Windows.Forms.Label();
            this.card5Label = new System.Windows.Forms.Label();
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
            // card1Label
            // 
            this.card1Label.AutoSize = true;
            this.card1Label.Location = new System.Drawing.Point(52, 115);
            this.card1Label.Name = "card1Label";
            this.card1Label.Size = new System.Drawing.Size(37, 13);
            this.card1Label.TabIndex = 3;
            this.card1Label.Text = "carte1";
            // 
            // card2Label
            // 
            this.card2Label.AutoSize = true;
            this.card2Label.Location = new System.Drawing.Point(95, 115);
            this.card2Label.Name = "card2Label";
            this.card2Label.Size = new System.Drawing.Size(37, 13);
            this.card2Label.TabIndex = 4;
            this.card2Label.Text = "carte2";
            // 
            // card3Label
            // 
            this.card3Label.AutoSize = true;
            this.card3Label.Location = new System.Drawing.Point(138, 115);
            this.card3Label.Name = "card3Label";
            this.card3Label.Size = new System.Drawing.Size(37, 13);
            this.card3Label.TabIndex = 5;
            this.card3Label.Text = "carte3";
            // 
            // card4Label
            // 
            this.card4Label.AutoSize = true;
            this.card4Label.Location = new System.Drawing.Point(181, 115);
            this.card4Label.Name = "card4Label";
            this.card4Label.Size = new System.Drawing.Size(37, 13);
            this.card4Label.TabIndex = 6;
            this.card4Label.Text = "carte4";
            // 
            // card5Label
            // 
            this.card5Label.AutoSize = true;
            this.card5Label.Location = new System.Drawing.Point(224, 115);
            this.card5Label.Name = "card5Label";
            this.card5Label.Size = new System.Drawing.Size(37, 13);
            this.card5Label.TabIndex = 7;
            this.card5Label.Text = "carte5";
            // 
            // leJeuDeSuiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 285);
            this.Controls.Add(this.card5Label);
            this.Controls.Add(this.card4Label);
            this.Controls.Add(this.card3Label);
            this.Controls.Add(this.card2Label);
            this.Controls.Add(this.card1Label);
            this.Controls.Add(this.timeRemainingGroupBox);
            this.Name = "leJeuDeSuiteForm";
            this.Text = "Form1";
            this.timeRemainingGroupBox.ResumeLayout(false);
            this.timeRemainingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.GroupBox timeRemainingGroupBox;
        private System.Windows.Forms.Label card1Label;
        private System.Windows.Forms.Label card2Label;
        private System.Windows.Forms.Label card3Label;
        private System.Windows.Forms.Label card4Label;
        private System.Windows.Forms.Label card5Label;
    }
}

