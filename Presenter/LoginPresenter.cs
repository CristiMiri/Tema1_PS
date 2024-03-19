using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Tema1_PS.Model.Repository;
using Tema1_PS.View.Interfaces;

namespace Tema1_PS.Presenter
{
    internal class LoginPresenter
    {
        private ILoginGui _loginGui;
        private UtilizatorRepository _utilizatorRepository;

        public LoginPresenter(ILoginGui loginGui)
        {
            _loginGui = loginGui;
            _utilizatorRepository = new UtilizatorRepository();
        }

        public void Login()
        {
            var utilizator = _utilizatorRepository.GetUtilizatorbyEmailandParola(_loginGui.getEmail(), _loginGui.getPassword());
            if (utilizator != null)
            {
                _loginGui.showShowMessage("Login successful", "Welcome " + utilizator.Nume + " ");
            }
            else
            {
                _loginGui.showShowMessage("Login failed", "Invalid username or password");
            }
        }

        public void validData()
        {
            if (_loginGui.getEmail().Length < 3 && !_loginGui.getEmail().Contains("@") && _loginGui.getEmail().Length >30)
            {
                _loginGui.showShowMessage("Invalid email", "Invalid email");
            }
            else if (_loginGui.getPassword().Length < 3)
            {
                _loginGui.showShowMessage("Password too short", "Password too short");
            }
            else
            {
                Login();
            }
        }

    }
}