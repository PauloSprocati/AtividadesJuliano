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
    /// Lógica interna para ExercicioTres.xaml
    /// </summary>
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = DataNascimento.SelectedDate;

                DateTime dataAniversario = data.Value;

                DateTime aniversario = new DateTime(DateTime.Now.Year, dataAniversario.Month, dataAniversario.Day);

                if (aniversario < DateTime.Now)
                {
                    aniversario = aniversario.AddYears(1);
                }

                TimeSpan diasTotais = (aniversario - DateTime.Now);
                
                MessageBox.Show($"Resultado = {diasTotais.Days}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
