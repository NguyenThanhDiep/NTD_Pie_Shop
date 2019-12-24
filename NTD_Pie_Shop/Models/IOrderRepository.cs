using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTD_Pie_Shop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
