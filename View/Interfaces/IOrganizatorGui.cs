using System.Windows.Controls;

namespace TEMA1_PS.View.Interfaces
{
    internal interface IOrganizatorGui : IGUI
    {
        DataGrid GetTabelPrezentari();
        DataGrid GetTabelParticipanti();
    }
}
