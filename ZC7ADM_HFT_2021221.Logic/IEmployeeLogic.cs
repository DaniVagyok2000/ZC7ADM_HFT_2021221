using System.Collections.Generic;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Logic
{
    public interface IEmployeeLogic
    {
        void Create(Employee e);
        void Delete(int id);
        Employee HadMoreThanTwoGuest();
        Employee Read(int id);
        IEnumerable<Employee> ReadAll();
        void Update(Employee e);
    }
}