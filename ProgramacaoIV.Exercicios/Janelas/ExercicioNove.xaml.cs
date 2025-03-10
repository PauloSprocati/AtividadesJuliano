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
    /// Lógica interna para ExercicioNove.xaml
    /// </summary>
    public partial class ExercicioNove : Window
    {
        private bool isLigado = false;
        public ExercicioNove()
        {
            InitializeComponent();
        }

        private void btnInterruptor_Click(object sender, RoutedEventArgs e)
        {
            if (isLigado)
            {

                isLigado = false;
                btnInterruptor.Content = "Desligado"; 
                MessageBox.Show("O interruptor está Desligado.", "Estado Atual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                isLigado = true;
                btnInterruptor.Content = "Ligado";
                MessageBox.Show("O interruptor está Ligado.", "Estado Atual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
