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
        public void ImprecionesArra2( int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
              
                Console.WriteLine($"La Pociiocion es {c}");
            }
        }
        public int[] Buscar(string Elemento,string[] array_1 )
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
            return array_2;
        }

    }
}
