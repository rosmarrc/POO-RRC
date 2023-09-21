using System;

class Empleado
{
    public string Nombre { get; set; }
    public int Id { get; set; }
    public double SalarioBase { get; set; }

    public Empleado(string nombre, int id, double salarioBase)
    {
        Nombre = nombre;
        Id = id;
        SalarioBase = salarioBase;
    }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}

class Gerente : Empleado
{
    public double Bono { get; set; }

    public Gerente(string nombre, int id, double salarioBase, double bono)
        : base(nombre, id, salarioBase)
    {
        Bono = bono;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bono;
    }
}

class Trabajador : Empleado
{
    public Trabajador(string nombre, int id, double salarioBase)
        : base(nombre, id, salarioBase)
    {
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado1 = new Gerente("Gerente Juan", 101, 50000, 10000);
        Empleado empleado2 = new Trabajador("Trabajador Ana", 102, 30000);

        Console.WriteLine("Detalles del Empleado 1:");
        Console.WriteLine($"Nombre: {empleado1.Nombre}");
        Console.WriteLine($"ID: {empleado1.Id}");
        Console.WriteLine($"Salario: {empleado1.CalcularSalario()}");

        Console.WriteLine("\nDetalles del Empleado 2:");
        Console.WriteLine($"Nombre: {empleado2.Nombre}");
        Console.WriteLine($"ID: {empleado2.Id}");
        Console.WriteLine($"Salario: {empleado2.CalcularSalario()}");
    }
}
