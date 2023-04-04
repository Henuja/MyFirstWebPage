namespace core.Entities
{
    public class Customer
    {
        public int ID{get; set;}
        public string FirstName {get; set;}

        public string Lastname{get; set;}
        public int Contactnumber {get; set;}
        public string Email { get; set;}
        public bool IsDeleted{get; set;}
        public Address Address{get; set;}
        public ICollection<order> Porders{get; set;}


        

        
    
    }      
}