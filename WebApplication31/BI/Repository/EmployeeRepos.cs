using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.DAl.Database;
using WebApplication31.DAl.Entity;
using WebApplication31.Models;

namespace WebApplication31.BI.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        DbContainer db = new DbContainer();
        public Employee Create(EmployeeVM emp)
        {
            Employee employee = new Employee();
            employee.Name = emp.Name;
            employee.Salary = emp.Salary;
            db.Employees.Add(employee);
            db.SaveChanges();
            var data = db.Employees.OrderBy(a=>a.Id).LastOrDefault();
            return data;
        }

        public Employee Delete(int id)
        {
            var oldData = db.Employees.Find(id);
            db.Employees.Remove(oldData);
            db.SaveChanges();
            return oldData;
        }

        public IEnumerable<EmployeeVM> Get()
        {
          var data =   db.Employees.Select(a => new EmployeeVM
            {

                Id = a.Id,
                Name = a.Name,
                Salary = a.Salary

            });
            return data;
        }

        public EmployeeVM GetById(int id)
        {

         var data =   db.Employees.Where(a=>a.Id==id).Select(a => new EmployeeVM
            {

                Id = a.Id,
                Name = a.Name,
                Salary = a.Salary

            }).FirstOrDefault();
            return data;
        }

        public Employee Update(EmployeeVM emp)
        {

            var oldData = db.Employees.Find(emp.Id);
           oldData.Name = emp.Name;
            oldData.Salary = emp.Salary;
            db.Employees.Update(oldData);
            db.SaveChanges();
            return oldData;
        }


    }

    public interface IEmployeeRepo
    {
        IEnumerable<EmployeeVM> Get();
        EmployeeVM GetById(int id);
        Employee Create(EmployeeVM emp);
        Employee Update(EmployeeVM emp);
        Employee Delete(int id);

    }
}
