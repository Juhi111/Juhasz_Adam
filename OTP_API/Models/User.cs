namespace OTP_API.Models
{
    public class User
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }

        public override string ToString()
        {
            return Id + " " + UserName + " " + FullName;
        }
    }
}
