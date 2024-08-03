namespace Sahaty.Core.Entities
{
    internal class Medicine
    {
        public string MedicinName { get; set; }
        public DateTime TakingStartDate { get; set; }
        public DateTime StopTakingDate { get; set; }
        public Description MedicinDescription { get; set; }
    }
}
