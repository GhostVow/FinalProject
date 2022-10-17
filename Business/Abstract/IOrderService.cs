using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        bool Add(Order order);
        bool Delete(Order order);
        bool Update(Order order);
    }
}
