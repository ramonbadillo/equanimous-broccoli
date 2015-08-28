using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    public class GrupoNarrativa
    {

        private List<Narrativa> listaNarrativas;

        

        public GrupoNarrativa()
        {

        }

        public GrupoNarrativa(List<Narrativa> listaNarrativas)
        {
            this.listaNarrativas = listaNarrativas;
        }


        public List<Narrativa> ListaNarrativas
        {
            get { return listaNarrativas; }
            set { listaNarrativas = value; }
        }
    }
}
