using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public bool Add(Order order)
        {
            _orderDal.Add(order);
            return true;
        }

        public bool Delete(Order order)
        {
            _orderDal.Delete(order);
            return true;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderDal.Get(o => o.OrderId == id);
        }

        public bool Update(Order order)
        {
            _orderDal.Update(order);
            return true;
        }
    }
}
