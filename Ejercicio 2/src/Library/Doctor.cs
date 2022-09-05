using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string Nombre;
        private string Apellido;
        private string CI;
        private string Especialidad;
        private int Edad;
        public Doctor(string nombre, string apellido, string ci, string especialidad, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.CI = ci;
            this.Especialidad = especialidad;
            this.Edad = edad;
        }
        public string GetNombre()
        {
            return this.Nombre;
        }

        public string GetApellido()
        {
            return this.Apellido;
        }

        public string GetCI()
        {
            return this.CI;
        }

        public string GetEspecialidad()
        {
            return this.Especialidad;
        }

        public int GetEdad()
        {
            return this.Edad;
        }
    }
}