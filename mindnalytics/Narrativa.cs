using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    public class Narrativa
    {
        public string nombre;
        public string imagen;
        public string path;

        public Narrativa(string Nombre, string Imagen, string Path)
        {
            this.nombre = Nombre;
            this.imagen = Imagen;
            this.path = Path;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
