namespace ChallengeApp.Models
{
    public class TaxRow
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string City { get; set; }
        public int Rate { get; set; }
        public bool IsSelected { get; set; }
    }
}