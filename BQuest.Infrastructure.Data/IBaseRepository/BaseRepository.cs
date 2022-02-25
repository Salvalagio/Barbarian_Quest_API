using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BQuest.Infrastructure.Data.IBaseRepository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly string _sqlConnection;

        public BaseRepository(IConfiguration configuration)
        {
            _sqlConnection = configuration.GetConnectionString("PLAYER_DB");
        }

        public X QueryFirstOrDefault<X>(string sqlCommand, object parameters)
        {
            throw new NotImplementedException();
        }
    }
}
