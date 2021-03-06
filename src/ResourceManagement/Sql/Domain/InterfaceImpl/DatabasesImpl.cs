// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Sql.Fluent.SqlDatabase.Definition;
    using Microsoft.Azure.Management.Sql.Fluent.SqlDatabases.SqlDatabaseCreatable;
    using Microsoft.Azure.Management.Sql.Fluent.SqlServer.Databases;
    using System.Collections.Generic;

    internal partial class DatabasesImpl 
    {
        /// <summary>
        /// Creates a new database in SQL Server.
        /// </summary>
        /// <param name="databaseName">Name of the database to be created.</param>
        /// <return>Returns a stage to specify arguments of the database.</return>
        SqlDatabase.Definition.IBlank SqlServer.Databases.IDatabases.Define(string databaseName)
        {
            return this.Define(databaseName) as SqlDatabase.Definition.IBlank;
        }

        /// <summary>
        /// Delete specified database in the server.
        /// </summary>
        /// <param name="databaseName">Name of the database to delete.</param>
        void SqlServer.Databases.IDatabases.Delete(string databaseName)
        {
 
            this.Delete(databaseName);
        }

        /// <summary>
        /// Delete specified database in the server.
        /// </summary>
        /// <param name="databaseName">Name of the database to delete.</param>
        /// <return>Observable for the delete operation.</return>
        async Task SqlServer.Databases.IDatabases.DeleteAsync(string databaseName, CancellationToken cancellationToken)
        {
 
            await this.DeleteAsync(databaseName, cancellationToken);
        }

        /// <summary>
        /// Returns all the databases for the server.
        /// </summary>
        /// <return>List of databases for the server.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase> SqlServer.Databases.IDatabases.List()
        {
            return this.List() as System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase>;
        }

        /// <summary>
        /// Gets a particular sql database.
        /// </summary>
        /// <param name="databaseName">Name of the sql database to get.</param>
        /// <return>Returns the database with in the SQL Server.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase SqlServer.Databases.IDatabases.Get(string databaseName)
        {
            return this.Get(databaseName) as Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase;
        }
    }
}