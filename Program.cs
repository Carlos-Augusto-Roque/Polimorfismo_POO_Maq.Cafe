using System;
using Polimorfismo_POO_Maq.Cafe.classes;

namespace Polimorfismo_POO_Maq.Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe nespresso = new MaquinaCafe();
            
            Console.WriteLine("Nespresso - CafeteiraTabajaras Plus++");
            nespresso.FazerCafe(nespresso.quantidadeAcucar,nespresso.acucarDisponivel);

            nespresso.FazerCafe();
        }

            
    }
}
