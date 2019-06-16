using LINQtoCSV;

namespace ACME.LOGIC.Entities
{
    public class Customer
    {
        [CsvColumn(Name = "first_name", FieldIndex = 1)]
        public string FirstName { get; set; }

        [CsvColumn(Name = "last_name", FieldIndex = 2)]
        public string LastName { get; set; }

        [CsvColumn(Name = "company_name", FieldIndex = 3)]
        public string CompanyName { get; set; }

        [CsvColumn(Name = "address", FieldIndex = 4)]
        public string Address { get; set; }

        [CsvColumn(Name = "city", FieldIndex = 5)]
        public string City { get; set; }

        [CsvColumn(Name = "state", FieldIndex = 6)]
        public string State { get; set; }

        [CsvColumn(Name = "post", FieldIndex = 7)]
        public string Post { get; set; }

        [CsvColumn(Name = "phone1", FieldIndex = 8)]
        public string Phone1 { get; set; }

        [CsvColumn(Name = "phone2", FieldIndex = 9)]
        public string Phone2 { get; set; }

        [CsvColumn(Name = "email", FieldIndex = 10)]
        public string Email { get; set; }

        [CsvColumn(Name = "web", FieldIndex = 11)]
        public string Web { get; set; }
    }
}
