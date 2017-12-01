﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.DataSeeder
{
    public class DruidClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Balance", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Feral Combat", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2 }
            };
        }
    }
}
