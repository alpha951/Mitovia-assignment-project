using System.Runtime.CompilerServices;

namespace Mitovia.Models
{
    public class MeasureScale
    {
        public int ID { get; set; }
        public int OrgID { get; set; }

        public int? MeasureID { get; set; }

        public int? Sequence { get; set; }

        public string Name { get; set; }
        public string? DisplayName { get; set; }

        public string? Abbreviation { get; set; }   

        public string? Description { get; set; }

        public decimal? ScaleValue { get; set; }

        public string? Color { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        /*
        public string? InformationSource { get; set; }

        public bool IsActive { get; set; }

        public bool IsVisible { get; set; }

       
        
        public int LastUpdatedByID { get; set; }

        public bool IsVerified { get; set; }

        public int SourceID { get; set; }   

        public int LowScaleValue { get; set; }

        public int LowRange { get; set; }

        public int HighRange { get; set; }  

        public string? HelpTip { get; set; }

        public bool IsExecuted { get; set; }
        // Foreign key
        public Measure Measures { get; set; }
        */
    }
}
