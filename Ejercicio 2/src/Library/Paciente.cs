using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        private string Nombre;
        private string Apellido;
        private string CI;
        private int Edad;
        private int Cel;
        public Paciente(string nombre, string apellido, string ci, int edad, int cel)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.CI = ci;
            this.Edad = edad;
            this.Cel = cel;
        }
        public string GetNombre()
        {
            string str = (this.Nombre + this.Apellido);
            return str;
        }
        public string GetApellido()
        {
            return this.Apellido;
        }
        public string GetCI()
        {
            return this.CI;
        }
        public int GetEdad()
        {
            return this.Edad;
        }
        public int GetCel()
        {
            return this.Cel;
        }
    }
}
