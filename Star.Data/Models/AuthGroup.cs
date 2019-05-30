﻿using System.Collections.Generic;

namespace Star.Data.Models
{
    public class AuthGroup
    {
        public AuthGroup()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermissions>();
            AuthUserGroups = new HashSet<AuthUserGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AuthGroupPermissions> AuthGroupPermissions { get; set; }
        public ICollection<AuthUserGroups> AuthUserGroups { get; set; }
    }
}
