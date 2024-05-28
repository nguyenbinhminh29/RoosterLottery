using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RL.Data.Repositories
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        public void Dispose()
        {
            GC.Collect();
        }

        public IDbConnection GetConnection(string connectionStr)
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            DbConnection? conn = factory.CreateConnection();

            try
            {
                conn.ConnectionString = connectionStr;
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conn;
        }
    }
}
