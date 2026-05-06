using System;

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}

class Program
{
    static void Main()
    {
        Mascota mascota = new Mascota();
        mascota.nombre = "Ruperto";
        mascota.especie = "Perro Salchicha";
        mascota.edad = 4;
        mascota.peso = 12.3;
        mascota.vacunado = true;

        Console.WriteLine("--- Mascota ---");
        Console.WriteLine("Nombre: " + mascota.nombre);
        Console.WriteLine("Especie: " + mascota.especie);
        Console.WriteLine("Edad: " + mascota.edad);
        Console.WriteLine("Peso: " + mascota.peso);
        Console.WriteLine("Vacunado: " + mascota.vacunado);
    }
} //los comentarios eran necesarios en cada codigo?
//genuinamente que se supone que tengo que comentar que no se pueda ver facilmente