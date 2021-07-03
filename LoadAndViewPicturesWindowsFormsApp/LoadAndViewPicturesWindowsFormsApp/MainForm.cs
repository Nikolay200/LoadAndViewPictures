using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoadAndViewPicturesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images Files(*.BMP; *.JPG; *.PNG | *.BMP; *.JPG; *.PNG)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно открыть выбранный файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                result = DialogResult.Cancel;
            }
        }
    }
}
