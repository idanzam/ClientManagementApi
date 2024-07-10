namespace ClientManagementApi.Models
{
    public class Client
    {
        public int id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
        public string? gender { get; set; }
        public string? email { get; set; }
    }
}
