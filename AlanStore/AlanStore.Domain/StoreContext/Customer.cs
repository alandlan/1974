using System;

namespace AlanStore.Domain.StoreContext
{
    public abstract class Person {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }

    public class SalesMan : Person
    {

    }
    public class Customer : Person
    {       
        public void Register(){}

        public void AoRegistrar(){}
  
    }
}
