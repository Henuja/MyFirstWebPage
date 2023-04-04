namespace core.Entities
{
    public class Address
    {
        public int ID{get; set;}
        public int CustomerID {get; set;}
        public string AddressLine1 {get; set;}

        public string AddressLine2{get; set;}
        public string state {get; set;}
        public string country { get; set;}
        public bool IsDeleted{get; set;}

    }
}