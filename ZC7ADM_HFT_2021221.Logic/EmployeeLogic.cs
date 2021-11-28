using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Models;
using ZC7ADM_HFT_2021221.Repository;

namespace ZC7ADM_HFT_2021221.Logic
{
    public class EmployeeLogic : IEmployeeLogic
    {
        IEmployeeRepository empRepo;
        public EmployeeLogic(IEmployeeRepository employeeRepository)
        {
            this.empRepo = employeeRepository;
        }

        public void Create(Employee e)
        {
            if (e.Name== null)
            {
                throw new ArgumentNullException("Name property must be filled!");
            }
            empRepo.Create(e);
        }

        public Employee Read(int id)
        {
            return empRepo.Read(id);
        }

        public IEnumerable<Employee> ReadAll()
        {
            return empRepo.ReadAll();
        }
        public void Delete(int id)
        {
            empRepo.Delete(id);
        }

        public void Update(Employee e)
        {
            empRepo.Update(e);
        }

        //non-crud mothods

        public IEnumerable<Employee> HadMoreThanOneGuest()
        {
            return from x in empRepo.ReadAll()
                   where x.Guests.Count > 1
                   select x;
        }

        public IEnumerable<Employee> ThreeStarsOrHigherRatedRestaurantWorkers() 
        {
            return from x in empRepo.ReadAll()
                   where x.Restaurant.Rating > 3
                   select x;       
        }
    }
}
