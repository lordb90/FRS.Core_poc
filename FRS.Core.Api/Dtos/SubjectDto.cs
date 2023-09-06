namespace FRS.Core.Api.Dtos
{
    public class SubjectDto
    {
        public string Client { get; set; }
        public string AcctManager { get; set; }
        public string Requestor { get; set; }
        public string Reference { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Aka { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
        public int Id { get; internal set; }
        public DateTime RecDate { get; internal set; }
        public string Ssno { get; internal set; }
    }
}
