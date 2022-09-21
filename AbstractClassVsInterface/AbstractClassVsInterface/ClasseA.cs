using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    // En este tampoco compila ya que tenemos que implementar todos los metodos abstractos.
    public class ClasseA : ClasseAabstracta
    {
        public string PropA { get; set; }

        public int PropB { get; set; }


        // Descomentar estos metodos para ver que si implementamos los metodos funciona correctamente.

        //public override void MethodA()
        //{
        //    throw new NotImplementedException();
        //}

        //public override int MethodB()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
