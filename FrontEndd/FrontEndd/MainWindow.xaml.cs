using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    /// 
    public class Program : INotifyPropertyChanged
    {
        string nome;
        int valorPassagem;
        int valorTotal;

        public event PropertyChangedEventHandler PropertyChanged;
    }
  
    public class Cliente
    {
        private string nome;
        public double valorPassagem;
        public int valorTotal;

        public string FirstName
        {
            get { return nome; }
            set { nome = value; }
        }

        public double ValorPassagem
        {
            get { return valorPassagem; }
            set { valorPassagem = value; }
        }

        public int ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public object PropertyChanged { get; private set; }

        public Cliente(string nome, double valorPassagem, int valorTotal)
        {
            nome = nome;
            valorPassagem = valorPassagem;
            valorTotal = valorTotal;
        }
        public void NotifyPropertyChanged ([CallerMemberName] string propName = null)
        {
         
        }
    }

    public partial class MainWindow : Window
    {
        bool click = true;
        int op = 0;
        


        public MainWindow()
        {
            InitializeComponent();

        }

        public object tela { get; private set; }

        private void AlterarTela(object sender, SelectionChangedEventArgs e)



        {

            op = Cadastrar1.SelectedIndex;
            if (op >= 0) ;
            switch (op)
            {
                case 0:
                    {
                        GridPrincipal.Child = null;
                        GridPrincipal.Child = new Tela();
                        //Cadastrar1.Items.Clear();
                        //Cadastrar1.Items.Add(new Tela());

                        break;
                    }
                case 1:
                    {
                        GridPrincipal.Child = null;
                        GridPrincipal.Child = new tela2();
                        break;
                    }
                case 2:
                    {
                        GridPrincipal.Child = null;
                        GridPrincipal.Child = new tela3();
                        break;
                    }




            }





        }

        private void oi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
public class Funcionario
{
    private string nome = " ";
    private double valorPassagem = 0;
    double tudo = 0;

    public Funcionario(string nome, double valorPassagem)
    {
        this.nome = nome;
        this.valorPassagem = valorPassagem;
    }

    public Funcionario()
    {

    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double ValorPassagem
    {
        get { return valorPassagem; }
        set { valorPassagem = value; }
    }

    public string toString()
    {
        return
        "\nFuncionario: " + nome + "\nValor Passagem: " + valorPassagem + "\n";
    }
}
public partial class Tela : UserControl
{
    public ObservableCollection<Funcionario> funcionario
    {
        get; set;
    }

    public Tela()
    {
        funcionario = new ObservableCollection<Funcionario>();
        funcionario.Add(new Funcionario());
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    public static object Children { get; internal set; }
}



