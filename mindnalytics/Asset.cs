using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    public class Asset
    {
        public string Nombre;
        public int X;
        public int Y;
        public string Path;

        public Asset(string nombre,int x,int y,string path) { 
            this.Nombre = nombre;
            this.X = x;
            this.Y = y;
            this.Path = path;
        }
        
    }
}
