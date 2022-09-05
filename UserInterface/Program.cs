using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion unCamion = new Camion();
            unCamion.Chapa = "CHA4545";
            unCamion.Carga = 1000;
            Console.WriteLine("El camion matricula {0} soporta hasta {1}", unCamion.Chapa,unCamion.Carga);
            Console.ReadLine();
        }
    }
}