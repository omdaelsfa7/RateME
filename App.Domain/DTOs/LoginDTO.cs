namespace App.Domain.DTOs
{
    public class LoginDTO
    {
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string GetUsername()
        {
            return UserName;
        }
        public string GetPassword()
        {
            return Password;
        }
    }
}
