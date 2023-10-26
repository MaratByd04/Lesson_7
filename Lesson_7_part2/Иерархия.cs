using System;
using System.Collections.Generic;

namespace Lesson_7_part2
{
    class Employee
    {
            public string Name { get; set; }
            public List<Employee> Subordinates { get; set; }

            public Employee(string name)
            {
                Name = name;
                Subordinates = new List<Employee>();
            }
        public void Add(params Employee[] employees)
        {
            foreach (var employee in employees)
            {
                Subordinates.Add(employee);
            }
        }
    }
    class TaskAssignment
    {
        public static bool AssignTask(Employee supervisor, Employee employee, string task)
        {
              if (IsSupervisor(supervisor, employee))
              {
                  Console.WriteLine($"{supervisor.Name} назначает задачу '{task}' {employee.Name}.");
                  return true;
              }
              Console.WriteLine($"{supervisor.Name} не дорос(ла) ещё, чтобы {employee.Name} его слушал(a).");
              return false;
        }
            public static bool IsSupervisor(Employee supervisor, Employee employee)
            {
                if (supervisor == employee)
                    return true;

                foreach (var subordinate in supervisor.Subordinates)
                {
                    if (IsSupervisor(subordinate, employee))
                        return true;
                }
                return false;
            }        
    } 
}
