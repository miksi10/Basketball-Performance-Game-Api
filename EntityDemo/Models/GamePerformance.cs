using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo.Models
{
    public class GamePerformance
    {
        public int GamePerformanceID { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; } //strani kljuc na tabelu Players
        public int Points { get; set; }
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public decimal PerformanceIndex { get; set; }

        // jedan red GamePerformance tabele ima jednog igraca
        public Players players { get; set; } = null!;


    }
}
