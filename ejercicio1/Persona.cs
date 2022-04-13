using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1

{
    internal class Persona
    {
        private string nombre;
        private int sueldo;
        private string sexo;
        private double peso;
        private double altura;
        private string email;
        public Persona(string nombre, int sueldo, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            CrearEmail();
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetEmail()
        {
            return email;
        }

        public int GetSueldo()
        {
            return sueldo;
        }
        public string GetSexo()
        {
            return sexo;
        }
        public double GetPeso()
        {
            return peso;
        }
        public double GetAltura()
        {
            return altura;
        }
        private void CrearEmail()
        {
            this.email = nombre + "@superempresa.com";
        }

    }
}


