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
                    FirstName = "Moshe",
                    LastName = "Perez",
                    ManagerId = 4,
                    Position = EmployeePosition.CTO
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Dan",
                    LastName = "Peer",
                    ManagerId = 1,
                    Position = EmployeePosition.Backend
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Ori",
                    LastName = "Kadori",
                    ManagerId = 1,
                    Position = EmployeePosition.FrontEnd
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "David",
                    LastName = "Ben David",
                    ManagerId = null,
                    Position = EmployeePosition.CEO
                },
            };

            Reports = new List<Report>()
            {

            };

            Tasks = new List<Task>()
            {
                new Task()
                {
                    Id = 1,
                    DueDate = new DateTime(),
                    EmployeeId = 1,
                    Text = "First task",
                }
            };


        }

        public static List<Employee> GetAllEmployees()
            => Employees;
        public static Employee GetEmployeeById(int empId)
            => Employees.Where(x => x.Id == empId).FirstOrDefault();

        public static List<Employee> GetEmpByManager(int? managerId)
          => Employees.Where(x => x.ManagerId == managerId).ToList();

        public static Employee GetManagerByEmp(int empId)
        => Employees.Where(x => x.Id == (Employees.Where(e => e.Id == empId)?.FirstOrDefault()?.ManagerId)).FirstOrDefault();

        public static int CreateTask(Task model)
        {
            model.Id = Tasks.Max(x => x.Id) + 1;

            Tasks.Add(model);

            return model.Id;
        }

        public static int CreateReport(Report model)
        {
            if (Reports.Count() == 0)
                model.Id = 1;
            else
                model.Id = Reports.Max(x => x.Id) + 1;

            Reports.Add(model);

            return model.Id;
        }

        public static List<Task> GetTasksByEmpId(int empId)
            => Tasks.Where(t => t.EmployeeId == empId).ToList();


        public static List<Employee> Employees { get; set; }
        public static List<Report> Reports { get; set; }
        public static List<Task> Tasks { get; set; }
    }
}
