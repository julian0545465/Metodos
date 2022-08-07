using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodoss
{
    internal class Exercises
    {
       

            // 1.- Crear métodos que permita realizar los tipos de cambio de moneda a pesos.


            static void PesosADolares(int monto)
            {
                double conversion = Convert.ToDouble(monto) / 4336;
                Console.WriteLine("Total: " + conversion);
            }

            static void PesosAPesosMex(int monto)
            {
                double conversion = Convert.ToDouble(monto) / 212.26;
                Console.WriteLine("Total: " + conversion);
            }

            static void PesosAEuros(int monto)
            {
                double conversion = Convert.ToDouble(monto) / 4417;
                Console.WriteLine("Total: " + conversion);
            }

            static void PesosAPesoArgentino(int monto)
            {
                double conversion = Convert.ToDouble(monto) / 32.64;
                Console.WriteLine("Total: " + conversion);
            }

            static void PesosAYen(int monto)
            {
                double conversion = Convert.ToDouble(monto) / 32.13;
                Console.WriteLine("Total: " + conversion);
            }

            static void Main(string[] args)
            {



                Console.WriteLine("Ejericio de Metodos");
                Console.WriteLine("");

                Console.WriteLine("1. Pesos Colombianos a Dolar ");
                Console.WriteLine("2. Pesos Colombianos a Pesos mexicanos");
                Console.WriteLine("3. Pesos Colombianos a Euros");
                Console.WriteLine("4. Pesos Colombianos a Pesos Argentinos");
                Console.WriteLine("5. Pesos Colombianos a Yen Japones");
                Console.WriteLine("");

                Console.WriteLine("Ingrese su elección");

                int eleccion = 0;
                eleccion = int.Parse(Console.ReadLine());

                Console.WriteLine("Escrbia el monto");

                int monto = 0;
                monto = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (eleccion)
                {
                    case 1:
                        {
                            PesosADolares(monto);
                        }
                        break;
                    case 2:
                        {
                            PesosAPesosMex(monto);
                        }
                        break;
                    case 3:
                        {
                            PesosAEuros(monto);
                        }
                        break;
                    case 4:
                        {
                            PesosAPesoArgentino(monto);
                        }
                        break;
                    case 5:
                        {
                            PesosAYen(monto);
                        }
                        break;
                    default:
                        Console.WriteLine("Elección incorrecta");
                        break;
                }






                // 2.- Crear un método que permita calcular el área de un rectángulo.

                //static void Área(int calcular)
                //{
                //    double[] largo = new double[1];
                //    double[] ancho = new double[1];

                //    for (int i = 0; i < largo.Length || i < ancho.Length; i++)
                //    {

                //        Console.WriteLine("Ingrese el valor del largo del rectangulo");
                //        largo[i] = double.Parse(Console.ReadLine());
                //        Console.WriteLine("");

                //        Console.WriteLine("Ingrese el valor del ancho del rectangulo");
                //        ancho[i] = double.Parse(Console.ReadLine());
                //        double Total = (largo[i] * ancho[i]);
                //        Console.WriteLine("");

                //        Console.WriteLine("El area del rectangulo es: " + Total);
                //        Console.WriteLine("");

                //    }
                //}
                //static void Main(string[]args) {

                //    Área(0);








                //  3.- Crea un método que identifique la edad ingresada , si ingresa el valor 0 muestre un
                //  mensaje de ERROR, seguido distinguir la edad ingresada ,si es menor de 18 , indicar que
                //  es menor de edad, si ingresa mayor a 18 y menor a 60, indicar que es una persona mayor
                //  de edad, y por último si es mayor de 60 , indicar que es una persona adulto mayor.


                //static void MiPrimerMetododeLaEdad(int edad)
                //{
                //  if (edad == 0)
                //      Console.WriteLine("ERROR");
                //  else if (edad < 18)
                //      Console.WriteLine("Eres menor de edad");
                //  else if (edad >= 18 && edad < 60)
                //      Console.WriteLine("Eres mayor de edad");
                //  else if (edad >= 60)
                //      Console.WriteLine("Eres un adulto mayor");
                //}

                //static void Main(string[] args)
                //{

                //  Console.WriteLine("Ingrese su edad");
                //  int edad = 0;
                //  edad = int.Parse(Console.ReadLine());
                //  Console.WriteLine("");
                //  MiPrimerMetododeLaEdad(edad);








                //  4.- Crear un método «multiplicar», que reciba como parámetro un número entero, y
                // escriba la tabla de multiplicar de ese número(por ejemplo, para el 7 deberá llegar desde
                // «7 x 1 = 7» hasta «7 x 12 = 84» .

                //static void multiplicar(double L)
                //{
                //  Console.WriteLine("Ingrese un numero deseado");
                //  L = double.Parse(Console.ReadLine());
                //  Console.WriteLine("");
                //  Console.WriteLine("La tabla es: ");
                //  Console.WriteLine("");

                //  for (int D = 1; D <= 12; D++)
                //  {
                //      double totalTabla = D * L;
                //      Console.WriteLine(D + " x " + D + " = " + totalTabla);
                //      Console.WriteLine("");
                //  }
                //}
                //static void Main(string[] args)
                //{
                //  multiplicar(0);
            }
    }
}
