using System.ComponentModel.DataAnnotations;

namespace my_app.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
    }
}
