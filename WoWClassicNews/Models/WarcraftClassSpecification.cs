﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WoWClassicNews.Models
{
    public class WarcraftClassSpecification
    {
        public int Id { get; set; }
        [Required]
        public int WarcraftClassId { get; set; }
        public string SpecificationName { get; set; }
        public int SpecificationIndex { get; set; }
        public string SpecificationIcon { get; set; }
        public List<Talent> Talents { get; set; }
    }
}
