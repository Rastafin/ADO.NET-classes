using DataAccess.Data;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PaymentRepository() : IPaymentRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();
    }
}
