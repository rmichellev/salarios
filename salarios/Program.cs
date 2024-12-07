using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto = 0;
            double impuesto = 0;
            double salarioNeto = 0;
            char resp = 's';

            do
            {
                // pedir el salario al usuario 
                Console.WriteLine("Ingrese su salario bruto: ");
                salarioBruto = Convert.ToDouble(Console.ReadLine());

                // realizar operaciones 
                impuesto = salarioBruto * 0.1075;
                salarioNeto = salarioBruto - impuesto;

                // mostrar desglose 
                Console.WriteLine($"Salario Bruto: {salarioBruto} ");
                Console.WriteLine($"Impuesto (10.75%): {impuesto} ");
                Console.WriteLine($"Salario Neto: {salarioNeto} ");

                // desea repetir el proceso

                Console.WriteLine("¿Desea realizar otra operacion? (s/n): ");
                resp = Console.ReadLine()[0];



            } while (resp == 's');

            // Finaliza el programa
            Console.WriteLine("Gracias por su calculo ");

            // para que no se cierre el programa 
            Console.ReadLine();

        }
    }
}
