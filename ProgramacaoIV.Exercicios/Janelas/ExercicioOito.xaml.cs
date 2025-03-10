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
    /// Lógica interna para ExercicioOito.xaml
    /// </summary>
    public partial class ExercicioOito : Window
    {
        public ExercicioOito()
        {
            InitializeComponent();
        }

        private void MostrarDiasSemana_Click(object sender, RoutedEventArgs e)
        {

            if (DatePicker.SelectedDate.HasValue)
            {

                DateTime dataSelecionada = DatePicker.SelectedDate.Value;
                DayOfWeek diaDaSemana = dataSelecionada.DayOfWeek;


                EnumDiasSemana diaEnum = (EnumDiasSemana)diaDaSemana;

                MessageBox.Show($"O dia da semana é: {diaEnum}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
