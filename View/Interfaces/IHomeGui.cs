using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_PS.Model;

namespace Tema1_PS.View.Interfaces
{
    internal interface IHomeGui : IGUI
    {
        public Sectiune getSelectedSectiune();
        public void setSectiuni(List<Sectiune> sectiuni);
        public void ResetSelectedSectiune();
        public void setSectiune(Sectiune sectiune);
        public void GetConferine();
        public void getConferintebySectiune(Sectiune sectiune);


    }
}
