using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        public int  Id { get; set; }

        public string Name { get; set; } 

        public string Publisher { get; set; }

        public string Cost { get; set; }
    }
}
