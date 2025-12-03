using Ngofee.Id.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Controllers
{
    public abstract class BaseController
    {
        protected readonly DbContext _dbContext;

        protected BaseController()
        {
            _dbContext = new DbContext();
        }

        protected NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_dbContext.connStr);
        }
    }
}
