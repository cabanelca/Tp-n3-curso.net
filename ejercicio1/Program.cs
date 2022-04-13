using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string nombre;
            int sueldo;
            string sexo;
            double peso;
            double altura;



            Console.WriteLine("INGRESE EL NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE EL SUELDO");
            sueldo =int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU GENERO");
            sexo = Console.ReadLine();
            Console.WriteLine("INGRESE SU PESO");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU ALTURA");
            altura = double.Parse(Console.ReadLine());

            Persona persona = new Persona(nombre,sueldo,sexo,peso,altura);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + persona.GetNombre());
            Console.WriteLine("Email: " + persona.GetEmail());
            Console.WriteLine("Sueldo: " + persona.GetSueldo());
            Console.WriteLine("Sexo: " + persona.GetSexo());
            Console.WriteLine("Peso: " + persona.GetPeso());
            Console.WriteLine("Altura: " + persona.GetAltura());
            Console.ReadLine();

        }
    }
}
    

