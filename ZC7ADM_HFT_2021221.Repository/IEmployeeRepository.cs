using System.Linq;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Repository
{
    interface IEmployeeRepository
    {
        void Create(Employee e);
        void Delete(int id);
        Employee Read(int id);
        IQueryable<Employee> ReadAll();
        void Update(Employee e);
    }
}