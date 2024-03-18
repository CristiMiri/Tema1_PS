using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_PS.Model.Repository
{
    internal class PrezentareRepository
    {
        private Repository repository;
        private DataTable prezentariTable;
        /* Prezentare = private int id;
                        private String titlu;
                        private String autor;
                        private String descriere;
                        private String data;
                        private String ora; */
        public PrezentareRepository()
        {
            repository = new Repository();
        }

        public Repository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public void PrezentareTable()
        {
            string query = "SELECT * FROM prezentari";
            prezentariTable = repository.ExecuteQuery(query);
            if (prezentariTable != null || prezentariTable.Rows.Count != 0)
            {
                this.prezentariTable = prezentariTable;
            }
        }

        public Prezentare rowToPrezentare(DataRow row)
        {
            Prezentare prezentare = new Prezentare();
            prezentare.Id = Convert.ToInt32(row["id"]);
            prezentare.Titlu = row["titlu"].ToString();
            prezentare.Autor = row["autor"].ToString();
            prezentare.Descriere = row["descriere"].ToString();
            prezentare.Data = row["data"].ToString();
            prezentare.Ora = row["ora"].ToString();
            return prezentare;
        }

        public DataTable PrezentariTable
        {
            get { return prezentariTable; }
            set { prezentariTable = value; }
        }

        //CRUD
        public bool AddPrezentare(Prezentare prezentare)
        {
            string query = "INSERT INTO prezentari (titlu, autor, descriere, data, ora) VALUES ('" +
                    prezentare.Titlu + "', '" +
                    prezentare.Autor + "', '" +
                    prezentare.Descriere + "', '" +
                    prezentare.Data + "', '" +
                    prezentare.Ora + "')";
            return repository.ExecuteNonQuery(query);
        }

        public List<Prezentare> GetPrezentari()
        {
            PrezentareTable();
            List<Prezentare> prezentari = new List<Prezentare>();
            foreach (DataRow row in prezentariTable.Rows)
            {
                prezentari.Add(rowToPrezentare(row));
            }
            return prezentari;
        }

        public Prezentare GetPrezentarebyId(int id)
        {
            PrezentareTable();
            foreach (DataRow row in prezentariTable.Rows)
            {
                if (Convert.ToInt32(row["id"]) == id)
                {
                    return rowToPrezentare(row);
                }
            }
            return null;
        }

        public bool UpdatePrezentare(Prezentare prezentare)
        {
            string query = "UPDATE prezentari SET " +
                "titlu = '" + prezentare.Titlu + "', " +
                "autor = '" + prezentare.Autor + "', " +
                "descriere = '" + prezentare.Descriere + "', " +
                "data = '" + prezentare.Data + "', " +
                "ora = '" + prezentare.Ora + "' " +
                "WHERE id = " + prezentare.Id;
            return repository.ExecuteNonQuery(query);
        }

        public bool DeletePrezentare(int id)
        {
            string query = "DELETE FROM prezentari WHERE id = " + id;
            return repository.ExecuteNonQuery(query);
        }

        //Filters
    }
}
