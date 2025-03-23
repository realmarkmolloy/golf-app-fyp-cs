using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfShotApp.Models
{
    public class GolfRound
    {
        public int RoundId { get; set; }
        public int UserId { get; set; }
        public DateTime DatePlayed { get; set; }
        public int TotalScore { get; set; }
    }
}
