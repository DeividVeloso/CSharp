using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
    public class Order
    {
        public Order(IList<OrderItem> orderItems, )
        {
            //Toda vez que usar uma lista na classe instancia-la primeiro no construtor
            //Pois se alguém tentar add itens na lista vai dar erro de referência
            this.OrderItems = new List<OrderItem>();
        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
    }
}
