using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_PS.View.Interfaces
{
    internal interface ILoginGui : IGUI
    {
        String getEmail();
        String getPassword();
        void Login();
        void validData();
        void goBack();
    }
}
