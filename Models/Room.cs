using System.ComponentModel.DataAnnotations;

namespace HotelMicroservicio.Models
{
    public class Room
    {
        [Key]
        public int room_id { get; set; }
        public int room_number { get; set; }
        public string room_type { get; set; }
        public string status { get; set; }
    }
}
