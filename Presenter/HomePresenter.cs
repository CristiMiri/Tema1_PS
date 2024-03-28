using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMA1_PS.Model;
using TEMA1_PS.Model.Repository;
using TEMA1_PS.View.Interfaces;

namespace TEMA1_PS.Presenter
{
    internal class HomePresenter
    {
        private IHomeGui _homeGui;
        private ConferintaRepository _conferintaRepository;
        private PrezentareRepository _prezentareRepository;
        private ParticipantiRepository _participantiRepository;
    
        public HomePresenter(IHomeGui homeGui)
        {
            _homeGui = homeGui;
            _conferintaRepository = new ConferintaRepository();
            _participantiRepository = new ParticipantiRepository();
            _prezentareRepository = new PrezentareRepository();
            List<String> list = new List<String>();
            List<Prezentare> prezentari = _prezentareRepository.GetPrezentari();
            foreach (Prezentare prezentare in prezentari)
            {
                list.Add(prezentare.Titlu);
            }
            _homeGui.setPrezentariSelection(list);
        }
        


        /*Inscriere la conferinta*/
        //TODO: Implementare
        //Modal
    }
}
