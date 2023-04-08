using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleAreaAndCircumference
{
    //Nombre del estudiante: Francisco Cortes
    //Grupo: 268
    //4: Calculo de area y cirferencia (perimetro) de un circulo
    //Código Fuente: autoría propia
    class circle
    {
        // variables privadas con propiedades del circulo
        private double radius;

        // propiedades accesible de acceso publico
        public double Radius
        {
            get
            {
                return radius; // retorna radio 
            }
            set
            {
                radius = value; // guarda radio
            }
        }

        //method para calcular area
        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //method para cacular perimetro (cirferencia)
        public double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
    }
    class Program
    {
        static public double getRadiusFromUser()
        {
            double radius = 0.0;
            while (true)
            {
                Console.Write("Ingrese radio del circulo: ");
                string radiusStr = Console.ReadLine();

                // revise si el radio esta en blanco o nulo
                if (string.IsNullOrWhiteSpace(radiusStr))
                {
                    //si es asi, indique mensaje de error
                    Console.WriteLine("Error: el radio no puede estar en blanco");
                    //regrese al inicio del loop
                    continue;
                }
                // revise si el numero de empleados puede ser un numero entero
                bool canBeDouble = double.TryParse(radiusStr, out radius);
                if (canBeDouble == false)
                {
                    //si es asi, indique mensaje de error
                    Console.WriteLine("Error: El dato ingresado no es valido");
                    //regrese al inicio del loop
                    continue;
                }
                //revise si el capita es negativo o cero
                if (radius <= 0)
                {
                    //si es asi, indique mensaje de error
                    Console.WriteLine("Error: El dato ingresado no puede ser negativo o cero");
                    //regrese al inicio del loop
                    continue;
                }

                // si no hay problemas con la captura salga del loop
                break;
            }

            return radius;
        }
        static void Main(string[] args)
        {
            //creamos un objeto de clase circulo
            circle aCircle = new circle();

            //pida al usuario que ingrese un radio de un circulo
            Console.WriteLine("Este programa calcula el area y el perimetro de un circulo dado un radio\n");
            aCircle.Radius = getRadiusFromUser();
            
            //calcule y muestre area
            Console.WriteLine("El Area del circulo con radio {0:N2} es : {1:N2}", aCircle.Radius, aCircle.Area());
            
            //calcule y muestrea perimetro
            Console.WriteLine("El Perimetro del circulo con radio {0:N2} es : {1:N2}", aCircle.Radius, aCircle.Perimeter());

            Console.WriteLine("Presione enter para finalizar...");
            Console.ReadLine();
        }
    }
}
