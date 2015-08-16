using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    
    public class Grupo
    {
        public string nombre;
        public int ordenZ;
        public List<Asset> listaAssets = new List<Asset>();


        public Grupo(string Nombre, int ordenZ, List<Asset> listaAssets)
        {
            this.nombre = Nombre;
            this.ordenZ = OrdenZ;
            this.listaAssets = listaAssets;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int OrdenZ
        {
            get { return ordenZ; }
            set { ordenZ = value; }

        }

        public List<Asset> ListaAssets {
            get { return listaAssets; }
            set { listaAssets = value; }
        }
        


    }
}
