using System;

class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}

class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.nombre = "Ana Gómez";
        persona.edad = 30;
        persona.altura = 1.65;
        persona.estudiante = false;

        Console.WriteLine("--- Persona ---");
        Console.WriteLine("Nombre: " + persona.nombre);
        Console.WriteLine("Edad: " + persona.edad);
        Console.WriteLine("Altura: " + persona.altura);
        Console.WriteLine("Estudiante: " + persona.estudiante);
    }
} //los ejercicios tienen bastante similitud con los de la clase
//ahora si le entendi facil :D
//a no ser que hubiera tenido que el usuario decida los atributos
//pero en las instrucciones decia "Asigne valores a cada uno de sus atributos." gulp