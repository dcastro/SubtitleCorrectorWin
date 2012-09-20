﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitleCorrectorWin
{
    public partial class Form1 : Form
    {

        int seconds;
        int milliseconds;
        string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filenameLabel.MaximumSize = new Size(300, 0);
            filenameLabel.AutoSize = true;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filenameLabel.Text = openFileDialog.FileName;
                this.filename = openFileDialog.FileName;
            }
        }

        private void secondsInput_ValueChanged(object sender, EventArgs e)
        {
            this.seconds = (int) secondsInput.Value;
        }

        private void millisecondsInput_ValueChanged(object sender, EventArgs e)
        {
            this.milliseconds = (int)millisecondsInput.Value;
        }

        private async void correctButton_Click(object sender, EventArgs e)
        {
            Corrector corrector = new Corrector(seconds, milliseconds, filename);
            await corrector.correctAsync();
        }


    }
}
