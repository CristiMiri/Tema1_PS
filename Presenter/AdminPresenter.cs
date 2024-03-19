using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_PS.Model.Repository;
using Tema1_PS.View.Interfaces;

namespace Tema1_PS.Presenter
{
    internal class AdminPresenter
    {
        private IAdminGui _adminGui;
        private UtilizatorRepository utilizatorRepository;

        public AdminPresenter(IAdminGui adminGui)
        {
            _adminGui = adminGui;
            utilizatorRepository = new UtilizatorRepository();
        }

        /*Operații CRUD pentru informațiile legate de utilizatorii aplicației care necesită autentificare;*/
        /*ToDO Implementare*/
        //Modal
        public void AddUtilizator()
        {
            Utilizator utilizator = validInformation();
            if (utilizator != null)
            {
                utilizatorRepository.addUtilizator(utilizator);
                _adminGui.UtilizatorList(utilizatorRepository.UtilizatorTable());
                resetUtilizatorControls();
            }
        }

        public void DeleteUtilizator()
        {
            Utilizator utilizator = validInformation();
            if (utilizator != null)
            {
                utilizatorRepository.DeleteUtilizator(utilizator);
                _adminGui.UtilizatorList(utilizatorRepository.GetAllUtilizatori());
                resetUtilizatorControls();
            }
        }

        public void UpdateUtilizator()
        {
            Utilizator utilizator = validInformation();
            if (utilizator != null)
            {
                utilizatorRepository.UpdateUtilizator(utilizator);
                _adminGui.UtilizatorList(utilizatorRepository.GetAllUtilizatori());
                resetUtilizatorControls();
            }
        }

        public void SearchUtilizatorByIDOrName()
        {
            Utilizator utilizator = validInformation();
            if (utilizator != null)
            {
                List<Utilizator> utilizatori = utilizatorRepository.SearchUtilizatorByIDOrName(utilizator);
                _adminGui.UtilizatorList(utilizatori);
            }
        }
        //Vizualizarea listei tuturor utilizatorilor care necesită autentificare
        public void allUtilizatori()
        {
            _adminGui.UtilizatorList(utilizatorRepository.GetAllUtilizatori());
        }

        private void validUtilizatorData()
        {
                        if (_adminGui.UtilizatorName == "")
            {
                _adminGui.UtilizatorNameError = "Name is required!";
            }
            else
            {
                _adminGui.UtilizatorNameError = "";
            }

            if (_adminGui.UtilizatorPassword == "")
            {
                _adminGui.UtilizatorPasswordError = "Password is required!";
            }
            else
            {
                _adminGui.UtilizatorPasswordError = "";
            }
        }
        
    }
}
