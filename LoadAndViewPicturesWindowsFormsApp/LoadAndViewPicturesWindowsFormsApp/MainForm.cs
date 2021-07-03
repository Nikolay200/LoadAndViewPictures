using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
