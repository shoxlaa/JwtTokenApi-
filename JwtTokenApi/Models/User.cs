namespace JwtTokenApi.Models
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; }= string.Empty;
   
    }

    public class UserDto
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
