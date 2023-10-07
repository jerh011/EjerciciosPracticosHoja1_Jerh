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

Console.WriteLine("===============================================");
string[] array_1 = { "Hola", "como","estan","Fasil","como" };
int[] array_2 = new int[array_1.Length];
for (int i = 0;i < array_1.Length;i++)
    Console.WriteLine(array_1[i]);
Console.WriteLine("Busque el El elemento");
string Elemento=Console.ReadLine();

ejercicios.Buscar(Elemento, array_1);


Console.WriteLine("===============================================");
int[] Algebra = {1111,63234,3,8,4,0};
int[] Analisis ={1111,63234,3,5,7,8};
int[] JUNTOS=new int[Algebra.Length];
int X =0;
for (int j = 0; j < Algebra.Length; j++)
{
    for (int Z = 0; Z < Analisis.Length; Z++)
    {
        if (Algebra[j] == Analisis[Z]) { 
        JUNTOS[X] = Analisis[Z];
        X++;
        }
    }
}
ejercicios.ImprimirMaterias_E3(Algebra, Analisis);
ejercicios.ImprimirAlumnosComunes_E3(JUNTOS,X);


Console.WriteLine("===============================================");


bool boleano = false;

Console.WriteLine("ingrese el tamaño del areglo");
int tamañoo=Convert.ToInt32(Console.ReadLine());
int[] Numeros = new int[tamañoo];
for (int j = 0; j < Numeros.Length; j++)
{ 
    do
    {
        Numeros[j] = random.Next(1, (tamañoo*2));
        boleano = ejercicios.NumeroRepetido(Numeros, Numeros[j], j);
    }while (boleano);
}
ejercicios.Impresion_E4(Numeros);
Console.WriteLine("===============================================");

int tamaño_E5 = 0;
do
{
    tamaño_E5 = random.Next(1, 15);
} while (tamaño_E5%2==0);
Console.WriteLine($"El tamaño del areglo es: {tamaño_E5}");

ejercicios.LlenarArray_E5(tamaño_E5);
Console.WriteLine("===============================================");

int[] Array_6=new int[random.Next(1,20)];
for (int i = 0; i < Array_6.Length; i++)
{
    Array_6[i] = random.Next(0, 21);
}
ejercicios.Imprimir_E5(Array_6);


Console.ReadKey();