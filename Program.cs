// See https://aka.ms/new-console-template for more information
using RauraAriel01062023_1;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
Persona Ariel = new Persona("Ariel", "Ecuadorian", 82.1, 1.75, "30/05/2002");

Console.WriteLine(""+Ariel.mostrarDatos());
Console.WriteLine("" + Ariel.calcularEdad());
Console.WriteLine("Su imc es: " + Ariel.imc());


public interface IPerson    
{
    String calcularEdad();
    Double imc();
}


public class Persona : IPerson
{

    public String? Nombre { get; set; }
    //public int Edad { get; set; }
    public String? Nacionalidad { get; set; }
    public Double Peso { get; set; }
    public Double Altura { get; set; }
    public String? fechaNacimiento { get; set; }


    public Persona(string? nombre, string? nacionalidad, Double Peso, Double Altura, string? fechaNacimiento)
    {
        this.Nombre = nombre;
        this.Nacionalidad = nacionalidad;
        this.Peso = Peso;
        this.Altura = Altura;
        this.fechaNacimiento = fechaNacimiento;

    }

    public String mostrarDatos()
    {   
        return Nombre + " " + Nacionalidad;       
    }

    public String calcularEdad() 
    {
        String edad;
        DateTime fechaNacDate = DateTime.ParseExact("30/05/2002", "dd/MM/yyyy", null);
        DateTime fechaActual = DateTime.Now;

        TimeSpan diferencia = fechaActual - fechaNacDate;
        double dias = diferencia.TotalDays;
        double años = Math.Floor(dias / 365);


        edad = "Su edad es: "+años;
        return edad;
    }

    public Double imc() 
    {
        return Peso / (Altura*Altura);
    }

}


