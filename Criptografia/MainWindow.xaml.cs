using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Criptografia
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCriptografar_Click(object sender, RoutedEventArgs e)
        {
            txtCriptografado.Text = string.Empty;
            for (int i = 0; i <txtTexto.Text.Length; i++)
            {
                int txtUsuario = (int)txtTexto.Text[i];
                int txtCifrado = txtUsuario + 10;

                txtCriptografado.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void btLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtCriptografado.Text = string.Empty;
            txtTexto.Text = string.Empty;
        }

        private void btDescriptografar_Click(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < txtCriptografado.Text.Length; i++)
            {
                int txtCifrado = (int)txtCriptografado.Text[i];
                int txtOriginal = txtCifrado - 10;

                txtCriptografado.Text += char.ConvertFromUtf32(txtOriginal);
            }
        }
    }
}
