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

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images Files(*.BMP; *.JPG; *.PNG | *.BMP; *.JPG; *.PNG | All files(*.*) | *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно открыть выбранный файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Dispose();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
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
