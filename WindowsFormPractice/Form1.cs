using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 + numero2;

            resultadoLabel.Text = Convert.ToString(resultado);
        }

        private void subtrairButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 - numero2;

            resultadoLabel.Text = Convert.ToString(resultado);
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 * numero2;

            resultadoLabel.Text = Convert.ToString(resultado);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToInt32(numero1TextBox.Text);
            double numero2 = Convert.ToInt32(numero2TextBox.Text);
            double resultado = numero1 / numero2;

            resultadoLabel.Text = Convert.ToString(resultado);
        }
    }
}
