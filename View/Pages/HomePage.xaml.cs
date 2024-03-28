using System.Windows;
using System.Windows.Controls;
using TEMA1_PS.Model;
using TEMA1_PS.Presenter;
using TEMA1_PS.View.Interfaces;

namespace TEMA1_PS.View.Pages
{
    public partial class HomePage : Page,IHomeGui
    {
        private HomePresenter presenter;
        public HomePage()
        {
            InitializeComponent();
            presenter = new HomePresenter(this);
        }

       
        public string getEmail()
        {
            return txtEmail.Text;
        }

        public string getNume()
        {
            return txtNume.Text;
        }

        public string getPrezentareSelectata()
        {
            return cmbPrezentare.SelectedItem.ToString();
        }



        public string getTelefon()
        {
            return txtTelefon.Text;
        }

        public void setEmail(string email)
        {
            txtEmail.Text = email;
        }

        public void setNume(string nume)
        {
            txtNume.Text = nume;
        }

        public void setPrezentareSelectata(string prezentare)
        {
            cmbPrezentare.SelectedItem = prezentare;
        }

        public void setPrezentariSelection(List<string> prezentari)
        {
            cmbPrezentare.ItemsSource = prezentari;
        }

        
        public void setTelefon(string telefon)
        {
            txtTelefon.Text = telefon;
        }

        public void showShowMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void accordionButton_Checked(object sender, RoutedEventArgs e)
        {
            // Show contentBorder when ToggleButton is checked
            contentBorder.Visibility = Visibility.Visible;
            accordionButton.Content = "Inscriere▼";
        }

        private void accordionButton_Unchecked(object sender, RoutedEventArgs e)
        {
            // Hide contentBorder when ToggleButton is unchecked
            contentBorder.Visibility = Visibility.Collapsed;
            accordionButton.Content = "Inscriere▲";
        }

    }
}
