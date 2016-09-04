using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesyConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables  <- Son el lugar donde se almacena la informacion
            // = asignacion de valores a mi variable
            //Variables de tipo variente
            var name = "Marcos Silverio Castro"; //<-Instruccion
            var age = 24;
            var phoneNumber = "012512518";
            var pi = 3.141516;
            //Variables de un solo tipo
            int numberPets = 20;
            double dollar = 3.14;
            string lastname = "Silverio castro";
            bool isMale = true;
            //Ejercicios
            int cantidadCel = 15;
            //Declarar mis variables sin asignarle
            int cantidadPersonajes;
            cantidadPersonajes = 10;
            cantidadPersonajes = 11;
            cantidadPersonajes = 20;
            int cantidadDeComputadoras;
            cantidadDeComputadoras = 2;
            cantidadPersonajes = cantidadDeComputadoras;
            //Declarar constantes
            const int gravedad = 10;
            //imprimir en consola 
            Console.WriteLine(lastname);
            Console.ReadLine();

        }
    }
}
