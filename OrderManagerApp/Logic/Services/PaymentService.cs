using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class PaymentService() : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository = new PaymentRepository();
    }
}
