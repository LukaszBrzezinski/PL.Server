using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PL.BuildingBlocks.Application
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
