namespace ApplicationForm.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int BasicDetailsId { get; set; }
        public BasicDetails BasicDetails { get; set; }
    }
}
