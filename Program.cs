// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/


using System;
using System.Numerics;





    
    string category;
    
    
        Console.Write("Insert your name: ");
        string name = Console.ReadLine();

        Console.Write("Insert your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Insert your city: ");
        string city = Console.ReadLine();
    
   
    

if(age < 0 ) 
{
    Console.WriteLine("Inserte una edad correcta");
}

if(age <12) 
{category = "Niño"; }
else if( age <= 17)
{ category = "Joven"; }
else
{ category = "Adulto"; }

Console.WriteLine("-----");

Console.WriteLine(@$"Hola {name} desde {city}
    Tienes {age} años y perteneces a la categoria: {category}
    ");

if ( age <= 17 )
{
    Console.WriteLine("Acceso denegado");
}
else
{
    Console.WriteLine("Acceso Permitido!!");
}