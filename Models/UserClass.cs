namespace CinemaSIte.Models
{
    public class UserClass
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
