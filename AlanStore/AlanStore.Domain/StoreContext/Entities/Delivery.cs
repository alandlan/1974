using System;
using AlanStore.Domain.StoreContext.Enums;

namespace AlanStore.Domain.StoreContext.Entities
{
    public class Delivery 
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            EstimatedDeliveryDate = estimatedDeliveryDate;
            CreateDate = DateTime.Now;
            Status = EDeliveryStatus.Waiting;
        }
        public DateTime CreateDate{ get; private set;}
        public DateTime EstimatedDeliveryDate{ get; private set;}
        public EDeliveryStatus Status { get; private set; }

    }    
}
