﻿using System;
using System.Collections.Generic;

namespace com.shapeandshare.therowantree.client.api.Dtos
{
    public partial class UserNotification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Delivered { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual User User { get; set; }
    }
}