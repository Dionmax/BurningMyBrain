using System;
using Aula115_Enum.Entities.Enums;

namespace Aula115_Enum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id +
                ", " +
                Moment +
                ", " +
                Status;
        }
    }
}
