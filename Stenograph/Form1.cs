using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stenograph
{
    public partial class Form1 : Form
    {

        public string OriginalText;
        private string name;
        bool Rus, Eng;

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "ImageFilter(*.BMP; *JPG; *GIF; *PNG) | *.BMP; *.JPG; *.GIF; *.PNG";

            if (Open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxIn.Image = new Bitmap(Open.FileName);
                }

                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (pictureBoxOut.Image != null)
            {
                SaveFileDialog Save = new SaveFileDialog();
                Save.Title = "Сохранить изображение как";
                Save.OverwritePrompt = true;
                Save.CheckPathExists = true;
                Save.Filter = "ImageFilter(*.BMP; *JPG; *GIF; *PNG) | *.BMP; *.JPG; *.GIF; *.PNG";
                Save.ShowHelp = true;

                if (Save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBoxOut.Image.Save(Save.FileName);
                    }

                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

        }

        private void OpenText_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenText = new OpenFileDialog();
            OpenText.Filter = "ImageFilter(*.TXT) | *.TXT";

            if (OpenText.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    name = OpenText.FileName;
                    tbOriginal.Text = File.ReadAllText(name);
                }

                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            if (RusCheck.Checked)
            {
                Rus = true;
            }

            if (EngCheck.Checked)
            {
                Eng = true;
            }
            Steno sten;
            sten.Initialize(Rus,Eng);
            Bitmap Input = new Bitmap(pictureBoxIn.Image);
            Bitmap Output = new Bitmap(Input.Width, Input.Height);

            for (int j = 0; j < Input.Height; j++)
            {
                for (int i = 0; i < Input.Width; i++)
                {
                    UInt32 Pixel = (UInt32)(Input.GetPixel(i,j).ToArgb());
                    Output.SetPixel(Pixel);
                    Output.SetPixel(sten.XCoordinate(), sten.YCoordinate());
                }
            }
        }
    }
}
