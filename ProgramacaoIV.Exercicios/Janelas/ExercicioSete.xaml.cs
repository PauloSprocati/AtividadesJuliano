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
using System.Windows.Shapes;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioSete.xaml
    /// </summary>
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {

            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                comboBoxParcelas.Items.Add(i);
            }
            comboBoxParcelas.SelectedIndex = 0;

        }

        private void Simular_Click(object sender, RoutedEventArgs e)
        {
            bool isTotalValid = decimal.TryParse(textBoxValorTotal.Text, out decimal valorTotal);

            if (isTotalValid && comboBoxParcelas.SelectedItem != null)
            {
                int parcelas = (int)comboBoxParcelas.SelectedItem;

                decimal valorParcela = valorTotal / parcelas;

                MessageBox.Show($"Valor de cada parcela: {valorParcela:C}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                MessageBox.Show("Por favor, insira um valor válido e selecione o número de parcelas.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
