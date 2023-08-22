namespace pexeso
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
            this.PanelGame = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChooseCards = new System.Windows.Forms.Panel();
            this.numericUpDownCards = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.labelReadyToPlay = new System.Windows.Forms.Label();
            this.panelLetsPlay = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelLetsPlay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChooseCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCards)).BeginInit();
            this.panelLetsPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.Location = new System.Drawing.Point(12, 12);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(764, 562);
            this.PanelGame.TabIndex = 0;
            this.PanelGame.Visible = false;
            // 
            // panelChooseCards
            // 
            this.panelChooseCards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelChooseCards.BackColor = System.Drawing.Color.MistyRose;
            this.panelChooseCards.Controls.Add(this.button1);
            this.panelChooseCards.Controls.Add(this.numericUpDownCards);
            this.panelChooseCards.Controls.Add(this.labelReadyToPlay);
            this.panelChooseCards.Location = new System.Drawing.Point(0, 0);
            this.panelChooseCards.Name = "panelChooseCards";
            this.panelChooseCards.Size = new System.Drawing.Size(605, 352);
            this.panelChooseCards.TabIndex = 0;
            this.panelChooseCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDownCards
            // 
            this.numericUpDownCards.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCards.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDownCards.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCards.Location = new System.Drawing.Point(257, 152);
            this.numericUpDownCards.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCards.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCards.Name = "numericUpDownCards";
            this.numericUpDownCards.Size = new System.Drawing.Size(65, 42);
            this.numericUpDownCards.TabIndex = 3;
            this.numericUpDownCards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCards.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(211, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConfirmCards_Click);
            // 
            // labelReadyToPlay
            // 
            this.labelReadyToPlay.AutoSize = true;
            this.labelReadyToPlay.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadyToPlay.ForeColor = System.Drawing.Color.Firebrick;
            this.labelReadyToPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelReadyToPlay.Location = new System.Drawing.Point(119, 64);
            this.labelReadyToPlay.Name = "labelReadyToPlay";
            this.labelReadyToPlay.Size = new System.Drawing.Size(360, 38);
            this.labelReadyToPlay.TabIndex = 0;
            this.labelReadyToPlay.Text = "Choose a number of cards";
            // 
            // panelLetsPlay
            // 
            this.panelLetsPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLetsPlay.BackColor = System.Drawing.Color.MistyRose;
            this.panelLetsPlay.Controls.Add(this.button2);
            this.panelLetsPlay.Controls.Add(this.labelLetsPlay);
            this.panelLetsPlay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.panelLetsPlay.Location = new System.Drawing.Point(0, 0);
            this.panelLetsPlay.Name = "panelLetsPlay";
            this.panelLetsPlay.Size = new System.Drawing.Size(608, 355);
            this.panelLetsPlay.TabIndex = 1;
            this.panelLetsPlay.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(241, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "start the game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLetsPlay);
            // 
            // labelLetsPlay
            // 
            this.labelLetsPlay.AutoSize = true;
            this.labelLetsPlay.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetsPlay.ForeColor = System.Drawing.Color.Maroon;
            this.labelLetsPlay.Location = new System.Drawing.Point(176, 96);
            this.labelLetsPlay.Name = "labelLetsPlay";
            this.labelLetsPlay.Size = new System.Drawing.Size(219, 34);
            this.labelLetsPlay.TabIndex = 0;
            this.labelLetsPlay.Text = "Great! Let\'s play!";
            this.labelLetsPlay.Click += new System.EventHandler(this.labelLetsPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 615);
            this.Controls.Add(this.panelLetsPlay);
            this.Controls.Add(this.panelChooseCards);
            this.Controls.Add(this.PanelGame);
            this.Name = "Form1";
            this.Text = "Pexeso game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelChooseCards.ResumeLayout(false);
            this.panelChooseCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCards)).EndInit();
            this.panelLetsPlay.ResumeLayout(false);
            this.panelLetsPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelChooseCards;
        private System.Windows.Forms.Label labelReadyToPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownCards;
        private System.Windows.Forms.Panel panelLetsPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelLetsPlay;
    }
}

