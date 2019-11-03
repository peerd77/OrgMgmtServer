using OrgMgmtServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrgMgmtServer.Imdb
{
    public static class Imdb
    {
        static Imdb()
        {
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Refael",
                    LastName = "Ganesh",
                    ManagerID = 4,
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Dan",
                    LastName = "Peer",
                    ManagerID = 1
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Ori",
                    LastName = "Kadori",
                    ManagerID = 1,
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "David",
                    LastName = "Ben David",
                    ManagerID = null,
                },
            };

            Reports = new List<Report>()
            {

            };

            Tasks = new List<Task>()
            {

            };


        }

        public static List<Employee> GetAllEmployees()
            => Employees;

        public static List<Employee> GetEmpByManager(int? managerID)
          => Employees.Where(x => x.ManagerID == managerID).ToList();

        public static Employee GetManagerByEmp(int empID)
        => Employees.Where(x => x.Id == (Employees.Where(e => e.Id == empID)?.FirstOrDefault()?.ManagerID)).FirstOrDefault();

        public static int CreateTask(Task model)
        {
            model.Id = Tasks.Max(x => x.Id) + 1;

            Tasks.Add(model);

            return model.Id;
        }

        public static List<Task> GetTasksByEmpId(int empId)
            => Tasks.Where(t => t.EmployeeID == empId).ToList();


        public static List<Employee> Employees { get; set; }
        public static List<Report> Reports { get; set; }
        public static List<Task> Tasks { get; set; }
    }
}
