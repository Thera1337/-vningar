namespace Info_tavla.Models
{
    public class Transport
    {
        public int StatusCode { get; set; }
        public object Message { get; set; }
        public int ExecutionTime { get; set; }
        public Responsedata[] ResponseData { get; set; }
    }

    public class Responsedata
    {
        public string Name { get; set; }
        public string SiteId { get; set; }
        public string Type { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public object Products { get; set; }
    }
}