using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IDbConnection GetConnection(string connectionStr);
    }
}
