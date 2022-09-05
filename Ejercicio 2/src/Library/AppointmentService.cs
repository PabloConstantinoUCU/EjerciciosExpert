using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private Paciente Paciente;
        private Doctor Doctor;
        private DateTime Date;
        private string AppoinmentPlace;

        static int Counter = 0;
        public AppointmentService(Doctor doctor, DateTime date, string appoinmentPlace, Paciente paciente)
        {
            Boolean isValid = true;

            this.Paciente = paciente;
            this.Doctor = doctor;
            this.Date = date;
            this.AppoinmentPlace = appoinmentPlace;
            {
                
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.GetNombre()))
            {
                Console.WriteLine("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Appoinment scheduled");
            }

            SetCounter(GetCounter()+1);
        }
        public static int GetCounter()
        {
            return Counter;
        }

        public static void SetCounter(int count)
        {
            Counter = count;
        }

        public string PrintAppointment()
        {
            return $" Fecha: {this.Date} \n Nombre Paciente: {this.Paciente.GetNombre()} \n Nombre Doctor: {this.Doctor.GetNombre()} \n Lugar: {this.AppoinmentPlace}";
        }

    }
}
