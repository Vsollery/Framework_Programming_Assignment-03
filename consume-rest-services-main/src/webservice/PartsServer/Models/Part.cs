namespace PartsService.Models
{
    // part provided by the REST web ervice.
    public class Part
    {
        public string PartID { get; set; }
        public string PartName { get; set; }
        public List<string> Suppliers { get; set; }
        public DateTime PartAvailableDate { get; set; }
        public string PartType { get; set; }
        public string Href => $"api/parts/{PartID}";
    }
}
