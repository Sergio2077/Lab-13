using System;

class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}

class Program
{
    static void Main()
    {
        // Primer producto
        Producto producto1 = new Producto();
        producto1.codigo = "P001";
        producto1.nombre = "Laptop";
        producto1.precio = 750.50;
        producto1.stock = 5;
        producto1.disponible = true;

        // Segundo producto
        Producto producto2 = new Producto();
        producto2.codigo = "P002";
        producto2.nombre = "Mouse";
        producto2.precio = 15.99;
        producto2.stock = 0;
        producto2.disponible = false;

        Console.WriteLine("--- Producto 1 ---");
        Console.WriteLine("Código: " + producto1.codigo);
        Console.WriteLine("Nombre: " + producto1.nombre);
        Console.WriteLine("Precio: " + producto1.precio);
        Console.WriteLine("Stock: " + producto1.stock);
        Console.WriteLine("Disponible: " + producto1.disponible);

        Console.WriteLine("\n--- Producto 2 ---");
        Console.WriteLine("Código: " + producto2.codigo);
        Console.WriteLine("Nombre: " + producto2.nombre);
        Console.WriteLine("Precio: " + producto2.precio);
        Console.WriteLine("Stock: " + producto2.stock);
        Console.WriteLine("Disponible: " + producto2.disponible);
    }
} // se refiere a que le asignevalores como usuario o como reador del codigo?
//esa era la cuestion
