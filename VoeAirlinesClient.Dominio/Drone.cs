using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoeAirlinesClient.Dominio
{

    //drone
    public class Drone:Aeronave,IColecionavel
    {
        public bool PilhaOuBateria { get; set; }

        public void Colecionar()
        {
            Console.WriteLine("adicione a coleção: ");
        }

        //subrescrevi o metodo pai
        /*Polimorfismo: é a capacidade de um objeto assumir diferentes formas
         * de acordo com a necessidade.
         * Vimos na prática - Hands On
         * 
         */
        public override string ManterAeronave()
        {
            //impletmentando de outra forma
            //outra forma = várias formas = Poli(várias) Morfismo (forma)
            //Polimorfismo = várias formas.
            return $"{base.ManterAeronave()} e pilha {PilhaOuBateria}";
        }
    }
}
