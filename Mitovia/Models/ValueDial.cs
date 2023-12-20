using Azure.Core.Pipeline;

namespace Mitovia.Models
{
    public class ValueDial
    {
        public int ID { get; set; }
        public int OrgID { get; set; }

        public string Name { get; set; }
        public int? CategoryID { get; set; }

        public int? ClassID { get; set; }

        public int? SubClassID { get; set; }

        public string? Abbreviation { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsVisible { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public int? LastUpdatedByID { get; set; }

        public bool? IsVerified { get; set; }

        public int? SourceID { get; set; }

        // Navigation property
        public ICollection<Measure> Measures { get; set; }
    }
}