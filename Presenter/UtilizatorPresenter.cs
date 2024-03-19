using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_PS.Model.Repository;
using Tema1_PS.View.Interfaces;

namespace Tema1_PS.Presenter
{
    internal class UtilizatorPresenter
    {
        //Accesarea volumului conferinței'
        private IUtilizatorGui _utilizatorGui;
        private ConferintaRepository _conferintaRepository;
        private UtilizatorRepository _utilizatorRepository;
        private PrezentareRepository _prezentareRepository;

        public UtilizatorPresenter(IUtilizatorGui utilizatorGui)
        {
            _utilizatorGui = utilizatorGui;
            _conferintaRepository = new ConferintaRepository();
            _utilizatorRepository = new UtilizatorRepository();
            _prezentareRepository = new PrezentareRepository();
        }

        public void getConferinte()
        {
            _utilizatorGui.setConferinte = _conferintaRepository.GetAll();
        }

        public void getPretentari()
        {
            _utilizatorGui.setPrezentari = _prezentareRepository.GetAll();
        }

        public void getPrezentaribyConferinta()
        {
            
        }
    }
}
