using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    public class Asset
    {
        public string nombre;
        public int x;
        public int y;
        public string path;

        public Asset(string nombre,int x,int y,string path) { 
            this.nombre = nombre;
            this.x = x;
            this.y = y;
            this.path = path;
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
