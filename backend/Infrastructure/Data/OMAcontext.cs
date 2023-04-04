using Microsoft.EntityFrameworkCore;
using core.Entities;


namespace Infrastructure.Data
{
    public class OMAcontext : DbContext

    {
        

        public DbSet<Customer> Customers {get; set;}
        public DbSet<Address> Addresses {get; set;}
        public DbSet<order> Orders {get; set;}

        public OMAcontext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Customer>().HasData(
            
            new Customer
                {
                    ID=1,
                    FirstName="Henuja",
                    Lastname="Katuwapitiya",
                    Contactnumber=0770529138,
                    IsDeleted=false,
                    Email="henujadulneth@gmail.com"
                },
                new Customer
                {
                    ID=2,
                    FirstName="Henuja",
                    Lastname="Katuwapitiya",
                    Contactnumber=0770529138,
                    IsDeleted=false,
                    Email="henujadulneth@gmail.com"
                },
                new Customer
                {
                    ID=3,
                    FirstName="Henuja",
                    Lastname="Katuwapitiya",
                    Contactnumber=0770529138,
                    IsDeleted=false,
                    Email="henujadulneth@gmail.com"
                }
            
            );
            modelBuilder.Entity<Address>().HasData(
            
            new Address
                {
                    ID=1,
                    CustomerID=1,
                    AddressLine1 ="390/7,Abimanpura,Malamulla",
                    AddressLine2="panadura",
                    state="Western",
                    country="SriLanka"
                },
                new Address
                {
                    ID=2,
                    CustomerID=2,
                    AddressLine1 ="390/7,Abimanpura,Malamulla",
                    AddressLine2="panadura",
                    state="Western",
                    country="SriLanka"
                },
                new Address
                {
                    ID=2,
                    CustomerID=2,
                    AddressLine1 ="390/7,Abimanpura,Malamulla",
                    AddressLine2="panadura",
                    state="Western",
                    country="SriLanka"
                }


            );
            modelBuilder.Entity<order>().HasData(
            
            new order
                {
                    ID=1,
                    CustomerID=1,
                    OrderedDate=new DateTime(2023,05,25),
                    status=core.Enums.status.Completed,
                    Totalamount=350,
                    Payamount=300

                    
                },
                new order
                {
                    ID=1,
                    CustomerID=3,
                    OrderedDate=new DateTime(2023,05,31),
                    status=core.Enums.status.draft,
                    Totalamount=125,
                    Payamount=150
                    
                },
                new order
                {
                    ID=1,
                    CustomerID=1,
                    OrderedDate=new DateTime(2023,05,27),
                    status=core.Enums.status.shipped,
                    Totalamount=250,
                    Payamount=225
                    
                    
                }
            
                
            );

        }
        
    


    }
}