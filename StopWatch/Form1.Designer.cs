namespace StopWatch
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            StartButton = new Button();
            label1 = new Label();
            StopButton = new Button();
            ResetButton = new Button();
            MovementTimer = new System.Windows.Forms.Timer(components);
            TargetButton = new Button();
            panel1 = new Panel();
            ContinueButton = new Button();
            FalseTarget = new Button();
            StatusLabel = new Label();
            button1 = new Button();
            label2 = new Label();
            ScoreLabel = new Label();
            LabelTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            MissLabel = new Label();
            label4 = new Label();
            LevelLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(15, 398);
            StartButton.Margin = new Padding(6, 7, 6, 7);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(161, 57);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 37);
            label1.TabIndex = 1;
            label1.Text = "Timer";
            // 
            // StopButton
            // 
            StopButton.Location = new Point(203, 398);
            StopButton.Margin = new Padding(6, 7, 6, 7);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(161, 57);
            StopButton.TabIndex = 2;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(391, 398);
            ResetButton.Margin = new Padding(6, 7, 6, 7);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(161, 57);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // MovementTimer
            // 
            MovementTimer.Interval = 1000;
            MovementTimer.Tick += MovementTimer_Tick;
            // 
            // TargetButton
            // 
            TargetButton.BackColor = Color.Transparent;
            TargetButton.BackgroundImage = Properties.Resources.target;
            TargetButton.BackgroundImageLayout = ImageLayout.Zoom;
            TargetButton.FlatStyle = FlatStyle.Flat;
            TargetButton.Location = new Point(15, 22);
            TargetButton.Margin = new Padding(6, 7, 6, 7);
            TargetButton.Name = "TargetButton";
            TargetButton.Size = new Size(80, 80);
            TargetButton.TabIndex = 4;
            TargetButton.UseVisualStyleBackColor = false;
            TargetButton.Click += TargetButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(ContinueButton);
            panel1.Controls.Add(FalseTarget);
            panel1.Controls.Add(StatusLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TargetButton);
            panel1.Cursor = Cursors.Cross;
            panel1.Location = new Point(0, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 339);
            panel1.TabIndex = 5;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(201, 176);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(177, 65);
            ContinueButton.TabIndex = 8;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Visible = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // FalseTarget
            // 
            FalseTarget.BackColor = Color.Transparent;
            FalseTarget.BackgroundImage = (Image)resources.GetObject("FalseTarget.BackgroundImage");
            FalseTarget.BackgroundImageLayout = ImageLayout.Zoom;
            FalseTarget.FlatStyle = FlatStyle.Flat;
            FalseTarget.Location = new Point(105, 22);
            FalseTarget.Margin = new Padding(6, 7, 6, 7);
            FalseTarget.Name = "FalseTarget";
            FalseTarget.Size = new Size(80, 80);
            FalseTarget.TabIndex = 7;
            FalseTarget.UseVisualStyleBackColor = false;
            FalseTarget.Visible = false;
            FalseTarget.Click += FalseTarget_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLabel.Location = new Point(145, 73);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(287, 86);
            StatusLabel.TabIndex = 6;
            StatusLabel.Text = "Game Over";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            StatusLabel.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(201, 176);
            button1.Name = "button1";
            button1.Size = new Size(177, 65);
            button1.TabIndex = 5;
            button1.Text = "Play Again?";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 9);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 37);
            label2.TabIndex = 6;
            label2.Text = "Hits:";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(506, 9);
            ScoreLabel.Margin = new Padding(6, 0, 6, 0);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(32, 37);
            ScoreLabel.TabIndex = 7;
            ScoreLabel.Text = "0";
            // 
            // LabelTimer
            // 
            LabelTimer.Interval = 10;
            LabelTimer.Tick += LabelTimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 9);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 8;
            label3.Text = "Misses:";
            // 
            // MissLabel
            // 
            MissLabel.AutoSize = true;
            MissLabel.Location = new Point(367, 9);
            MissLabel.Margin = new Padding(6, 0, 6, 0);
            MissLabel.Name = "MissLabel";
            MissLabel.Size = new Size(32, 37);
            MissLabel.TabIndex = 9;
            MissLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 9);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 37);
            label4.TabIndex = 10;
            label4.Text = "Level: ";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(200, 9);
            LevelLabel.Margin = new Padding(6, 0, 6, 0);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(32, 37);
            LevelLabel.TabIndex = 11;
            LevelLabel.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 471);
            Controls.Add(LevelLabel);
            Controls.Add(label4);
            Controls.Add(MissLabel);
            Controls.Add(label3);
            Controls.Add(ScoreLabel);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(ResetButton);
            Controls.Add(StopButton);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label label1;
        private Button StopButton;
        private Button ResetButton;
        private System.Windows.Forms.Timer MovementTimer;
        private Button TargetButton;
        private Panel panel1;
        private Label label2;
        private Label ScoreLabel;
        private System.Windows.Forms.Timer LabelTimer;
        private Label label3;
        private Label MissLabel;
        private Label StatusLabel;
        private Button button1;
        private Button FalseTarget;
        private Button ContinueButton;
        private Label label4;
        private Label LevelLabel;
    }
}