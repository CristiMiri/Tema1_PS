using System.Windows.Controls;
using TEMA1_PS.Model;

namespace TEMA1_PS.View.Interfaces
{
    internal interface IAdminGui : IGUI
    {
        //void UtilizatorList(List<Utilizator> utilizators);
        DataGrid GetDataGrid();
        void SetDataGridItemsSource(List<Utilizator> utilizators);
        int    getUtilizatorId();
        void   setUtilizatorId(int id);
        String getUtilizatorNume();
        void setUtilizatorNume(String nume);
        String getUtilizatorEmail();
        void setUtilizatorEmail(String email);
        String getUtilizatorParola();
        void setUtilizatorParola(String parola);
        UserType getUtilizatorType();
        void setUtilizatorType(UserType userType);
        String getUtilizatorTelefon();
        void setUtilizatorTelefon(String telefon);
        void ClearFields();
        
                   
    }
}
