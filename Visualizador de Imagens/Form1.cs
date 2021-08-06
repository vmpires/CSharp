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

            //Ler do arquivo Favoritos
            string path = ObterNomeArquivoConfig();
            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string arquivo = reader.ReadLine();
                    favoritosListBox.Items.Add(arquivo);
                }
                reader.Close();
            }                
        }

        private void imagensListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagemPictureBox.ImageLocation = imagensListBox.Text;
            imagemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string ObterNomeArquivoConfig()
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagensListBox.Text);
            GravarConfig();
        }

        private void GravarConfig()
        {
            string path = ObterNomeArquivoConfig();
            var writer = new StreamWriter(path);
            foreach (string arquivo in favoritosListBox.Items)
            {
                writer.WriteLine(arquivo);
            }
            writer.Close();
        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagemPictureBox.ImageLocation = favoritosListBox.Text;
            imagemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (favoritosListBox.SelectedItem!=null) 
            { 
                string itemSelecionado = favoritosListBox.SelectedItem.ToString();
                favoritosListBox.Items.Remove(itemSelecionado);
                GravarConfig();
            }
        }
    }
}
