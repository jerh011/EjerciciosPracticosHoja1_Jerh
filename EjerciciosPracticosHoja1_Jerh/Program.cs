using EjerciciosPracticosHoja1_Jerh;

int[] a = new int[5];
int[] b = new int[a.Length];
int[] c = new int[a.Length];
Ejercicios ejercicios = new Ejercicios();
Random random = new Random();

for (int i = 0; i < a.Length; i++)
{ 
    a[i] = random.Next(100);

    b[i] = random.Next(100);
}

c = ejercicios.Sumas(a,b);
ejercicios.ImprecionesArray(a,b,c);
/*
Console.WriteLine("===============================================");
string[] array_1 = { "Hola", "como","estan","Fasil" };
int[] array_2 = new int[array_1.Length];
for (int i = 0;i < array_1.Length;i++)
    Console.WriteLine(array_1[i]);
Console.WriteLine("Busque el El elemento");
string Elemento=Console.ReadLine();

array_2=ejercicios.Buscar(Elemento, array_1);
ejercicios.ImprecionesArra2(array_2);
*/
Console.WriteLine("===============================================");
int[,] Alumnos = new int[10,3];

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 3; j++)
    {
        // Generar un número aleatorio entre 0 y 100 y asignarlo a la posición (i, j)
        Alumnos[i, j] = random.Next(10); // 101 se utiliza para incluir el 100
    }
}

Console.WriteLine("  Alumnos  |Algebra    |analisis   |");
    Console.Write("-----------+-----------+-----------+");
Console.WriteLine(" ");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 3; j++)
    {
        // Generar un número aleatorio entre 0 y 100 y asignarlo a la posición (i, j)
        Console.Write("  {0,-9}|",Alumnos[i, j]);  // 101 se utiliza para incluir el 100
        
    }
    Console.WriteLine(" ");
    Console.WriteLine("-----------+-----------+-----------+");
}
