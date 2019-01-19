﻿using System;
using System.Collections.Generic;

namespace com.shapeandshare.therowantree.client.api.Dtos
{
    public partial class PerkType
    {
        public PerkType()
        {
            Perk = new HashSet<Perk>();
        }

        public int PerkId { get; set; }
        public string PerkName { get; set; }
        public string PerkDescription { get; set; }
        public string PerkNotify { get; set; }

        public virtual ICollection<Perk> Perk { get; set; }
    }
}