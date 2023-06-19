using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Contect { get; set; }

        public bool State { get; set; }
    
      
        public int DesId { get; set; }

        public Des Des { get; set; }

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
