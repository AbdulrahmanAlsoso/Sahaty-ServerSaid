namespace Sahaty.Core.Entities
{
    internal class Appointment
    {
        public int NoAppointment { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public DateTime Date { get; set; }
    }

}
