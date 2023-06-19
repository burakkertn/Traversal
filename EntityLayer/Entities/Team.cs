using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Team
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Des { get; set; }

        public string? Image { get; set; }
        public string Des2 { get; set; }
        public string GuideListImage { get; set; }

        public string? InstagramUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public bool Status { get; set; }
        public List<Des> Dess { get; set; }
    }
}
