﻿namespace Mitovia.Models
{
    public class MeasureView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedDateString { get; set; }

        // Additional properties for the lookup
        public int? ValueDialID { get; set; }
        public string? ValueDialName { get; set; }

    }
}
