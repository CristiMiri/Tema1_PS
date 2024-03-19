using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_PS.Model.Repository;
using Tema1_PS.View.Interfaces;

namespace Tema1_PS.Presenter
{
    internal class OrganizatorPresenter
    {
        private IOrganizatorGui _organizatorGui;
        private UtilizatorRepository utilizatorRepository;
        private ParticipantiRepository participantiRepository;
        
        public OrganizatorPresenter(IOrganizatorGui organizatorGui)
        {
            _organizatorGui = organizatorGui;
            utilizatorRepository = new UtilizatorRepository();
            participantiRepository = new ParticipantiRepository();
        }

        public void AddParticipant()
        {

        }

        public void RemoveParticipant() { }

        public void UpdateParticipant() { }

        public void getParticipantsBySection() { }

    }
}
