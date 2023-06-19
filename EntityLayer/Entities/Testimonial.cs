using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Testimonial
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
