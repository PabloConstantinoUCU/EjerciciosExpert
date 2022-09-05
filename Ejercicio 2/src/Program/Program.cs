using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Pablo", "Constantino", "54802569", 18, 098563543);
            Doctor doctor1 = new Doctor("Diego", "Maradona", "12345678", "Cirujano", 45);

            AppointmentService appointment1 = new AppointmentService(doctor1, DateTime.Now, "Española", paciente1);
            Console.WriteLine(appointment1.PrintAppointment());
        }
    }
}
