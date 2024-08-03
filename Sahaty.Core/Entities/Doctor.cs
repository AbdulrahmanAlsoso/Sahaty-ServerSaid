namespace Sahaty.Core.Entities
{
    internal class Doctor: Person
    {
        public IEnumerable<Report> Reports { get; set; }
        public IEnumerable<Appointment> AppointmentsCalender { get; set; }
        public IEnumerable<Evaluation> Evaluations { get; set; }
    }
}
