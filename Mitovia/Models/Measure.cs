namespace Mitovia.Models
{
    public class Measure
    {
        // Properties corresponding to the Measure table columns
        public int ID { get; set; }
        public int OrgID { get; set; }

        public int? ValueDialID { get; set; }

        public int? EntityID { get; set; }

        
        public string Name { get; set; }

        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        /*
        public string? Abbreviation { get; set; }

      

        public int? UnitOfMeasureID { get; set; }

        public string? DisplayUnitOfMeasure { get; set; }

        public bool? KeyIndicator { get; set; }

        public bool? AllowDirectEntry { get; set; }

        public int? FrequencyID { get; set; }

        public int? AllowedMaxValue { get; set; }

        public int? AllowedMinValue { get; set; }

        public int? ContributionTypeID { get; set; }
        public int? MeasureStageID { get; set; }

        public int? TrendDirectionID { get; set; }

        public int? UpperThreshold { get; set; }

        public int? LowerThreshold { get; set; }

        public string? Formula { get; set; }

        public string? Comments { get; set; }

        public string? InformationSource { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsVisible { get; set; }

        

        public int? LastUpdatedByID { get; set; }

        public bool? IsVerified { get; set; }

        public int? SourceID { get; set; }

        public string? Question { get; set; }

        public string? HelpTip { get; set; }
        // Navigation properties
        public ICollection<MeasureScale> MeasureScales { get; set; }
        */
    }
}