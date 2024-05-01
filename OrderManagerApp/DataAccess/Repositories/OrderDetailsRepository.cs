using DataAccess.Data;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderDetailsRepository() : IOrderDetailsRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();
    }
}
