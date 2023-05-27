using Newtonsoft.Json;

namespace OTP_Feladatok
{
    public class Messages : FileReader
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string UserId { get; set; }
        public DateTime Ts { get; set; }
        public string Content { get; set; }
    }
}
