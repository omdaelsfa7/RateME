namespace App.Domain.DTOs
{
    public class SignUpDTO
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string GetUsername()
        {
            return UserName;
        }
        public string GetFullName()
        {
            return FullName;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetPassword()
        {
            return Password;
        }
    }
}
