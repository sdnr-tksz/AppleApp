﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key] public int TestimonialId { get; set; }
        public string? Name { get; set; }
        public string? Comment { get; set; }
        public string? Image { get; set; }
    }
}
