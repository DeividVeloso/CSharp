using ModernWebStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
    public class Order
    {
        //Usado para blindar a lista, não deixar fazer um Add externo, somente na própria classe
        //força a usar o método ADDITEM
        private IList<OrderItem> _orderItems;

        public Order(IList<OrderItem> orderItems, int userId)
        {
            this.Date = DateTime.Now;
            //Toda vez que usar uma lista na classe instancia-la primeiro no construtor
            //Pois se alguém tentar add itens na lista vai dar erro de referência
            this.OrderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(x => AddItem(x));
            this.UserId = userId;
            this.Status = EOrderStatus.Created;
        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public IEnumerable<OrderItem> OrderItems 
        { 
            get {return _orderItems; }
            private set {_orderItems = new List<OrderItem>(value);}
        }
        public int UserId { get; private set; }
        public User User { get; private set; }

        public EOrderStatus Status { get; private set; }

        public decimal Total 
        { 
            get
            {
                decimal total = 0;
                foreach (var item in _orderItems)
                {
                    total += (item.Price * item.Quantity);
                }
                return total;
            }
        }

        public void AddItem(OrderItem item) {
        
        }
    }
}
