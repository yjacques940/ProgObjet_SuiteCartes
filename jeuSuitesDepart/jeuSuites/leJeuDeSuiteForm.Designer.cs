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
            this.nombreDeSuitesGenereesLabel = new System.Windows.Forms.Label();
            this.nombreDeSuiteGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPointsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.lastHandGroupBox = new System.Windows.Forms.GroupBox();
            this.lastHandPointsLabel = new System.Windows.Forms.Label();
            this.numberOfFailuresGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfFailuresLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.checkOrderButton = new System.Windows.Forms.Button();
            this.handInOrderLabel = new System.Windows.Forms.Label();
            this.cardsGroupBox = new System.Windows.Forms.GroupBox();
            this.thirdPositionLabel = new System.Windows.Forms.Label();
            this.fifthPositionLabel = new System.Windows.Forms.Label();
            this.fourthPositionLabel = new System.Windows.Forms.Label();
            this.secondPositionLabel = new System.Windows.Forms.Label();
            this.firstPositionLabel = new System.Windows.Forms.Label();
            this.fifthPositionTextBox = new System.Windows.Forms.TextBox();
            this.secondPositionTextBox = new System.Windows.Forms.TextBox();
            this.fourthPositionTextBox = new System.Windows.Forms.TextBox();
            this.thirdPositionTextBox = new System.Windows.Forms.TextBox();
            this.firstPositionTextBox = new System.Windows.Forms.TextBox();
            this.card5Label = new System.Windows.Forms.Label();
            this.card4Label = new System.Windows.Forms.Label();
            this.card3Label = new System.Windows.Forms.Label();
            this.card2Label = new System.Windows.Forms.Label();
            this.card1Label = new System.Windows.Forms.Label();
            this.modifyPositionsButton = new System.Windows.Forms.Button();
            this.timeRemainingGroupBox.SuspendLayout();
            this.nombreDeSuiteGroupBox.SuspendLayout();
            this.totalPointsGroupBox.SuspendLayout();
            this.lastHandGroupBox.SuspendLayout();
            this.numberOfFailuresGroupBox.SuspendLayout();
            this.cardsGroupBox.SuspendLayout();
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
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(13, 230);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(170, 24);
            this.gameOverLabel.TabIndex = 9;
            this.gameOverLabel.Text = "[gameOverLabel]";
            // 
            // checkOrderButton
            // 
            this.checkOrderButton.Location = new System.Drawing.Point(316, 241);
            this.checkOrderButton.Name = "checkOrderButton";
            this.checkOrderButton.Size = new System.Drawing.Size(121, 32);
            this.checkOrderButton.TabIndex = 10;
            this.checkOrderButton.Text = "Verifier Suite";
            this.checkOrderButton.UseVisualStyleBackColor = true;
            this.checkOrderButton.Click += new System.EventHandler(this.checkOrderButton_Click);
            // 
            // handInOrderLabel
            // 
            this.handInOrderLabel.AutoSize = true;
            this.handInOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handInOrderLabel.Location = new System.Drawing.Point(19, 193);
            this.handInOrderLabel.Name = "handInOrderLabel";
            this.handInOrderLabel.Size = new System.Drawing.Size(164, 20);
            this.handInOrderLabel.TabIndex = 11;
            this.handInOrderLabel.Text = "[handInOrderLabel]";
            // 
            // cardsGroupBox
            // 
            this.cardsGroupBox.Controls.Add(this.thirdPositionLabel);
            this.cardsGroupBox.Controls.Add(this.fifthPositionLabel);
            this.cardsGroupBox.Controls.Add(this.fourthPositionLabel);
            this.cardsGroupBox.Controls.Add(this.secondPositionLabel);
            this.cardsGroupBox.Controls.Add(this.firstPositionLabel);
            this.cardsGroupBox.Controls.Add(this.fifthPositionTextBox);
            this.cardsGroupBox.Controls.Add(this.secondPositionTextBox);
            this.cardsGroupBox.Controls.Add(this.fourthPositionTextBox);
            this.cardsGroupBox.Controls.Add(this.thirdPositionTextBox);
            this.cardsGroupBox.Controls.Add(this.firstPositionTextBox);
            this.cardsGroupBox.Controls.Add(this.card5Label);
            this.cardsGroupBox.Controls.Add(this.card4Label);
            this.cardsGroupBox.Controls.Add(this.card3Label);
            this.cardsGroupBox.Controls.Add(this.card2Label);
            this.cardsGroupBox.Controls.Add(this.card1Label);
            this.cardsGroupBox.Location = new System.Drawing.Point(70, 94);
            this.cardsGroupBox.Name = "cardsGroupBox";
            this.cardsGroupBox.Size = new System.Drawing.Size(293, 77);
            this.cardsGroupBox.TabIndex = 17;
            this.cardsGroupBox.TabStop = false;
            this.cardsGroupBox.Text = "Cartes et positions";
            // 
            // thirdPositionLabel
            // 
            this.thirdPositionLabel.AutoSize = true;
            this.thirdPositionLabel.Location = new System.Drawing.Point(138, 15);
            this.thirdPositionLabel.Name = "thirdPositionLabel";
            this.thirdPositionLabel.Size = new System.Drawing.Size(13, 13);
            this.thirdPositionLabel.TabIndex = 30;
            this.thirdPositionLabel.Text = "3";
            // 
            // fifthPositionLabel
            // 
            this.fifthPositionLabel.AutoSize = true;
            this.fifthPositionLabel.Location = new System.Drawing.Point(254, 16);
            this.fifthPositionLabel.Name = "fifthPositionLabel";
            this.fifthPositionLabel.Size = new System.Drawing.Size(13, 13);
            this.fifthPositionLabel.TabIndex = 29;
            this.fifthPositionLabel.Text = "5";
            // 
            // fourthPositionLabel
            // 
            this.fourthPositionLabel.AutoSize = true;
            this.fourthPositionLabel.Location = new System.Drawing.Point(195, 16);
            this.fourthPositionLabel.Name = "fourthPositionLabel";
            this.fourthPositionLabel.Size = new System.Drawing.Size(13, 13);
            this.fourthPositionLabel.TabIndex = 28;
            this.fourthPositionLabel.Text = "4";
            // 
            // secondPositionLabel
            // 
            this.secondPositionLabel.AutoSize = true;
            this.secondPositionLabel.Location = new System.Drawing.Point(77, 16);
            this.secondPositionLabel.Name = "secondPositionLabel";
            this.secondPositionLabel.Size = new System.Drawing.Size(13, 13);
            this.secondPositionLabel.TabIndex = 27;
            this.secondPositionLabel.Text = "2";
            // 
            // firstPositionLabel
            // 
            this.firstPositionLabel.AutoSize = true;
            this.firstPositionLabel.Location = new System.Drawing.Point(24, 16);
            this.firstPositionLabel.Name = "firstPositionLabel";
            this.firstPositionLabel.Size = new System.Drawing.Size(13, 13);
            this.firstPositionLabel.TabIndex = 18;
            this.firstPositionLabel.Text = "1";
            // 
            // fifthPositionTextBox
            // 
            this.fifthPositionTextBox.Location = new System.Drawing.Point(246, 51);
            this.fifthPositionTextBox.Name = "fifthPositionTextBox";
            this.fifthPositionTextBox.Size = new System.Drawing.Size(30, 20);
            this.fifthPositionTextBox.TabIndex = 5;
            // 
            // secondPositionTextBox
            // 
            this.secondPositionTextBox.Location = new System.Drawing.Point(69, 51);
            this.secondPositionTextBox.Name = "secondPositionTextBox";
            this.secondPositionTextBox.Size = new System.Drawing.Size(30, 20);
            this.secondPositionTextBox.TabIndex = 2;
            // 
            // fourthPositionTextBox
            // 
            this.fourthPositionTextBox.Location = new System.Drawing.Point(189, 51);
            this.fourthPositionTextBox.Name = "fourthPositionTextBox";
            this.fourthPositionTextBox.Size = new System.Drawing.Size(30, 20);
            this.fourthPositionTextBox.TabIndex = 4;
            // 
            // thirdPositionTextBox
            // 
            this.thirdPositionTextBox.Location = new System.Drawing.Point(133, 51);
            this.thirdPositionTextBox.Name = "thirdPositionTextBox";
            this.thirdPositionTextBox.Size = new System.Drawing.Size(30, 20);
            this.thirdPositionTextBox.TabIndex = 3;
            // 
            // firstPositionTextBox
            // 
            this.firstPositionTextBox.Location = new System.Drawing.Point(16, 51);
            this.firstPositionTextBox.Name = "firstPositionTextBox";
            this.firstPositionTextBox.Size = new System.Drawing.Size(30, 20);
            this.firstPositionTextBox.TabIndex = 1;
            // 
            // card5Label
            // 
            this.card5Label.AutoSize = true;
            this.card5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card5Label.Location = new System.Drawing.Point(235, 28);
            this.card5Label.Name = "card5Label";
            this.card5Label.Size = new System.Drawing.Size(54, 20);
            this.card5Label.TabIndex = 21;
            this.card5Label.Text = "carte5";
            // 
            // card4Label
            // 
            this.card4Label.AutoSize = true;
            this.card4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card4Label.Location = new System.Drawing.Point(175, 28);
            this.card4Label.Name = "card4Label";
            this.card4Label.Size = new System.Drawing.Size(54, 20);
            this.card4Label.TabIndex = 20;
            this.card4Label.Text = "carte4";
            // 
            // card3Label
            // 
            this.card3Label.AutoSize = true;
            this.card3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card3Label.Location = new System.Drawing.Point(119, 28);
            this.card3Label.Name = "card3Label";
            this.card3Label.Size = new System.Drawing.Size(54, 20);
            this.card3Label.TabIndex = 19;
            this.card3Label.Text = "carte3";
            // 
            // card2Label
            // 
            this.card2Label.AutoSize = true;
            this.card2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card2Label.Location = new System.Drawing.Point(59, 28);
            this.card2Label.Name = "card2Label";
            this.card2Label.Size = new System.Drawing.Size(54, 20);
            this.card2Label.TabIndex = 18;
            this.card2Label.Text = "carte2";
            // 
            // card1Label
            // 
            this.card1Label.AutoSize = true;
            this.card1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card1Label.Location = new System.Drawing.Point(3, 28);
            this.card1Label.Name = "card1Label";
            this.card1Label.Size = new System.Drawing.Size(54, 20);
            this.card1Label.TabIndex = 17;
            this.card1Label.Text = "carte1";
            // 
            // modifyPositionsButton
            // 
            this.modifyPositionsButton.Location = new System.Drawing.Point(316, 193);
            this.modifyPositionsButton.Name = "modifyPositionsButton";
            this.modifyPositionsButton.Size = new System.Drawing.Size(121, 32);
            this.modifyPositionsButton.TabIndex = 18;
            this.modifyPositionsButton.Text = "Modifier les positions";
            this.modifyPositionsButton.UseVisualStyleBackColor = true;
            this.modifyPositionsButton.Click += new System.EventHandler(this.modifyPositionsButton_Click);
            // 
            // leJeuDeSuiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 285);
            this.Controls.Add(this.modifyPositionsButton);
            this.Controls.Add(this.cardsGroupBox);
            this.Controls.Add(this.handInOrderLabel);
            this.Controls.Add(this.checkOrderButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.numberOfFailuresGroupBox);
            this.Controls.Add(this.lastHandGroupBox);
            this.Controls.Add(this.totalPointsGroupBox);
            this.Controls.Add(this.nombreDeSuiteGroupBox);
            this.Controls.Add(this.timeRemainingGroupBox);
            this.Name = "leJeuDeSuiteForm";
            this.Text = "Suites de cartes";
            this.Load += new System.EventHandler(this.leJeuDeSuiteForm_Load);
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
            this.cardsGroupBox.ResumeLayout(false);
            this.cardsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.GroupBox timeRemainingGroupBox;
        private System.Windows.Forms.GroupBox nombreDeSuiteGroupBox;
        private System.Windows.Forms.Label nombreDeSuitesGenereesLabel;
        private System.Windows.Forms.GroupBox totalPointsGroupBox;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.GroupBox lastHandGroupBox;
        private System.Windows.Forms.Label lastHandPointsLabel;
        private System.Windows.Forms.GroupBox numberOfFailuresGroupBox;
        private System.Windows.Forms.Label numberOfFailuresLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button checkOrderButton;
        private System.Windows.Forms.Label handInOrderLabel;
        private System.Windows.Forms.GroupBox cardsGroupBox;
        private System.Windows.Forms.Label thirdPositionLabel;
        private System.Windows.Forms.Label fifthPositionLabel;
        private System.Windows.Forms.Label fourthPositionLabel;
        private System.Windows.Forms.Label secondPositionLabel;
        private System.Windows.Forms.Label firstPositionLabel;
        private System.Windows.Forms.TextBox fifthPositionTextBox;
        private System.Windows.Forms.TextBox secondPositionTextBox;
        private System.Windows.Forms.TextBox fourthPositionTextBox;
        private System.Windows.Forms.TextBox thirdPositionTextBox;
        private System.Windows.Forms.TextBox firstPositionTextBox;
        private System.Windows.Forms.Label card5Label;
        private System.Windows.Forms.Label card4Label;
        private System.Windows.Forms.Label card3Label;
        private System.Windows.Forms.Label card2Label;
        private System.Windows.Forms.Label card1Label;
        private System.Windows.Forms.Button modifyPositionsButton;
    }
}

