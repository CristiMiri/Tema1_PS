using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_PS.Model
{
    internal class Prezentare
    {
        private int id;
        private String titlu;
        private String autor;
        private String descriere;
        private String data;
        private String ora;

        public Prezentare(int id, string titlu, string autor, string descriere, string data, string ora)
        {
            this.id = id;
            this.titlu = titlu;
            this.autor = autor;
            this.descriere = descriere;
            this.data = data;
            this.ora = ora;
        }

        public Prezentare(Prezentare prezentare)
        {
            this.id = prezentare.id;
            this.titlu = prezentare.titlu;
            this.autor = prezentare.autor;
            this.descriere = prezentare.descriere;
            this.data = prezentare.data;
            this.ora = prezentare.ora;
        }

        public Prezentare()
        {
            this.id = 0;
            this.titlu = "";
            this.autor = "";
            this.descriere = "";
            this.data = "";
            this.ora = "";
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }
        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public String Descriere
        {
            get { return descriere; }
            set { descriere = value; }
        }
        public String Data
        {
            get { return data; }
            set { data = value; }
        }
        public String Ora
        {
            get { return ora; }
            set { ora = value; }
        }

    }
}
