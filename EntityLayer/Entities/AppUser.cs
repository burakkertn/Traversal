using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string  Gender { get; set; }
        public List<Rezervasyon> Rezervasyons { get; set;}
        public List<Comment> Comments { get; set; }

    }
}
