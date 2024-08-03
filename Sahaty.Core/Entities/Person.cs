using System.Globalization;

namespace Sahaty.Core.Entities
{
    internal class Person
    {
        public Guid Id { get; set; }
        public string PersonalId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Location Location { get; set; }
    }
}
