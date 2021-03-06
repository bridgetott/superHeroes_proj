﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesProj.Models
{
    public class SuperHero
    {
        //primary key
        [Key]
        public int Id { get; set; }

        [Display (Name = "Super Hero Name")]
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPrase { get; set; }

    }
}
