namespace ADayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this._labelBettingParlorTitle = new System.Windows.Forms.Label();
            this._labelMinimumBet = new System.Windows.Forms.Label();
            this._labelBets = new System.Windows.Forms.Label();
            this._radioButtonJoe = new System.Windows.Forms.RadioButton();
            this._radioButtonBob = new System.Windows.Forms.RadioButton();
            this._radioButtonAl = new System.Windows.Forms.RadioButton();
            this._labelBettorName = new System.Windows.Forms.Label();
            this._buttonBet = new System.Windows.Forms.Button();
            this._numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this._labelBetsOn = new System.Windows.Forms.Label();
            this._numericUpDownDog = new System.Windows.Forms.NumericUpDown();
            this._buttonRace = new System.Windows.Forms.Button();
            this._labelBetJoe = new System.Windows.Forms.Label();
            this._labelBetBob = new System.Windows.Forms.Label();
            this._labelBetAl = new System.Windows.Forms.Label();
            this._pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this._pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this._pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this._pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            this._pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this._pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this._pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this._pictureBoxBackground.Name = "pictureBoxBackground";
            this._pictureBoxBackground.Size = new System.Drawing.Size(600, 200);
            this._pictureBoxBackground.TabIndex = 0;
            this._pictureBoxBackground.TabStop = false;
            // 
            // labelBettingParlorTitle
            // 
            this._labelBettingParlorTitle.AutoSize = true;
            this._labelBettingParlorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBettingParlorTitle.Location = new System.Drawing.Point(10, 220);
            this._labelBettingParlorTitle.Name = "labelBettingParlorTitle";
            this._labelBettingParlorTitle.Size = new System.Drawing.Size(135, 24);
            this._labelBettingParlorTitle.TabIndex = 1;
            this._labelBettingParlorTitle.Text = "Betting Parlor";
            // 
            // labelMinimumBet
            // 
            this._labelMinimumBet.AutoSize = true;
            this._labelMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelMinimumBet.ForeColor = System.Drawing.Color.Red;
            this._labelMinimumBet.Location = new System.Drawing.Point(10, 250);
            this._labelMinimumBet.Name = "labelMinimumBet";
            this._labelMinimumBet.Size = new System.Drawing.Size(155, 16);
            this._labelMinimumBet.TabIndex = 2;
            this._labelMinimumBet.Text = "Minimum bet: 5 bucks";
            // 
            // labelBets
            // 
            this._labelBets.AutoSize = true;
            this._labelBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBets.Location = new System.Drawing.Point(200, 250);
            this._labelBets.Name = "labelBets";
            this._labelBets.Size = new System.Drawing.Size(39, 16);
            this._labelBets.TabIndex = 3;
            this._labelBets.Text = "Bets";
            // 
            // radioButtonJoe
            // 
            this._radioButtonJoe.Location = new System.Drawing.Point(14, 275);
            this._radioButtonJoe.Name = "radioButtonJoe";
            this._radioButtonJoe.Size = new System.Drawing.Size(150, 17);
            this._radioButtonJoe.TabIndex = 4;
            this._radioButtonJoe.TabStop = true;
            this._radioButtonJoe.Text = "Joe has 50 bucks";
            this._radioButtonJoe.UseVisualStyleBackColor = true;
            this._radioButtonJoe.CheckedChanged += new System.EventHandler(this.OnRadioButtonJoeCheckedChanged);
            // 
            // radioButtonBob
            // 
            this._radioButtonBob.Location = new System.Drawing.Point(14, 300);
            this._radioButtonBob.Name = "radioButtonBob";
            this._radioButtonBob.Size = new System.Drawing.Size(150, 17);
            this._radioButtonBob.TabIndex = 5;
            this._radioButtonBob.TabStop = true;
            this._radioButtonBob.Text = "Bob has 75 bucks";
            this._radioButtonBob.UseVisualStyleBackColor = true;
            this._radioButtonBob.CheckedChanged += new System.EventHandler(this.OnRadioButtonBobCheckedChanged);
            // 
            // radioButtonAl
            // 
            this._radioButtonAl.Location = new System.Drawing.Point(14, 325);
            this._radioButtonAl.Name = "radioButtonAl";
            this._radioButtonAl.Size = new System.Drawing.Size(150, 17);
            this._radioButtonAl.TabIndex = 6;
            this._radioButtonAl.TabStop = true;
            this._radioButtonAl.Text = "Al has 45 bucks";
            this._radioButtonAl.UseVisualStyleBackColor = true;
            this._radioButtonAl.CheckedChanged += new System.EventHandler(this.OnRadioButtonAlCheckedChanged);
            // 
            // labelBettorName
            // 
            this._labelBettorName.AutoSize = true;
            this._labelBettorName.Location = new System.Drawing.Point(10, 370);
            this._labelBettorName.Name = "labelBettorName";
            this._labelBettorName.Size = new System.Drawing.Size(24, 13);
            this._labelBettorName.TabIndex = 7;
            this._labelBettorName.Text = "Joe";
            // 
            // buttonBet
            // 
            this._buttonBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonBet.Location = new System.Drawing.Point(35, 365);
            this._buttonBet.Name = "buttonBet";
            this._buttonBet.Size = new System.Drawing.Size(55, 25);
            this._buttonBet.TabIndex = 8;
            this._buttonBet.Text = "Bets";
            this._buttonBet.UseVisualStyleBackColor = true;
            this._buttonBet.Click += new System.EventHandler(this.OnButtonBetClick);
            // 
            // numericUpDownAmount
            // 
            this._numericUpDownAmount.Location = new System.Drawing.Point(95, 368);
            this._numericUpDownAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this._numericUpDownAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._numericUpDownAmount.Name = "numericUpDownAmount";
            this._numericUpDownAmount.Size = new System.Drawing.Size(55, 20);
            this._numericUpDownAmount.TabIndex = 9;
            this._numericUpDownAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelBetsOn
            // 
            this._labelBetsOn.AutoSize = true;
            this._labelBetsOn.Location = new System.Drawing.Point(155, 370);
            this._labelBetsOn.Name = "labelBetsOn";
            this._labelBetsOn.Size = new System.Drawing.Size(110, 13);
            this._labelBetsOn.TabIndex = 10;
            this._labelBetsOn.Text = "bucks on dog number";
            // 
            // numericUpDownDog
            // 
            this._numericUpDownDog.Location = new System.Drawing.Point(265, 368);
            this._numericUpDownDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this._numericUpDownDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericUpDownDog.Name = "numericUpDownDog";
            this._numericUpDownDog.Size = new System.Drawing.Size(42, 20);
            this._numericUpDownDog.TabIndex = 11;
            this._numericUpDownDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonRace
            // 
            this._buttonRace.Location = new System.Drawing.Point(370, 275);
            this._buttonRace.Name = "buttonRace";
            this._buttonRace.Size = new System.Drawing.Size(200, 115);
            this._buttonRace.TabIndex = 12;
            this._buttonRace.Text = "Race!";
            this._buttonRace.UseVisualStyleBackColor = true;
            this._buttonRace.Click += new System.EventHandler(this.OnButtonRaceClick);
            // 
            // labelBetJoe
            // 
            this._labelBetJoe.Location = new System.Drawing.Point(200, 275);
            this._labelBetJoe.Name = "labelBetJoe";
            this._labelBetJoe.Size = new System.Drawing.Size(150, 13);
            this._labelBetJoe.TabIndex = 13;
            this._labelBetJoe.Text = "Joe hasn\'t placed a bet";
            // 
            // labelBetBob
            // 
            this._labelBetBob.Location = new System.Drawing.Point(200, 300);
            this._labelBetBob.Name = "labelBetBob";
            this._labelBetBob.Size = new System.Drawing.Size(150, 13);
            this._labelBetBob.TabIndex = 14;
            this._labelBetBob.Text = "Bob hasn\'t placed a bet";
            // 
            // labelBetAl
            // 
            this._labelBetAl.Location = new System.Drawing.Point(200, 325);
            this._labelBetAl.Name = "labelBetAl";
            this._labelBetAl.Size = new System.Drawing.Size(150, 13);
            this._labelBetAl.TabIndex = 15;
            this._labelBetAl.Text = "Al hasn\'t placed a bet";
            // 
            // pictureBoxDog1
            // 
            this._pictureBoxDog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog1.Image")));
            this._pictureBoxDog1.Location = new System.Drawing.Point(16, 10);
            this._pictureBoxDog1.Name = "pictureBoxDog1";
            this._pictureBoxDog1.Size = new System.Drawing.Size(73, 20);
            this._pictureBoxDog1.TabIndex = 16;
            this._pictureBoxDog1.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this._pictureBoxDog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog2.Image")));
            this._pictureBoxDog2.Location = new System.Drawing.Point(16, 62);
            this._pictureBoxDog2.Name = "pictureBoxDog2";
            this._pictureBoxDog2.Size = new System.Drawing.Size(73, 20);
            this._pictureBoxDog2.TabIndex = 17;
            this._pictureBoxDog2.TabStop = false;
            // 
            // pictureBoxDog3
            // 
            this._pictureBoxDog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog3.Image")));
            this._pictureBoxDog3.Location = new System.Drawing.Point(16, 114);
            this._pictureBoxDog3.Name = "pictureBoxDog3";
            this._pictureBoxDog3.Size = new System.Drawing.Size(73, 20);
            this._pictureBoxDog3.TabIndex = 18;
            this._pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog4
            // 
            this._pictureBoxDog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog4.Image")));
            this._pictureBoxDog4.Location = new System.Drawing.Point(16, 166);
            this._pictureBoxDog4.Name = "pictureBoxDog4";
            this._pictureBoxDog4.Size = new System.Drawing.Size(73, 20);
            this._pictureBoxDog4.TabIndex = 19;
            this._pictureBoxDog4.TabStop = false;
            // 
            // timer1
            // 
            this._timer.Interval = 1;
            this._timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this._pictureBoxDog4);
            this.Controls.Add(this._pictureBoxDog3);
            this.Controls.Add(this._pictureBoxDog2);
            this.Controls.Add(this._pictureBoxDog1);
            this.Controls.Add(this._labelBetAl);
            this.Controls.Add(this._labelBetBob);
            this.Controls.Add(this._labelBetJoe);
            this.Controls.Add(this._buttonRace);
            this.Controls.Add(this._numericUpDownDog);
            this.Controls.Add(this._labelBetsOn);
            this.Controls.Add(this._numericUpDownAmount);
            this.Controls.Add(this._buttonBet);
            this.Controls.Add(this._labelBettorName);
            this.Controls.Add(this._radioButtonAl);
            this.Controls.Add(this._radioButtonBob);
            this.Controls.Add(this._radioButtonJoe);
            this.Controls.Add(this._labelBets);
            this.Controls.Add(this._labelMinimumBet);
            this.Controls.Add(this._labelBettingParlorTitle);
            this.Controls.Add(this._pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxDog4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBoxBackground;
        private System.Windows.Forms.Label _labelBettingParlorTitle;
        private System.Windows.Forms.Label _labelMinimumBet;
        private System.Windows.Forms.Label _labelBets;
        private System.Windows.Forms.RadioButton _radioButtonJoe;
        private System.Windows.Forms.RadioButton _radioButtonBob;
        private System.Windows.Forms.RadioButton _radioButtonAl;
        private System.Windows.Forms.Label _labelBettorName;
        private System.Windows.Forms.Button _buttonBet;
        private System.Windows.Forms.NumericUpDown _numericUpDownAmount;
        private System.Windows.Forms.Label _labelBetsOn;
        private System.Windows.Forms.NumericUpDown _numericUpDownDog;
        private System.Windows.Forms.Button _buttonRace;
        private System.Windows.Forms.Label _labelBetJoe;
        private System.Windows.Forms.Label _labelBetBob;
        private System.Windows.Forms.Label _labelBetAl;
        private System.Windows.Forms.PictureBox _pictureBoxDog1;
        private System.Windows.Forms.PictureBox _pictureBoxDog2;
        private System.Windows.Forms.PictureBox _pictureBoxDog3;
        private System.Windows.Forms.PictureBox _pictureBoxDog4;
        private System.Windows.Forms.Timer _timer;
    }
}

