namespace Sahaty.Core.Entities
{
    internal class Report
    {
        public string ReportId { get; set; }
        public string DoctorId { get; set; }
        public string PatientId { get; set; }
        public DateTime ReportDate { get; set; }
        public Description ReportDescription { get; set; }
        public IEnumerable<Medicine> Medicines { get; set; }
    }
}
