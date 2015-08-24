using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    class ItemsEstudio
    {

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public ItemsEstudio(int numero, string nombre, string tipo)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public ItemsEstudio()
        {

        }
    }
}
