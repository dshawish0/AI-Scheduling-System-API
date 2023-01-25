using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Just.Jadwel.Core.Domain
{
    public interface IDbContext
    {
        public DbConnection dbConnection { get; }
    }
}
