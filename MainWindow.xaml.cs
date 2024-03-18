using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tema1_PS.Model.Repository;

namespace Tema1_PS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Console.WriteLine("Hello World!");
            Repository repository = new Repository();
            //SELECT * FROM public."Tester";
            //print all the data from the table
            DataTable dataTable =repository.ExecuteQuery("SELECT * FROM public.\"Tester\";");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["id"]);
            }
            MessageBox.Show("Hello World!");

        }
    }
}