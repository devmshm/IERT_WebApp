using System.ComponentModel.DataAnnotations;

namespace ClsData.Models
{
    public class Basic_details
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string DOB { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string course { get; set; }
        public string course_code { get; set; }
    }
    public class Personal_details
    {
        [Key]
        public int Id { get; set; }
        public string appno { get; set; }

        public string father_name { get; set; }

        public string Mother_name { get; set; }

        public string domicile { get; set; }
        public string category { get; set; }

        public string caste { get; set; }

        public string income { get; set; }
    }

    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string add1 { get; set; }
        public string add2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string pincode { get; set; }
        public string postcode { get; set; }
    }

    public class qualification
    {
        [Key]
        public int Id { get; set; }
        public string appno { get; set; }

        public string state { get; set; }
        public string passed_year { get; set; }
        public string max_marks { get; set; }
        public string obt_marks { get; set; }
        public string college { get; set; }

    }
    public class candidate_doc
    {
        [Key]
        public int Id { get; set; }
        public string photo { get; set; }
        public string sign { get; set; }
        public string thumb { get; set; }
    }
}
