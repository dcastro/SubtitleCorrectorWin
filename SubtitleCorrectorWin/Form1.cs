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
            move = MoveAction.Forward;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                setFilename(openFileDialog.FileName);
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

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Array data = (Array)e.Data.GetData(DataFormats.FileDrop);
            if( data != null )
            {
                setFilename(data.GetValue(0).ToString());
            }
        }

        private void setFilename(string filename)
        {
            filenameTextBox.Text = filename;
            this.filename = filename;
        }

    }

    enum MoveAction { Forward, Backward };
}
