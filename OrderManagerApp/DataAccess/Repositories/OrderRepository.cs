using DataAccess.Data;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderRepository() : IOrderRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();

        public List<int> GetMissingOrderIdsInPayments()
        {
            List<int> missingOrderIds = new List<int>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string ordersSql = "SELECT Id FROM Orders";
                    DataTable ordersTable = new DataTable();

                    using (var ordersCommand = new SqlCommand(ordersSql, connection))
                    {
                        SqlDataAdapter ordersAdapter = new SqlDataAdapter(ordersCommand);
                        ordersAdapter.Fill(ordersTable);
                    }

                    string paymentsSql = "SELECT OrderId FROM Payments";
                    DataTable paymentsTable = new DataTable();
                    using (var paymentsCommand = new SqlCommand(paymentsSql, connection))
                    {
                        SqlDataAdapter paymentsAdapter = new SqlDataAdapter(paymentsCommand);
                        paymentsAdapter.Fill(paymentsTable);
                    }

                    var allOrderIds = ordersTable.AsEnumerable().Select(r => r.Field<int>("Id"));
                    var paymentsOrderIds = paymentsTable.AsEnumerable().Select(r => r.Field<int>("OrderId"));
                    missingOrderIds = allOrderIds.Except(paymentsOrderIds).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get missing OrderIds in Payments. " + ex.Message);
            }

            return missingOrderIds;
        }
    }
}
