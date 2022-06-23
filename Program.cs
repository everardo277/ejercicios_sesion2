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
Console.WriteLine("=== Ejercicio 2 ===");
Console.WriteLine( coche + "tiene " + puertas+ " puertas  cuenta con sus " + ruedas + " rueda nuevas, es de la marca " + marca + " y cuenta con ITV: " + ITV );



