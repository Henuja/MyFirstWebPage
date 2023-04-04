using core.Enums;

namespace core.Entities
{
    public class order
    {
        public int ID{get; set;}
        public int CustomerID {get; set;}

        public string Description {get; set;}
        public DateTime OrderedDate {get; set;}
        public decimal Totalamount { get; set;}
        public decimal Payamount {get; set;}
        public int Isdelivered{get; set;}
        public status status{get; set;}
        public Customer Customer{get; set;}

    }
}