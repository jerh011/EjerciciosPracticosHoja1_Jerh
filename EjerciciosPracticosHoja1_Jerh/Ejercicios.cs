using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticosHoja1_Jerh
{
    internal class Ejercicios
    {
        Random random = new Random();
        public int[] Sumas(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] + b[i];
            }
            return c;
        }
        public void ImprecionesArray(int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}+{b[i]} = {c[i]}");
            }
        }
        public void ImprecionesArra2(int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {

                Console.WriteLine($"La Pociiocion es {c}");
            }
        }
        public void Buscar(string Elemento, string[] array_1)
        {
            int[] array_2 = new int[array_1.Length];
            int x = 0;
            for (int i = 0; i < array_1.Length; i++)
            {
                if (array_1[i] == Elemento)
                {
                    array_2[x] = i;
                    x++;
                }
            }
            Buscar(array_2, Elemento, x);
        }
        public void Buscar(int[] array_1, string Elemento, int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"El Elemento \" {Elemento}\" se encuentra en la pocicion {array_1[i]}");
            }

        }

        public void ImprimirMaterias_E3(int[] Algebra, int[] Analisis)
        {

            Console.WriteLine("  Alumnos  |Algebra    |");
            Console.Write("-----------+-----------+");
            Console.WriteLine(" ");
            for (int i = 0; i < Algebra.Length; i++)
            {
                // Generar un número aleatorio entre 0 y 100 y asignarlo a la posición (i, j)
                Console.Write("{0,-11}|{1,-11}|", Algebra[i], Analisis[i]);  // 101 se utiliza para incluir el 100
                Console.WriteLine(" ");
                Console.WriteLine("-----------+-----------+");

            }

        }

        public void ImprimirAlumnosComunes_E3(int[] JUNTOS, int X)
        {
            Console.WriteLine("Estos son los alumnos comunes");
            Console.WriteLine("-----------------------------");
            for (int j = 0; j < X; j++)
            {
                Console.WriteLine($" {JUNTOS[j]}");
                Console.WriteLine("-----------------------------");
            }
        }

        public bool NumeroRepetido(int[] arr, int numero, int endIndex)
        {
            for (int i = 0; i < endIndex; i++)
            {
                if (arr[i] == numero)
                {
                    return true;
                }
            }
            return false;
        }

        public void Impresion_E4(int[] Numeros)
        {
            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine(Numeros[i]);
            }
        }
        public void LlenarArray_E5(int tamaño_E5)
        {

            int[] array_E5 = new int[tamaño_E5];
            for (int i = 0; i < array_E5.Length; i++)
            {
                array_E5[i] = random.Next(200);

            }
            Imprimir_E5(array_E5, tamaño_E5);

        }
        public void Imprimir_E5(int[] array_E5, int tamaño_E5)
        {
            Console.WriteLine("Estos son los numeros introducidos");
            for (int i = 0; i < array_E5.Length; i++)
            {
                Console.WriteLine(array_E5[i]);

            }
            Console.WriteLine($"Este es el valor es el valor del campo del medio medio:{array_E5[array_E5.Length/2]}");
        }
        public void Imprimir_E5(int[] array_E6)
        {

            for (int i = 0; i < array_E6.Length; i++)
            {
                Console.WriteLine("+----------+-------------+------------+");
                if (array_E6[i] >= 16)
                {
                    Console.WriteLine("|{0,-10}| Excelentes  |{1,10}  |", array_E6[i],(array_E6[i]*100/20)*.10);

                }
                else if (array_E6[i] >= 11)
                {
                    Console.WriteLine("|{0,-10}| Bueno       |{1,10}  |", array_E6[i], (array_E6[i] * 100 / 20)*.10);


                }
                else if (array_E6[i] >= 6)
                {
                    Console.WriteLine("|{0,-10}| Regular     |{1,10}  |", array_E6[i], (array_E6[i] * 100 / 20) * .10);


                }else
                {
                    Console.WriteLine("|{0,-10}| Deficientes |{1,10}  |", array_E6[i], (array_E6[i] * 100 / 20) * .10);


                }


            }
            Console.WriteLine("+----------+-------------+------------+");
        }


    }
}