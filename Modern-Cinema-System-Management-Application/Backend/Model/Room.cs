using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Rooms")]
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string? RoomNumber { get; set; }
        public RoomType Capacity { get; set; }
        public List<Screening> Screenings { get; set; }
    }
}
