
namespace FicheRecette.Services
{
    using System;
    using System.Collections.Generic;
    using FicheRecette.EF;
    

    public class CustomersService : ICustomersService
    {
        public void Add(string name, string phone, string email, string prenom)
        {
            using (ProjectManagementContext context = new ProjectManagementContext())
            {
                IRepository<Customer> repository = new Repository<Customer>(context);
                Customer Customer = new Customer
                {
                    Name = name
                };
                Customer.Contact.Email = email;
                Customer.Contact.Phone = phone;
                Customer.Prenom = prenom;
                repository.Insert(Customer);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (ProjectManagementContext context = new ProjectManagementContext())
            {
                IRepository<Customer> repository = new Repository<Customer>(context);
                repository.Delete(id);
            }
        }

        public IEnumerable<Project> GetCustomerProjects(int id)
        {
            using (ProjectManagementContext context = new ProjectManagementContext())
            {
                context.AsReadOnly();

                IRepository<Project> repository = new Repository<Project>(context);
                return repository.All(p => p.Customer.Id == id);
            }
        }

        public IEnumerable<Customer> Search(string name)
        {
            using (ProjectManagementContext context = new ProjectManagementContext())
            {
                context.AsReadOnly();

                IRepository<Customer> repository = new Repository<Customer>(context);
                return string.IsNullOrEmpty(name)
                    ? repository.All()
                    : repository.All(p => p.Name.Contains(name));
            }
        }

        public void Update(Customer Customer)
        {
            if (Customer == null)
            {
                throw new ArgumentNullException(nameof(Customer));
            }

            using (ProjectManagementContext context = new ProjectManagementContext())
            {
                IRepository<Customer> repository = new Repository<Customer>(context);
                repository.Update(Customer);
            }
        }
    }
}