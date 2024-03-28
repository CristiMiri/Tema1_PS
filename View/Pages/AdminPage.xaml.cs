using System;
using System.Collections.Generic;
using System.Data;
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
using TEMA1_PS.Model;
using TEMA1_PS.Presenter;
using TEMA1_PS.View.Interfaces;

namespace TEMA1_PS.View
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page, IAdminGui
    {
        private AdminPresenter _adminPresenter;
        private Action<String> callback;
        public AdminPage(Action<String> callback)
        {
            InitializeComponent();
            this._adminPresenter = new AdminPresenter(this);
            this.callback = callback;
            UserTypeComboBoxItems();
        }

        public void HideForm()
        {
            throw new NotImplementedException();
        }

        public void showShowMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public DataGrid GetDataGrid()
        {
            return TabelUtilizatori;
        }

        public int getUtilizatorId()
        {
            return IdTextBox.Text != "" ? Convert.ToInt32(IdTextBox.Text) : 0;
        }
        public void setUtilizatorId(int id)
        {
            IdTextBox.Text = id.ToString();
        }

        public string getUtilizatorNume()
        {
            return NumeTextBox.Text;   
        }

        public void setUtilizatorNume(string nume)
        {
            NumeTextBox.Text = nume;
        }

        public string getUtilizatorEmail()
        {
            return EmailTextBox.Text;
        }

        public void setUtilizatorEmail(string email)
        {
            EmailTextBox.Text = email;
        }

        public string getUtilizatorParola()
        {
            return ParolaTextBox.Text;
        }

        public void setUtilizatorParola(string parola)
        {
            ParolaTextBox.Text = parola;
        }

        public void UserTypeComboBoxItems()
        {
            UserTypeComboBox.ItemsSource = Enum.GetValues(typeof(UserType)).Cast<UserType>();
        }

        public UserType getUtilizatorType()
        {
            return (UserType)UserTypeComboBox.SelectedItem;
        }

        public void setUtilizatorType(UserType userType)
        {
            //UserTypeComboBox.SelectedItem = userType.ToString();
            UserTypeComboBox.SelectedItem = userType;
        }

        public string getUtilizatorTelefon()
        {
            return TelefonTextBox.Text;
        }

        public void setUtilizatorTelefon(string telefon)
        {
            TelefonTextBox.Text = telefon;
        }

        public void ClearFields()
        {            
            
            NumeTextBox.Text = "";
            EmailTextBox.Text = "";
            ParolaTextBox.Text = "";
            UserTypeComboBox.SelectedItem = -1;
            TelefonTextBox.Text = "";
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            _adminPresenter.DeleteUser();
            
        }


        private void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            _adminPresenter.CreateUser();
        }

        void IAdminGui.SetDataGridItemsSource(List<Utilizator> utilizators)
        {
            this.TabelUtilizatori.ItemsSource = utilizators;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            _adminPresenter.UpdateUser();
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            _adminPresenter.SetFormFields();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            callback?.Invoke("home");
        }
    }
}
