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

namespace cadastro_escola
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

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            string nomeFantasia = txtNomeFantasia.Text;
            string razaoSocial = txtRazaoSocial.Text;
            string cnpj = txtCNPJ.Text;
            string contato = txtContato.Text;
            string email = txtEmail.Text;
            string inscricaoEstad = txtInscEstadual.Text;
            string responsavel = txtResponsavel.Text;
            string cidade = txtCidade.Text;
            string rua = txtRua.Text;
            string bairro = txtBairro.Text;
            string cep = txtCEP.Text;
            string numero = txtNumero.Text;
            string pontRef = txtReferencia.Text;
            string uf = txtUF.Text;
            string tipo = "Informação Vaga";
            

            if (rdTipoPublico.IsChecked == true)
            {
                tipo = rdTipoPublico.Content.ToString();
            }
            if (rdTipoPrivada.IsChecked == true)
            {
                tipo = rdTipoPrivada.Content.ToString();
            }


            MessageBox.Show("Nome Fantasia: " + nomeFantasia + Environment.NewLine +
                "Razão Social: " + razaoSocial + Environment.NewLine +
                "CNPJ: " + cnpj + Environment.NewLine +
                "Contatol: " + contato + Environment.NewLine +
                "E-mail: " + email + Environment.NewLine +
                "Incrição estadual: " + inscricaoEstad + Environment.NewLine +
                "Responsável: " + responsavel + Environment.NewLine + 
                "Tipo: " + tipo + Environment.NewLine +
                "Cidade: " + cidade + Environment.NewLine +
                "Rua: " + rua + Environment.NewLine +
                "Bairro: " + bairro + Environment.NewLine + 
                "CEP: " + cep + Environment.NewLine +
                "N°: " + numero + Environment.NewLine +
                "Ponto de referência: " + pontRef + Environment.NewLine +
                "UF: " + uf + Environment.NewLine);
        }
    }
}
