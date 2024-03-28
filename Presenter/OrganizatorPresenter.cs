using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMA1_PS.Model.Repository;
using TEMA1_PS.View.Interfaces;

namespace TEMA1_PS.Presenter
{
    internal class OrganizatorPresenter
    {
        private IOrganizatorGui _organizatorGui;
        private UtilizatorRepository utilizatorRepository;
        private ParticipantiRepository participantiRepository;
        private PrezentareRepository prezentareRepository;
        
        public OrganizatorPresenter(IOrganizatorGui organizatorGui)
        {
            _organizatorGui = organizatorGui;
            utilizatorRepository = new UtilizatorRepository();
            participantiRepository = new ParticipantiRepository();
            prezentareRepository = new PrezentareRepository();           
            _organizatorGui.GetTabelPrezentari().ItemsSource = prezentareRepository.GetPrezentari();
            _organizatorGui.GetTabelParticipanti().ItemsSource = participantiRepository.getParticipanti();
        }

        public void AddParticipant()
        {

        }

        public void RemoveParticipant() { }

        public void UpdateParticipant() { }

        public void getParticipantsBySection() { }

    }
}
