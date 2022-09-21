using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    internal class Program
    {
        // En una clase abstracta se permite crear funciones y propiedades que las subclases pueden implementar o anular.
        // En una interfaz solo se permite definir la funcionalidad, no implementarla dentro de ella.
        // Una clase puede extender solo una clase abstracta.
        // Pero puede aprovechar múltiples interfaces.
        static void Main(string[] args)
        {
            // Instanciar una persona como la interfaz
            IPersona persona = new Persona();
            persona.Comer();
            // Al hacerlo de esta forma no podemos acceder a las properties de la calse persona.
            

            Persona persona2 = new Persona();
            persona2.Nombre = "pepe";
            // Para poder realizar esta accion descomentar la implementacion de los metodos en la clase persona.
            // persona2.Comer();



            ClasseA classeA = new ClasseA();
            classeA.PropA = "A";
            // Para poder realizar esta accion descomentar la implementacion de lso metods en la clase ClasseA.
            //classeA.MethodA();
            // Si la clase abstracta fue implementada correctamente podremos acceder tambien a sus metodos desde la clase hija (ClasseA)
            //classeA.MethodC();
            
            //Como la clase es abstracta no se puede instanciar.
            //ClasseAabstracta abstract = new ClasseAabstracta();


        }
    }
}
