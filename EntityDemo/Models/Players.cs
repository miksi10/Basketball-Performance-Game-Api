using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo.Models
{
    public class Players    
    {
        //[Key] //not required because property name end with "id"
        public int PlayerId { get; set; }

        [Required] //because property is nullable, and i dont wont FirstName to be null
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string? Team { get; set; }

        public string? Nationality { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public int? Ranking { get; set; }

        [Required]
        public int Age { get; set; }
        
        [MaxLength]
        public string? ProfileImage { get; set; }

        // jedan igrac ima vise utakmica
        public ICollection<GamePerformance> gamePerformances { get; set; } = null!;

        public override string? ToString()
        {
            return "Player id: " + PlayerId + "\nFirst name: " + FirstName
                + "\nLast name: " + LastName + "\nAge: " + Age + "\nTeam: " + Team?.ToString();
        }
        
    }
}
