namespace Sahaty.Core.Entities
{
    internal class Patient: Person
    {
        public IEnumerable<Appointment> Books { get; set; }
        public IEnumerable<Report> Reports { get; set; }
    }
}
