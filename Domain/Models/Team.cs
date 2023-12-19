using System.ComponentModel.DataAnnotations;

namespace Bets.Domain.Models
{
    public class Team
    {
        public int Id { get; set; }
        
        public required string TeamName { get; set; }
      
        public required string Coach { get; set; }
        
        public required DateTime TeamStart { get; set; }

        public DateTime? TeamEnd { get; set; }
    }
}
