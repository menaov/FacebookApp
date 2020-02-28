namespace FacebookFeaturesUI
{
    public partial class RecognizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecognizerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLuckyGuess = new System.Windows.Forms.TextBox();
            this.buttonLuckyGuess = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.textBoxLives = new System.Windows.Forms.TextBox();
            this.textBoxHints = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxGuess = new System.Windows.Forms.PictureBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.labelGuessLetter = new System.Windows.Forms.Label();
            this.labelPattern = new System.Windows.Forms.Label();
            this.buttonHint = new System.Windows.Forms.Button();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.textBoxHint = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(375, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Who Am I?";
            // 
            // textBoxLuckyGuess
            // 
            this.textBoxLuckyGuess.BackColor = System.Drawing.Color.Gold;
            this.textBoxLuckyGuess.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuckyGuess.Location = new System.Drawing.Point(306, 443);
            this.textBoxLuckyGuess.Name = "textBoxLuckyGuess";
            this.textBoxLuckyGuess.Size = new System.Drawing.Size(249, 36);
            this.textBoxLuckyGuess.TabIndex = 2;
            // 
            // buttonLuckyGuess
            // 
            this.buttonLuckyGuess.AutoSize = true;
            this.buttonLuckyGuess.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuckyGuess.Location = new System.Drawing.Point(561, 441);
            this.buttonLuckyGuess.Name = "buttonLuckyGuess";
            this.buttonLuckyGuess.Size = new System.Drawing.Size(134, 38);
            this.buttonLuckyGuess.TabIndex = 3;
            this.buttonLuckyGuess.Text = "Lucky Guess";
            this.buttonLuckyGuess.UseVisualStyleBackColor = true;
            this.buttonLuckyGuess.Click += new System.EventHandler(this.buttonLuckyGuess_Click);
            // 
            // buttonA
            // 
            this.buttonA.AutoSize = true;
            this.buttonA.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(234, 485);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(54, 38);
            this.buttonA.TabIndex = 4;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.performGuess);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(13, 108);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(60, 24);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "Score:";
            // 
            // textBoxLives
            // 
            this.textBoxLives.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLives.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLives.Location = new System.Drawing.Point(134, 27);
            this.textBoxLives.Name = "textBoxLives";
            this.textBoxLives.Size = new System.Drawing.Size(100, 30);
            this.textBoxLives.TabIndex = 32;
            // 
            // textBoxHints
            // 
            this.textBoxHints.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxHints.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHints.Location = new System.Drawing.Point(134, 63);
            this.textBoxHints.Name = "textBoxHints";
            this.textBoxHints.Size = new System.Drawing.Size(100, 30);
            this.textBoxHints.TabIndex = 33;
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxScore.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(134, 102);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 30);
            this.textBoxScore.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lives:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hints:";
            // 
            // pictureBoxGuess
            // 
            this.pictureBoxGuess.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxGuess.Location = new System.Drawing.Point(339, 80);
            this.pictureBoxGuess.Name = "pictureBoxGuess";
            this.pictureBoxGuess.Size = new System.Drawing.Size(249, 291);
            this.pictureBoxGuess.TabIndex = 0;
            this.pictureBoxGuess.TabStop = false;
            // 
            // buttonB
            // 
            this.buttonB.AutoSize = true;
            this.buttonB.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(294, 485);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(54, 38);
            this.buttonB.TabIndex = 37;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonC
            // 
            this.buttonC.AutoSize = true;
            this.buttonC.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(354, 485);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(54, 38);
            this.buttonC.TabIndex = 38;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonF
            // 
            this.buttonF.AutoSize = true;
            this.buttonF.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonF.Location = new System.Drawing.Point(534, 485);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(54, 38);
            this.buttonF.TabIndex = 41;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonE
            // 
            this.buttonE.AutoSize = true;
            this.buttonE.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.Location = new System.Drawing.Point(474, 485);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(54, 38);
            this.buttonE.TabIndex = 40;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonD
            // 
            this.buttonD.AutoSize = true;
            this.buttonD.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(414, 485);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(54, 38);
            this.buttonD.TabIndex = 39;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonI
            // 
            this.buttonI.AutoSize = true;
            this.buttonI.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonI.Location = new System.Drawing.Point(714, 485);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(54, 38);
            this.buttonI.TabIndex = 44;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonH
            // 
            this.buttonH.AutoSize = true;
            this.buttonH.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonH.Location = new System.Drawing.Point(654, 485);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(54, 38);
            this.buttonH.TabIndex = 43;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonG
            // 
            this.buttonG.AutoSize = true;
            this.buttonG.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonG.Location = new System.Drawing.Point(594, 485);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(54, 38);
            this.buttonG.TabIndex = 42;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonR
            // 
            this.buttonR.AutoSize = true;
            this.buttonR.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.Location = new System.Drawing.Point(714, 529);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(54, 38);
            this.buttonR.TabIndex = 53;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonQ
            // 
            this.buttonQ.AutoSize = true;
            this.buttonQ.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQ.Location = new System.Drawing.Point(654, 529);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(54, 38);
            this.buttonQ.TabIndex = 52;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonP
            // 
            this.buttonP.AutoSize = true;
            this.buttonP.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.Location = new System.Drawing.Point(594, 529);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(54, 38);
            this.buttonP.TabIndex = 51;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonO
            // 
            this.buttonO.AutoSize = true;
            this.buttonO.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonO.Location = new System.Drawing.Point(534, 529);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(54, 38);
            this.buttonO.TabIndex = 50;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonN
            // 
            this.buttonN.AutoSize = true;
            this.buttonN.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.Location = new System.Drawing.Point(474, 529);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(54, 38);
            this.buttonN.TabIndex = 49;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonM
            // 
            this.buttonM.AutoSize = true;
            this.buttonM.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(414, 529);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(54, 38);
            this.buttonM.TabIndex = 48;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonL
            // 
            this.buttonL.AutoSize = true;
            this.buttonL.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.Location = new System.Drawing.Point(354, 529);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(54, 38);
            this.buttonL.TabIndex = 47;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonK
            // 
            this.buttonK.AutoSize = true;
            this.buttonK.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonK.Location = new System.Drawing.Point(294, 529);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(54, 38);
            this.buttonK.TabIndex = 46;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonJ
            // 
            this.buttonJ.AutoSize = true;
            this.buttonJ.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJ.Location = new System.Drawing.Point(234, 529);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(54, 38);
            this.buttonJ.TabIndex = 45;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonZ
            // 
            this.buttonZ.AutoSize = true;
            this.buttonZ.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ.Location = new System.Drawing.Point(681, 573);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(54, 38);
            this.buttonZ.TabIndex = 61;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonY
            // 
            this.buttonY.AutoSize = true;
            this.buttonY.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonY.Location = new System.Drawing.Point(621, 573);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(54, 38);
            this.buttonY.TabIndex = 60;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonX
            // 
            this.buttonX.AutoSize = true;
            this.buttonX.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(561, 573);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(54, 38);
            this.buttonX.TabIndex = 59;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonW
            // 
            this.buttonW.AutoSize = true;
            this.buttonW.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonW.Location = new System.Drawing.Point(501, 573);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(54, 38);
            this.buttonW.TabIndex = 58;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonV
            // 
            this.buttonV.AutoSize = true;
            this.buttonV.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.Location = new System.Drawing.Point(441, 573);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(54, 38);
            this.buttonV.TabIndex = 57;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonU
            // 
            this.buttonU.AutoSize = true;
            this.buttonU.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonU.Location = new System.Drawing.Point(381, 573);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(54, 38);
            this.buttonU.TabIndex = 56;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonT
            // 
            this.buttonT.AutoSize = true;
            this.buttonT.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonT.Location = new System.Drawing.Point(321, 573);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(54, 38);
            this.buttonT.TabIndex = 55;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.performGuess);
            // 
            // buttonS
            // 
            this.buttonS.AutoSize = true;
            this.buttonS.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(261, 573);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(54, 38);
            this.buttonS.TabIndex = 54;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.performGuess);
            // 
            // labelGuessLetter
            // 
            this.labelGuessLetter.AutoSize = true;
            this.labelGuessLetter.BackColor = System.Drawing.Color.Transparent;
            this.labelGuessLetter.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessLetter.Location = new System.Drawing.Point(104, 485);
            this.labelGuessLetter.Name = "labelGuessLetter";
            this.labelGuessLetter.Size = new System.Drawing.Size(122, 24);
            this.labelGuessLetter.TabIndex = 62;
            this.labelGuessLetter.Text = "Guess a letter:";
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.BackColor = System.Drawing.Color.Snow;
            this.labelPattern.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPattern.Location = new System.Drawing.Point(335, 385);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(133, 46);
            this.labelPattern.TabIndex = 63;
            this.labelPattern.Text = "Pattern";
            // 
            // buttonHint
            // 
            this.buttonHint.AutoSize = true;
            this.buttonHint.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHint.Location = new System.Drawing.Point(681, 108);
            this.buttonHint.Name = "buttonHint";
            this.buttonHint.Size = new System.Drawing.Size(84, 34);
            this.buttonHint.TabIndex = 64;
            this.buttonHint.Text = "Hint Me!";
            this.buttonHint.UseVisualStyleBackColor = true;
            this.buttonHint.Click += new System.EventHandler(this.buttonHint_Click);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGif.Location = new System.Drawing.Point(17, 153);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(260, 326);
            this.pictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif.TabIndex = 65;
            this.pictureBoxGif.TabStop = false;
            this.pictureBoxGif.Visible = false;
            // 
            // textBoxHint
            // 
            this.textBoxHint.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHint.Location = new System.Drawing.Point(633, 148);
            this.textBoxHint.Name = "textBoxHint";
            this.textBoxHint.Size = new System.Drawing.Size(187, 30);
            this.textBoxHint.TabIndex = 66;
            this.textBoxHint.Visible = false;
            // 
            // RecognizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(832, 677);
            this.Controls.Add(this.textBoxHint);
            this.Controls.Add(this.pictureBoxGif);
            this.Controls.Add(this.buttonHint);
            this.Controls.Add(this.labelPattern);
            this.Controls.Add(this.labelGuessLetter);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxHints);
            this.Controls.Add(this.textBoxLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonLuckyGuess);
            this.Controls.Add(this.textBoxLuckyGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxGuess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecognizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recognizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecognizerForm_FormClosed);
            this.Shown += new System.EventHandler(this.RecognizerForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLuckyGuess;
        private System.Windows.Forms.Button buttonLuckyGuess;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox textBoxLives;
        private System.Windows.Forms.TextBox textBoxHints;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Label labelGuessLetter;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Button buttonHint;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.TextBox textBoxHint;
    }
}