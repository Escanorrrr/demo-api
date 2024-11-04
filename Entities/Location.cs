using System.ComponentModel.DataAnnotations;

namespace my_app.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public  string enlem { get; set; }
        public  string boylam { get; set; }
        
    }
}
