using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_PS.Model.Repository
{
    internal class ParticipantiRepository
    {
        private Repository repository;
        private UtilizatorRepository utilizatorRepository;
        private ConferintaRepository conferintaRepository;
        // Link Table Conferinta-Utilizator (participanti)

        public ParticipantiRepository()
        {
            repository = new Repository();
            utilizatorRepository = new UtilizatorRepository();
            conferintaRepository = new ConferintaRepository();
        }

        public DataTable Participanti()
        {
            string query = "SELECT * FROM conferinte_utilizatori";
            DataTable participantiTable = repository.ExecuteQuery(query);
            return participantiTable;
        }

        public List<Utilizator> GetUtilizatoribyConferinta(Conferinta conferinta)
        {
            DataTable participanti = Participanti();
            if (participanti == null)
            {
                return null;
            }
            List<Utilizator> utilizatori = new List<Utilizator>();
            foreach (DataRow row in participanti.Rows)
            {
                if (Convert.ToInt32(row["id_conferinta"]) == conferinta.Id)
                {
                    UtilizatorRepository utilizatorRepository = new UtilizatorRepository();
                    Utilizator utilizator = utilizatorRepository.GetUtilizatorById(Convert.ToInt32(row["id_utilizator"]));
                    utilizatori.Add(utilizator);
                }
            }
            return utilizatori;
        }

        public List<Utilizator> GetUtilizatoribySectiune(Sectiune sectiune)
        {
            List<Conferinta> conferinte = conferintaRepository.GetConferinteBySectiune(sectiune);
            DataTable participanti = Participanti();
            if (participanti == null || conferinte == null)
            {
                return null;
            }
            List<Utilizator> utilizatori = new List<Utilizator>();
            foreach (Conferinta conferinta in conferinte)
            {
                foreach (DataRow row in participanti.Rows)
                {
                    if (Convert.ToInt32(row["id_conferinta"]) == conferinta.Id)
                    {
                        UtilizatorRepository utilizatorRepository = new UtilizatorRepository();
                        Utilizator utilizator = utilizatorRepository.GetUtilizatorById(Convert.ToInt32(row["id_utilizator"]));
                        utilizatori.Add(utilizator);
                    }
                }
            }
            return utilizatori;
        }

        public bool addParticipanti(Conferinta conferinta, Utilizator utilizator)
        {
            string nonQuery = "INSERT INTO conferinte_utilizatori VALUES (" +
                conferinta.Id + ", " +
                utilizator.Id + ")";
            return repository.ExecuteNonQuery(nonQuery);
        }

        public bool deleteParticipanti(Conferinta conferinta, Utilizator utilizator)
        {
            string nonQuery = "DELETE FROM conferinte_utilizatori WHERE id_conferinta = " +
                conferinta.Id + " AND id_utilizator = " +
                utilizator.Id;
            return repository.ExecuteNonQuery(nonQuery);
        }

        public bool deleteParticipanti(Conferinta conferinta)
        {
            string nonQuery = "DELETE FROM conferinte_utilizatori WHERE id_conferinta = " +
                conferinta.Id;
            return repository.ExecuteNonQuery(nonQuery);
        }

        public bool deleteParticipanti(Utilizator utilizator)
        {
            string nonQuery = "DELETE FROM conferinte_utilizatori WHERE id_utilizator = " +
                utilizator.Id;
            return repository.ExecuteNonQuery(nonQuery);
        }
    }
}
