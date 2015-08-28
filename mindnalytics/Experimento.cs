using Polenter.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    public class Experimento
    {

        Estudio estudioAbierto;
        GrupoNarrativa grupoNarrGet;
        string sujetoPrueba;
        List<Narrativa> listaNarrativas;


        public Experimento(Estudio estudioAbierto, string sujetoPrueba)
        {
            this.estudioAbierto = estudioAbierto;
            this.sujetoPrueba = sujetoPrueba;


            try
            {
                var serializer = new SharpSerializer();
                Console.WriteLine(estudioAbierto.FolderName + "//" + "Narrativas-" + estudioAbierto.ProjectName + ".xml");
                grupoNarrGet = (GrupoNarrativa)serializer.Deserialize(estudioAbierto.FolderName + "//" + "Narrativas-" + estudioAbierto.ProjectName + ".xml");
                listaNarrativas = grupoNarrGet.ListaNarrativas;
                Console.WriteLine(grupoNarrGet.ListaNarrativas);
                getElementos();

            }
            catch (Exception es)
            {
                Console.WriteLine("Error al cargar las Narrativas del proyecto");
                Console.WriteLine(es);
            }

            

        }




        public bool wait = true;
        public void getElementos()
        {
            

            if (estudioAbierto.ListaItemsEstudio.Count != 0){

            
                if (estudioAbierto.ListaItemsEstudio.First().Tipo == "GA")
                {
                    getGrupoAssets(estudioAbierto.ListaItemsEstudio.First().Nombre);
                    //Experimento experimento1 = new Experimento(estudioAbierto, sujetoPrueba,this);
                    //ObjetosAnalisisScores objAnSc = new ObjetosAnalisisScores(estudioAbierto, sujetoPrueba, this);
                    ImagenOA imgOA = new ImagenOA(this);
                    imgOA.Show();
                
                
                }
                else if (estudioAbierto.ListaItemsEstudio.First().Tipo == "N")
                {

                    ImagenNarrativa iNarr = new ImagenNarrativa(this, getNarrativa(estudioAbierto.ListaItemsEstudio.First().Nombre));
                    iNarr.Show();
                }
                else
                {
                    Console.WriteLine("Hay un error con el archivo del proyecto");
                }

                estudioAbierto.ListaItemsEstudio.RemoveAt(0);
            }
            else
                Console.WriteLine("El experimento ya ha terminado");
        }

        Narrativa narr;
        public Narrativa getNarrativa(string Nombre)
        {
            narr = null;
            if (listaNarrativas != null)
            {
                foreach (Narrativa narrativa in listaNarrativas)
                {
                    if (narrativa.Nombre == Nombre)
                        narr = narrativa;
                }

            }
            else
                Console.WriteLine("La lista de narrativas esta vacia");
            if (narr == null)
                Console.WriteLine("No se encontro narrativa");

            return narr;
        }
        
        Grupo grupoAssetsGet;
        public Grupo getGrupoAssets(string Nombre)
        {
            grupoAssetsGet = null;
            try
            {
                var serializer = new SharpSerializer();
                Console.WriteLine(estudioAbierto.FolderName+ "//" + Nombre + ".xml");
                grupoAssetsGet = (Grupo)serializer.Deserialize(estudioAbierto.FolderName + "//" + Nombre + ".xml");
                Console.WriteLine(estudioAbierto.ProjectName);

            }
            catch (Exception es)
            {
                Console.WriteLine("Error al Cargar: "+Nombre);
                Console.WriteLine(es);
            }
            return grupoAssetsGet;

        }

        


    }
}
