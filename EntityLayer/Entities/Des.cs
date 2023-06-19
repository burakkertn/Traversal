using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Des
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string DayNight { get; set; }

        public string Price { get; set; }

        public string? Image { get; set; }
        public string Desss { get; set; }

        public int Capacity { get; set; }

        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public string? Detay1 { get; set; }

        public string? Detay2 { get; set; }
        public string? Image2 { get; set; }

        public  List<Comment> Comments { get; set; }

        public List<Rezervasyon> Rezervasyons { get; set; }

        public DateTime Date { get; set; }
        [ForeignKey("Team")]
        public int? TeamID { get; set; }
        public Team Team { get; set; }

      
    }
}
