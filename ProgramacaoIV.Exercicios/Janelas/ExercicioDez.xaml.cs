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
    /// Lógica interna para ExercicioDez.xaml
    /// </summary>
    public partial class ExercicioDez : Window
    {
        private Random random = new Random();
        public ExercicioDez()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7); 


            if (numeroSorteado == 6)
            {

                MessageBox.Show("Você ganhou!", "Resultado do Sorteio", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                MessageBox.Show("Tente novamente!", "Resultado do Sorteio", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
