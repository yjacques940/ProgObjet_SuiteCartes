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
            this.nombreDeSuitesGenereesLabel = new System.Windows.Forms.Label();
            this.nombreDeSuiteGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPointsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.lastHandGroupBox = new System.Windows.Forms.GroupBox();
            this.lastHandPointsLabel = new System.Windows.Forms.Label();
            this.numberOfFailuresGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfFailuresLabel = new System.Windows.Forms.Label();
            this.timeRemainingGroupBox.SuspendLayout();
            this.nombreDeSuiteGroupBox.SuspendLayout();
            this.totalPointsGroupBox.SuspendLayout();
            this.lastHandGroupBox.SuspendLayout();
            this.numberOfFailuresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remainingTimeLabel.Location = new System.Drawing.Point(3, 16);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.remainingTimeLabel.TabIndex = 1;
            this.remainingTimeLabel.Text = "[sec]";
            // 
            // timeRemainingGroupBox
            // 
            this.timeRemainingGroupBox.Controls.Add(this.remainingTimeLabel);
            this.timeRemainingGroupBox.Location = new System.Drawing.Point(122, 12);
            this.timeRemainingGroupBox.Name = "timeRemainingGroupBox";
            this.timeRemainingGroupBox.Size = new System.Drawing.Size(80, 35);
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
            // nombreDeSuitesGenereesLabel
            // 
            this.nombreDeSuitesGenereesLabel.AutoSize = true;
            this.nombreDeSuitesGenereesLabel.Location = new System.Drawing.Point(40, 16);
            this.nombreDeSuitesGenereesLabel.Name = "nombreDeSuitesGenereesLabel";
            this.nombreDeSuitesGenereesLabel.Size = new System.Drawing.Size(25, 13);
            this.nombreDeSuitesGenereesLabel.TabIndex = 1;
            this.nombreDeSuitesGenereesLabel.Text = "[nb]";
            // 
            // nombreDeSuiteGroupBox
            // 
            this.nombreDeSuiteGroupBox.Controls.Add(this.nombreDeSuitesGenereesLabel);
            this.nombreDeSuiteGroupBox.Location = new System.Drawing.Point(12, 12);
            this.nombreDeSuiteGroupBox.Name = "nombreDeSuiteGroupBox";
            this.nombreDeSuiteGroupBox.Size = new System.Drawing.Size(104, 35);
            this.nombreDeSuiteGroupBox.TabIndex = 8;
            this.nombreDeSuiteGroupBox.TabStop = false;
            this.nombreDeSuiteGroupBox.Text = "Nombre de suites";
            // 
            // totalPointsGroupBox
            // 
            this.totalPointsGroupBox.Controls.Add(this.totalPointsLabel);
            this.totalPointsGroupBox.Location = new System.Drawing.Point(211, 12);
            this.totalPointsGroupBox.Name = "totalPointsGroupBox";
            this.totalPointsGroupBox.Size = new System.Drawing.Size(88, 35);
            this.totalPointsGroupBox.TabIndex = 3;
            this.totalPointsGroupBox.TabStop = false;
            this.totalPointsGroupBox.Text = "Points Totaux";
            // 
            // totalPointsLabel
            // 
            this.totalPointsLabel.AutoSize = true;
            this.totalPointsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPointsLabel.Location = new System.Drawing.Point(3, 16);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(48, 13);
            this.totalPointsLabel.TabIndex = 1;
            this.totalPointsLabel.Text = "[totalPts]";
            // 
            // lastHandGroupBox
            // 
            this.lastHandGroupBox.Controls.Add(this.lastHandPointsLabel);
            this.lastHandGroupBox.Location = new System.Drawing.Point(305, 12);
            this.lastHandGroupBox.Name = "lastHandGroupBox";
            this.lastHandGroupBox.Size = new System.Drawing.Size(130, 35);
            this.lastHandGroupBox.TabIndex = 4;
            this.lastHandGroupBox.TabStop = false;
            this.lastHandGroupBox.Text = "Points Derniere Suite";
            // 
            // lastHandPointsLabel
            // 
            this.lastHandPointsLabel.AutoSize = true;
            this.lastHandPointsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastHandPointsLabel.Location = new System.Drawing.Point(3, 16);
            this.lastHandPointsLabel.Name = "lastHandPointsLabel";
            this.lastHandPointsLabel.Size = new System.Drawing.Size(44, 13);
            this.lastHandPointsLabel.TabIndex = 1;
            this.lastHandPointsLabel.Text = "[lastPts]";
            // 
            // numberOfFailuresGroupBox
            // 
            this.numberOfFailuresGroupBox.Controls.Add(this.numberOfFailuresLabel);
            this.numberOfFailuresGroupBox.Location = new System.Drawing.Point(12, 53);
            this.numberOfFailuresGroupBox.Name = "numberOfFailuresGroupBox";
            this.numberOfFailuresGroupBox.Size = new System.Drawing.Size(104, 35);
            this.numberOfFailuresGroupBox.TabIndex = 4;
            this.numberOfFailuresGroupBox.TabStop = false;
            this.numberOfFailuresGroupBox.Text = "Nombre d\'echecs";
            // 
            // numberOfFailuresLabel
            // 
            this.numberOfFailuresLabel.AutoSize = true;
            this.numberOfFailuresLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfFailuresLabel.Location = new System.Drawing.Point(3, 16);
            this.numberOfFailuresLabel.Name = "numberOfFailuresLabel";
            this.numberOfFailuresLabel.Size = new System.Drawing.Size(48, 13);
            this.numberOfFailuresLabel.TabIndex = 1;
            this.numberOfFailuresLabel.Text = "[totalPts]";
            // 
            // leJeuDeSuiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 285);
            this.Controls.Add(this.numberOfFailuresGroupBox);
            this.Controls.Add(this.lastHandGroupBox);
            this.Controls.Add(this.totalPointsGroupBox);
            this.Controls.Add(this.nombreDeSuiteGroupBox);
            this.Controls.Add(this.card5Label);
            this.Controls.Add(this.card4Label);
            this.Controls.Add(this.card3Label);
            this.Controls.Add(this.card2Label);
            this.Controls.Add(this.card1Label);
            this.Controls.Add(this.timeRemainingGroupBox);
            this.Name = "leJeuDeSuiteForm";
            this.Text = "Suites de cartes";
            this.timeRemainingGroupBox.ResumeLayout(false);
            this.timeRemainingGroupBox.PerformLayout();
            this.nombreDeSuiteGroupBox.ResumeLayout(false);
            this.nombreDeSuiteGroupBox.PerformLayout();
            this.totalPointsGroupBox.ResumeLayout(false);
            this.totalPointsGroupBox.PerformLayout();
            this.lastHandGroupBox.ResumeLayout(false);
            this.lastHandGroupBox.PerformLayout();
            this.numberOfFailuresGroupBox.ResumeLayout(false);
            this.numberOfFailuresGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox nombreDeSuiteGroupBox;
        private System.Windows.Forms.Label nombreDeSuitesGenereesLabel;
        private System.Windows.Forms.GroupBox totalPointsGroupBox;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.GroupBox lastHandGroupBox;
        private System.Windows.Forms.Label lastHandPointsLabel;
        private System.Windows.Forms.GroupBox numberOfFailuresGroupBox;
        private System.Windows.Forms.Label numberOfFailuresLabel;
    }
}

