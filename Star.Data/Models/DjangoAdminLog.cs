﻿using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
    public partial class DjangoAdminLog
    {
        public int Id { get; set; }
        public DateTime ActionTime { get; set; }
        public string ObjectId { get; set; }
        public string ObjectRepr { get; set; }
        public short ActionFlag { get; set; }
        public string ChangeMessage { get; set; }
        public int? ContentTypeId { get; set; }
        public int UserId { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual AuthUser User { get; set; }
    }
}
