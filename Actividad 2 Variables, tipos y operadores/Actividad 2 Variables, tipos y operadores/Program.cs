
// Actividad 2A

/*

Escribe un programa que reciba datos de una persona y genera un mensaje,
usa una variable para cada dato y otra para el mensaje. Ej: nombre,
apellido, edad, sabe programar, etc.

*/

using System;
using System.Drawing;

string nombre, apellido, sabeProgramar;
int edad;

Console.Write("Introduzca su nombre: ");
nombre = Console.ReadLine();

Console.Write("Introduzca su apellido: ");
apellido = Console.ReadLine();

Console.Write("Introduzca su edad: ");
edad = int.Parse(Console.ReadLine());

Console.Write("¿Sabe programar? (sí/no): ");
sabeProgramar = Console.ReadLine();

string mensaje = "Hola su nombre es " + nombre + ", " + "se apellida " +
apellido + ", " + "tiene " + edad + " años " + "y " + sabeProgramar +
" sabe " + "programar, ¿es correcto?";

Console.WriteLine(mensaje); 


// Actividad 2B

/* 

Usando los tipos de variables más adecuados, describe los objetos
siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La
idea del ejercicio es almacenar los datos en los tipos más adecuados.

*/
 
int numPuertas = 5;
int numRuedas = 4;
string marca = "Opel";
DateTime fechaitvVigente = new DateTime(2023,05,19);

Console.WriteLine("Coche");
Console.WriteLine("Puertas: " + numPuertas);
Console.WriteLine("Ruedas: " + numRuedas);
Console.WriteLine("Marca: " + marca);
Console.WriteLine("ITV vigente hasta: " +
fechaitvVigente.ToShortDateString());

float peso = 13, largo = 4;
string material = "madera", color = "blanco";
Console.WriteLine("Mesa");
Console.WriteLine("Peso (kg): " + peso);
Console.WriteLine("Largo (m): " + largo);
Console.WriteLine("Material: " + material);
Console.WriteLine("Color: " + color);


// Actividad 2C

/*
 
Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos.
La idea del ejercicio es almacenar los datos en los tipos más adecuados.

*/

int x = 20;
char letra = 'a';

Console.WriteLine(x >= 18);
Console.WriteLine(letra == 'a');
Console.WriteLine(x >= 10 && letra == 'a');
Console.WriteLine(x >= 10 || letra == 'b' );