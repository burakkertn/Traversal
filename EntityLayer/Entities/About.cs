using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class About
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Des { get; set; }

        public string Image { get; set; }
        public string Des2 { get; set; }

        public bool Status { get; set; }
    }
}
