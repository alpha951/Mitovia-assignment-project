namespace Mitovia.Models
{
    public class UpdateMeasure
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? DisplayName { get; set; }
        public string? Description { get; set; }

        public int? ValueDialID { get; set; }
        public string? ValueDialName { get; set; }

    }
}
