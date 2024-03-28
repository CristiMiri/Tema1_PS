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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TEMA1_PS.Presenter;
using TEMA1_PS.View.Interfaces;

namespace TEMA1_PS.View
{
    /// <summary>
    /// Interaction logic for OrganizatorPage.xaml
    /// </summary>
    public partial class OrganizatorPage : Page, IOrganizatorGui
    {
        private OrganizatorPresenter _organizatorPresenter;
        public OrganizatorPage()
        {
            InitializeComponent();
            _organizatorPresenter = new OrganizatorPresenter(this);
        }

        public DataGrid GetTabelPrezentari()
        {
            return TabelPrezentari;
        }

        public DataGrid GetTabelParticipanti()
        {
            return TabelParticipanti;
        }

        public void showShowMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }
    }
}
