using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos_de_unidades_de_medida
{
    public class Principal
    {
        Datos d = new Datos();
        int opc = 0;
        public void Welcome()
        {
            Console.WriteLine("Que desea convertir?");
            Console.WriteLine("1.Centimetros a metros");
            Console.WriteLine("2.Metros a pulgadas");
            Console.WriteLine("3.Litros a mililitros");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Calcularcmam();

                    break;
                case 2:
                    CalcularMetrosap();
                    break;

                case 3:
                    CalcularLitros();
                    break;




            }
        }

        public void Calcularcmam()
        {
            Console.WriteLine("Ingrese centimetros: ");
            d.Centimetros = Convert.ToDouble(Console.ReadLine());

            d.Metros = d.Centimetros / 100;
            Console.WriteLine("El resultado en metros es: "+d.Metros);
        }

        public void CalcularMetrosap()
        {
            Console.WriteLine("Ingrese metros: ");
            d.Metros = Convert.ToDouble(Console.ReadLine());

            d.Pulgadas = d.Metros*39.37;
            Console.WriteLine("El resultado en pulgadas es: " + d.Pulgadas);
        }

        public void CalcularLitros()
        {
            Console.WriteLine("Ingrese litros: ");
            d.Litros = Convert.ToDouble(Console.ReadLine());

            d.Mililitros = d.Litros * 1000;

            Console.WriteLine("El resultado en Mililitros es: "+d.Mililitros);

        }
    }
}
