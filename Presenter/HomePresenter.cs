using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_PS.Model;
using Tema1_PS.Model.Repository;
using Tema1_PS.View.Interfaces;

namespace Tema1_PS.Presenter
{
    internal class HomePresenter
    {
        private IHomeGui _homeGui;
        private ConferintaRepository _conferintaRepository;
        private ParticipantiRepository _participantiRepository;

        /*Vizualizarea programului conferinței pe secțiuni.*/
        public void ConferintaList()
        {
            _homeGui.ConferintaList(_conferintaRepository.GetAllConferinte());
        }

        public void ConferintaListbySectiune()
        {
            
        }

        /*Inscriere la conferinta*/
        //TODO: Implementare
        //Modal
    }
}
