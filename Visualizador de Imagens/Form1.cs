using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"C:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagensListBox.Items.AddRange(arquivos);
        }

        private void imagensListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagemPictureBox.ImageLocation = imagensListBox.Text;
            imagemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagensListBox.Text);
        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagemPictureBox.ImageLocation = favoritosListBox.Text;
            imagemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
