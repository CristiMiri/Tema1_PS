using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TEMA1_PS.View.Interfaces
{
    internal interface IMainGui
    {        
        public Frame GetFrame();
        public void SetFrameContent(Page page);
        public void ShowHeader();
        public void HideHeader();
    }
}
