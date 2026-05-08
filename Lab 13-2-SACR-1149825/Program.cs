using System;

class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

class Program
{
    static void Main()
    {
        Vehiculo vehiculo = new Vehiculo();
        vehiculo.marca = "Kia";
        vehiculo.modelo = "Sportage";
        vehiculo.anio = 2006;
        vehiculo.color = "blanco";
        vehiculo.placa = "007-XRD";

        Console.WriteLine("--- Vehículo ---");
        Console.WriteLine("Marca: " + vehiculo.marca);
        Console.WriteLine("Modelo: " + vehiculo.modelo);
        Console.WriteLine("Año: " + vehiculo.anio);
        Console.WriteLine("Color: " + vehiculo.color);
        Console.WriteLine("Placa: " + vehiculo.placa);
    }
} //tdos tienen "Asigne valores a sus atributos" asi que voy a suponer que solo era mostrar
// :s