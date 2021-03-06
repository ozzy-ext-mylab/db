﻿using System.Data.Common;
using LinqToDB.SqlQuery;

namespace MyLab.Db
{
    /// <summary>
    /// Throw when connection string not found in configuration
    /// </summary>
    public class ConnectionStringNotFoundException : SqlException
    {
        public string ConnectionStringName { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="ConnectionStringNotFoundException"/>
        /// </summary>
        public ConnectionStringNotFoundException(string connectionStringName)
            :base($"Connection string not found: '{connectionStringName}'")
        {
            ConnectionStringName = connectionStringName;
        }
    }
}