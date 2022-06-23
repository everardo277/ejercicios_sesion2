// Ejercicios sesion 2

//Ejercicio 1

Console.WriteLine("Ingresa tu nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu apellido");
string apellido = Console.ReadLine();

Console.WriteLine("Ingresa tu edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ciudad de nacimiento");
string ciudad = Console.ReadLine();

Console.WriteLine("¿Sabe programar ? contesta en forma booleana");
bool programar = Convert.ToBoolean(Console.ReadLine());

Console.Write("Hola " + nombre + " " + apellido);
Console.Write(" Tienes " + edad + " años de edad ");
Console.Write(" sabes programacion respuesta:  " + programar);
Console.Write(" y naciste  en " + ciudad);
Console.WriteLine("");


// Ejercicio 2

string coche = " El coche ";
int puertas = 5;
int ruedas = 4;
string marca = "volvo";
bool ITV = true;

string mesa = "La mesa ";
float peso = 35.7f;
float largo = 2.4f;
string material = "caoba";
string color = "Cafe";



Console.WriteLine("=== Ejercicio 2 ===");
Console.WriteLine( coche + "tiene " + puertas+ " puertas  cuenta con sus " + ruedas + " ruedas nuevas, es de la marca " + marca + " y cuenta con ITV: " + ITV + " es decir vigente" );
Console.WriteLine(mesa + " tiene un peso de " + peso + " kilos y un largo de " + largo + " metros, su material es de "+ material + " y su color es " + color);
Console.WriteLine("");

// Ejercicio 3


float numero1  = 25.5f;
int numero2 = 18;
char letra = 'a';
Console.WriteLine("=== Ejercicio 3 ===");
Console.WriteLine(numero1 >= numero2 && numero2 == 18);
Console.WriteLine(letra == 'a' ||  letra == numero1);











