
namespace RtspViewer.Configuration
{
    public class StreamConfiguration
    {
        public string IPAddress { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool StatusIP { get; set; }
        public ConnectionType Protocol { get; set; }

        
    }
}
