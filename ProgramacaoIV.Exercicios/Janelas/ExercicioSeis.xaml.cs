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
    /// Lógica interna para ExercicioSeis.xaml
    /// </summary>
    public partial class ExercicioSeis : Window
    {
        private int contador = 0;
        public ExercicioSeis()
        {

            InitializeComponent();
        }

        private void Incrementar_Click(object sender, RoutedEventArgs e)
        {
            contador++;

            MessageBox.Show($"Contador: {contador}", "Contador", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
