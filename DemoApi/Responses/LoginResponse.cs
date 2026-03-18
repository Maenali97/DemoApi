using System.Text.Json.Serialization;

namespace DemoApi
{
    public class LoginResponse
    {
        public bool IsSuccessful { get; set; } = false;
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public string ErrorCode { get; set; }
        public EmployeeDto? Employee { get; set; }
        //public string? Token { get; set; }
        //[JsonIgnore]
        //public string? RefreshToken { get; set; }
        //public DateTime RefreshTokenExpiration { get; set; }
    }
}
