﻿using System;
using System.Collections.Generic;

namespace com.shapeandshare.therowantree.client.api.Models
{
    public partial class FireType
    {
        public FireType()
        {
            UserGameState = new HashSet<UserGameState>();
        }

        public int FireId { get; set; }
        public string FireName { get; set; }
        public string FireDescription { get; set; }

        public ICollection<UserGameState> UserGameState { get; set; }
    }
}
