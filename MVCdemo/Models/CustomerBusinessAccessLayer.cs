namespace MVCdemo.Models
{
    public class CustomerBusinessAccessLayer
    {
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Some Customer";
            c.Address = "SomeAddress";
            c.Age = 55;
            return c;
        }
    }
}