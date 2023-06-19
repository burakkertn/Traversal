using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Contact
    {
        public int ID { get; set; }

        public string Des { get; set; }

        public string Phone { get; set; }
        public string Mail { get; set; }

        public string Adress { get; set; }
        public string MapLoc { get; set; }
        public bool Status { get; set; }
       

    }
}
