using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.calcule_el_salario_neto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al programa de Nómina");
            Console.WriteLine("Por favor ingrese la cantidad de horas trabajadas:");
            int horasTrabajadas = int.Parse(Console.ReadLine()); //aqui pusismos para que se introduzca la cantidad de horas trabajadas
            Console.WriteLine("Por favor ingrese el precio por hora:"); //para introducir el precio por hora y realizar el calculo
            double precioHora = double.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente

            double salarioBruto;
            double horasExtras = 0;
            if (horasTrabajadas > 176) //La instrucción if controla la bifurcación condicional
            {
                horasExtras = horasTrabajadas - 176;
                salarioBruto = (176 * precioHora) + (horasExtras * precioHora * 1.3); //si la cantidad de horas trabajadas al mes pasa de 176, se paga un 30% mas cara.
            }
            else
            {
                salarioBruto = horasTrabajadas * precioHora;
            }

            double afp = salarioBruto * 0.0287; //aqui buscamos en internet los datos de descuento de afp y seguro de salud.
            double seguroSalud = salarioBruto * 0.0304;
            double salarioNeto = salarioBruto - afp - seguroSalud;

            Console.WriteLine("Salario Bruto: $" + salarioBruto);
            Console.WriteLine("AFP (2.87%): $" + afp);
            Console.WriteLine("Seguro de Salud (3.04%): $" + seguroSalud);
            Console.WriteLine("Salario Neto: $" + salarioNeto);

            Console.ReadLine(); //para imprimir los valores en pantalla.
        }
    }
}
