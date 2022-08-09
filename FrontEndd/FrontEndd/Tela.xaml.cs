using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FrontEndd
{
    /// <summary>
    /// Interação lógica para Tela.xam
    /// </summary>
    public partial class Tela : UserControl
    {
        public ObservableCollection<Funcionario> funcionario
        {
            get ; set;
        }

        public Tela()
        {
            funcionario = new ObservableCollection<Funcionario>();
            funcionario.Add(new Funcionario());
            InitializeComponent();
        }

        public static object Children { get; internal set; }
    }
}
