namespace ApplicationForm.Models
{
    public class EducationDetails
    {
        public int Id { get; set; }
        public string BoardOrUniversity { get; set; }
        public int Year { get; set; }
        public double CGPA { get; set; }
        public int BasicDetailsId { get; set; }
        public BasicDetails BasicDetails { get; set; }
    }
}
