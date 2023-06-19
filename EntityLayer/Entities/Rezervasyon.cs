using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Rezervasyon
    {
        public int ID { get; set; }
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public string PersonCount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public int DesId { get; set; }

        public Des Des { get; set; }
    }
}
