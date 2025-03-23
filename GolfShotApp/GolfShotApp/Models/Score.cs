using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfShotApp.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HoleNumber { get; set; }
        public int Strokes { get; set; }
    }
}
