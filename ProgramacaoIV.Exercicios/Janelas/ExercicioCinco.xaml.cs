using ProgramacaoIV.Exercicios.Janelas.Enum;

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
using System;
using System.ComponentModel;
using System.Reflection;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioCinco.xaml
    /// </summary>
    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();

            comboTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario)).OfType<TipoUsuario>().ToList();
        }

        private void btnExibirDescrições_Click(object sender, RoutedEventArgs e)
        {
            TipoUsuario tipoSelecionado = (TipoUsuario)comboBoxTipoUsuario.SelectedItem;

            // Obter a descrição do enum selecionado
            string descricao = GetEnumDescription(tipoSelecionado);

            // Exibir a descrição em um MessageBox
            MessageBox.Show(descricao, "Descrição do Tipo de Usuário");
        }

        private string GetEnumDescription(Enum value)
        {
            // Obter o atributo de descrição do valor do Enum
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
