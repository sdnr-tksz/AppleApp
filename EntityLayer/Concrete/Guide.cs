using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key] public int GuideId { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Image { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? XUrl { get; set; }

    }
}
