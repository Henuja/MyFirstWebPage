using core.Entities;
using Infrastructure.Data;

namespace API.GraphQL
{
    public class Query
    {
        [UseFiltering]
        public IQueryable<Customer> GetCustomers([Service] OMAcontext  context)
        {
            context.Database.EnsureCreated();
            return context.Customers;

        }
        [UseFiltering]
        public IQueryable<order> GetOrders([Service] OMAcontext  context)
        {
            context.Database.EnsureCreated();
            return context.Orders;

        }
        [UseFiltering]
        public IQueryable<Address> GetAddresses([Service] OMAcontext  context)
        {
            context.Database.EnsureCreated();
            return context.Addresses;


        }

    }
}