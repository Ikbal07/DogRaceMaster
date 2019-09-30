namespace DogRace{
    partial class Form1 {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dogracetrack = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BobBet = new System.Windows.Forms.Label();
            this.MarryBet = new System.Windows.Forms.Label();
            this.KomBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dograce = new System.Windows.Forms.Button();
            this.DogsNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dogRacerAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.BobRButton = new System.Windows.Forms.RadioButton();
            this.MarryRButton = new System.Windows.Forms.RadioButton();
            this.KomButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dogracetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogRacerAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dogracetrack
            // 
            this.dogracetrack.BackColor = System.Drawing.SystemColors.Control;
            this.dogracetrack.Image = global::DogRace.Properties.Resources.racetrack_Image;
            this.dogracetrack.Location = new System.Drawing.Point(-1, -64);
            this.dogracetrack.Name = "dogracetrack";
            this.dogracetrack.Size = new System.Drawing.Size(802, 428);
            this.dogracetrack.TabIndex = 0;
            this.dogracetrack.TabStop = false;
            this.dogracetrack.Click += new System.EventHandler(this.dogracetrack_Click);
            // 
            // Dog1
            // 
            this.Dog1.BackColor = System.Drawing.SystemColors.Control;
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(12, 2);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(161, 59);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Dog1.TabIndex = 1;
            this.Dog1.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(12, 101);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(161, 62);
            this.Dog2.TabIndex = 2;
            this.Dog2.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(12, 210);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(161, 58);
            this.Dog3.TabIndex = 3;
            this.Dog3.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(13, 297);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(161, 57);
            this.Dog4.TabIndex = 4;
            this.Dog4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.BobBet);
            this.groupBox1.Controls.Add(this.MarryBet);
            this.groupBox1.Controls.Add(this.KomBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dograce);
            this.groupBox1.Controls.Add(this.DogsNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dogRacerAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.BobRButton);
            this.groupBox1.Controls.Add(this.MarryRButton);
            this.groupBox1.Controls.Add(this.KomButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(-1, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dog race";
            // 
            // BobBet
            // 
            this.BobBet.BackColor = System.Drawing.SystemColors.Info;
            this.BobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BobBet.Location = new System.Drawing.Point(13, 129);
            this.BobBet.Name = "BobBet";
            this.BobBet.Size = new System.Drawing.Size(218, 17);
            this.BobBet.TabIndex = 13;
            this.BobBet.Text = "label6";
            // 
            // MarryBet
            // 
            this.MarryBet.BackColor = System.Drawing.SystemColors.Info;
            this.MarryBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarryBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MarryBet.Location = new System.Drawing.Point(13, 99);
            this.MarryBet.Name = "MarryBet";
            this.MarryBet.Size = new System.Drawing.Size(218, 17);
            this.MarryBet.TabIndex = 12;
            this.MarryBet.Text = "label5";
            // 
            // KomBet
            // 
            this.KomBet.BackColor = System.Drawing.SystemColors.Info;
            this.KomBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KomBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KomBet.Location = new System.Drawing.Point(14, 65);
            this.KomBet.Name = "KomBet";
            this.KomBet.Size = new System.Drawing.Size(217, 17);
            this.KomBet.TabIndex = 11;
            this.KomBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // dograce
            // 
            this.dograce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dograce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dograce.ForeColor = System.Drawing.Color.Black;
            this.dograce.Location = new System.Drawing.Point(600, 129);
            this.dograce.Name = "dograce";
            this.dograce.Size = new System.Drawing.Size(135, 30);
            this.dograce.TabIndex = 9;
            this.dograce.Text = "START dograce";
            this.dograce.UseVisualStyleBackColor = true;
            this.dograce.Click += new System.EventHandler(this.dograce_Click);
            // 
            // DogsNumber
            // 
            this.DogsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DogsNumber.Location = new System.Drawing.Point(460, 59);
            this.DogsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogsNumber.Name = "DogsNumber";
            this.DogsNumber.Size = new System.Drawing.Size(64, 23);
            this.DogsNumber.TabIndex = 8;
            this.DogsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogsNumber.ValueChanged += new System.EventHandler(this.DogsNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(457, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dogs number";
            // 
            // dogRacerAmount
            // 
            this.dogRacerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dogRacerAmount.Location = new System.Drawing.Point(276, 59);
            this.dogRacerAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dogRacerAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dogRacerAmount.Name = "dogRacerAmount";
            this.dogRacerAmount.Size = new System.Drawing.Size(63, 23);
            this.dogRacerAmount.TabIndex = 6;
            this.dogRacerAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dogRacerAmount.ValueChanged += new System.EventHandler(this.dogRacerAmount_ValueChanged);
            // 
            // Bets
            // 
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Bets.Location = new System.Drawing.Point(13, 28);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(126, 30);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = true;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // BobRButton
            // 
            this.BobRButton.AutoSize = true;
            this.BobRButton.Checked = true;
            this.BobRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BobRButton.Location = new System.Drawing.Point(626, 108);
            this.BobRButton.Name = "BobRButton";
            this.BobRButton.Size = new System.Drawing.Size(51, 21);
            this.BobRButton.TabIndex = 3;
            this.BobRButton.TabStop = true;
            this.BobRButton.Text = "Bob";
            this.BobRButton.UseVisualStyleBackColor = true;
            this.BobRButton.CheckedChanged += new System.EventHandler(this.BobButton_CheckedChanged);
            // 
            // MarryRButton
            // 
            this.MarryRButton.AutoSize = true;
            this.MarryRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MarryRButton.Location = new System.Drawing.Point(626, 84);
            this.MarryRButton.Name = "MarryRButton";
            this.MarryRButton.Size = new System.Drawing.Size(62, 21);
            this.MarryRButton.TabIndex = 2;
            this.MarryRButton.Text = "Marry";
            this.MarryRButton.UseVisualStyleBackColor = true;
            this.MarryRButton.CheckedChanged += new System.EventHandler(this.MarryButton_CheckedChanged);
            // 
            // KomButton
            // 
            this.KomButton.AutoSize = true;
            this.KomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KomButton.Location = new System.Drawing.Point(626, 61);
            this.KomButton.Name = "KomButton";
            this.KomButton.Size = new System.Drawing.Size(54, 21);
            this.KomButton.TabIndex = 1;
            this.KomButton.Text = "Kom";
            this.KomButton.UseVisualStyleBackColor = true;
            this.KomButton.CheckedChanged += new System.EventHandler(this.KomButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(273, 28);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            this.MaximumBet.Click += new System.EventHandler(this.MaximumBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.dogracetrack);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "dograce Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogracetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogRacerAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogracetrack;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BobRButton;
        private System.Windows.Forms.RadioButton MarryRButton;
        private System.Windows.Forms.RadioButton KomButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dogRacerAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown DogsNumber;
        private System.Windows.Forms.Button dograce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KomBet;
        private System.Windows.Forms.Label BobBet;
        private System.Windows.Forms.Label MarryBet;
    }
}

