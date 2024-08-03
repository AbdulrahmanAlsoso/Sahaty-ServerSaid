namespace Sahaty.Core.Entities
{
    internal class Evaluation
    {
        public int Stars { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
    }
}
