﻿using System;

namespace QuickSnacks.Data.NHibernate.Entities
{
    internal class Entity
    {
        public DateTime Created { get; set; }
        public object CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public object ModifiedBy { get; set; }
    }
}