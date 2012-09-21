namespace SubtitleCorrectorWin
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.secondsInput = new System.Windows.Forms.NumericUpDown();
            this.millisecondsInput = new System.Windows.Forms.NumericUpDown();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.millisecondsLabel = new System.Windows.Forms.Label();
            this.correctButton = new System.Windows.Forms.Button();
            this.moveForwardRadio = new System.Windows.Forms.RadioButton();
            this.moveBackwardRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.secondsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "SRT Files (*.srt)|*.srt";
            this.openFileDialog.Title = "Select the subtitle file";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(35, 38);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // secondsInput
            // 
            this.secondsInput.Location = new System.Drawing.Point(217, 146);
            this.secondsInput.Name = "secondsInput";
            this.secondsInput.Size = new System.Drawing.Size(82, 20);
            this.secondsInput.TabIndex = 2;
            this.secondsInput.ValueChanged += new System.EventHandler(this.secondsInput_ValueChanged);
            // 
            // millisecondsInput
            // 
            this.millisecondsInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.millisecondsInput.Location = new System.Drawing.Point(339, 146);
            this.millisecondsInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.millisecondsInput.Name = "millisecondsInput";
            this.millisecondsInput.Size = new System.Drawing.Size(82, 20);
            this.millisecondsInput.TabIndex = 3;
            this.millisecondsInput.ValueChanged += new System.EventHandler(this.millisecondsInput_ValueChanged);
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(214, 115);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(49, 13);
            this.secondsLabel.TabIndex = 4;
            this.secondsLabel.Text = "Seconds";
            // 
            // millisecondsLabel
            // 
            this.millisecondsLabel.AutoSize = true;
            this.millisecondsLabel.Location = new System.Drawing.Point(336, 115);
            this.millisecondsLabel.Name = "millisecondsLabel";
            this.millisecondsLabel.Size = new System.Drawing.Size(64, 13);
            this.millisecondsLabel.TabIndex = 5;
            this.millisecondsLabel.Text = "Milliseconds";
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(188, 237);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(75, 23);
            this.correctButton.TabIndex = 6;
            this.correctButton.Text = "Correct";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // moveForwardRadio
            // 
            this.moveForwardRadio.AutoSize = true;
            this.moveForwardRadio.Checked = true;
            this.moveForwardRadio.Location = new System.Drawing.Point(21, 27);
            this.moveForwardRadio.Name = "moveForwardRadio";
            this.moveForwardRadio.Size = new System.Drawing.Size(78, 17);
            this.moveForwardRadio.TabIndex = 7;
            this.moveForwardRadio.TabStop = true;
            this.moveForwardRadio.Text = "Forward >>";
            this.moveForwardRadio.UseVisualStyleBackColor = true;
            this.moveForwardRadio.CheckedChanged += new System.EventHandler(this.moveForwardRadio_CheckedChanged);
            // 
            // moveBackwardRadio
            // 
            this.moveBackwardRadio.AutoSize = true;
            this.moveBackwardRadio.Location = new System.Drawing.Point(21, 50);
            this.moveBackwardRadio.Name = "moveBackwardRadio";
            this.moveBackwardRadio.Size = new System.Drawing.Size(88, 17);
            this.moveBackwardRadio.TabIndex = 8;
            this.moveBackwardRadio.Text = "<< Backward";
            this.moveBackwardRadio.UseVisualStyleBackColor = true;
            this.moveBackwardRadio.CheckedChanged += new System.EventHandler(this.moveBackwardRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moveForwardRadio);
            this.groupBox1.Controls.Add(this.moveBackwardRadio);
            this.groupBox1.Location = new System.Drawing.Point(35, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Enabled = false;
            this.filenameTextBox.Location = new System.Drawing.Point(143, 38);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(284, 20);
            this.filenameTextBox.TabIndex = 10;
            this.filenameTextBox.Text = "Please select a file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 282);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.millisecondsLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.millisecondsInput);
            this.Controls.Add(this.secondsInput);
            this.Controls.Add(this.selectFileButton);
            this.Name = "Form1";
            this.Text = "Subtitle Corrector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.NumericUpDown secondsInput;
        private System.Windows.Forms.NumericUpDown millisecondsInput;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label millisecondsLabel;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.RadioButton moveForwardRadio;
        private System.Windows.Forms.RadioButton moveBackwardRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filenameTextBox;
    }
}

