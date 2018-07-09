﻿using System.Threading.Tasks;

namespace Volo.Abp.Auditing
{
    public interface IAuditingStore
    {
        Task SaveAsync(AuditInfo auditInfo);
    }
}