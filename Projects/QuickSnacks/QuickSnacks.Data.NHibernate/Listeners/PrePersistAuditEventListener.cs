﻿using NHibernate.Event;

namespace QuickSnacks.Data.NHibernate.Listeners
{
    class PrePersistAuditEventListener : IPreInsertEventListener, IPreUpdateEventListener
    {
        public bool OnPreInsert(PreInsertEvent @event)
        {
            throw new System.NotImplementedException();
        }

        public bool OnPreUpdate(PreUpdateEvent @event)
        {
            throw new System.NotImplementedException();
        }
    }
}