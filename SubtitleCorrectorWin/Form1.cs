using System;
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
        MoveAction move;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filenameLabel.MaximumSize = new Size(300, 0);
            filenameLabel.AutoSize = true;
            move = MoveAction.Forward;
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
            correctButton.Enabled = false;

            Corrector corrector = new Corrector(seconds, milliseconds, filename, move);
            await corrector.correctAsync();

            correctButton.Enabled = true;
        }

        private void moveForwardRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (moveForwardRadio.Checked)
            {
                move = MoveAction.Forward;
            }
        }

        private void moveBackwardRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (moveBackwardRadio.Checked)
            {
                move = MoveAction.Backward;
            }
        }

    }

    enum MoveAction { Forward, Backward };
}
