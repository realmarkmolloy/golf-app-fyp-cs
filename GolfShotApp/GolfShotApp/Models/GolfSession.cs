using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfShotApp.Models
{
    public class GolfSession
    {
        public string CourseName { get; set; }
        public DateTime DatePlayed { get; set; }
        public int Score { get; set; }
    }
}
