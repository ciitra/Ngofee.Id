using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Iinterfaces
{
    public interface IOrder
    {
        int CreateOrder(Order order);
        void UpdateStatus(int orderId, string status);
        List<AdminOrder> GetAllOrdersForAdmin();
        List<OrderHistory> GetHistoryByUser(int userId);
        void InsertOrderItem(OrderItem item);
    }

}
