using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmnetADO
{
    class Program
    {
        public class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }

        } 

        static void Main()
        {
            //creating a list of employees

            List<Employee> emplist = new List<Employee>
        {
            new Employee {EmployeeID = 1001, FirstName = "Malcon", LastName = "Daruwalla", Title ="Manager", DOB = new DateTime(1984,11,16), DOJ = new DateTime(2011, 6,8), City= "Mumbai"},
            new Employee {EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee {EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee {EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee {EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee {EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee {EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee {EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee {EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee {EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }

        };
            //1. Display a list of all the employee who have joined before 1/1/2015
            DateTime dateT = new DateTime(2015, 1, 1);

            var joinedBefore2015 = from e in emplist
                                   where e.DOJ < dateT
                                   select e;
            Console.WriteLine("EMployees joined before 1-1-2015 are: ");
            foreach(var e in joinedBefore2015)
            {
                Console.WriteLine($"{e.EmployeeID}: {e.FirstName} {e.LastName}, {e.Title},{e.DOJ},{e.City}");
                Console.ReadLine();
            }

            //2.Display a list of all the employee whose date of birth is after 1/1/1990
            DateTime daten = new DateTime(1990, 1, 1);
            var dobAfter1990 = from e in emplist
                               where e.DOJ > daten
                               select e;
            Console.WriteLine("Employees born after 1990 are: ");
            foreach(var e in dobAfter1990)
            {
                Console.WriteLine($"{e.EmployeeID}: {e.FirstName} {e.LastName}, {e.Title},{e.DOJ},{e.City}");
                Console.ReadLine();
            }

            //3.Display a list of all the employee whose designation is Consultant and Associate
            var ConAndAsso = from e in emplist
                             where e.Title == "Consultant" || e.Title == "Associate"
                             select e;
            Console.WriteLine("Employees working as Consultant or Associate: ");
            foreach(var e in ConAndAsso)
            {
                Console.WriteLine($"{e.EmployeeID}: {e.FirstName} {e.LastName}, {e.Title},{e.DOJ},{e.City}");
                Console.ReadLine();
            }

            //4.Display total number of employees
            int Totemp = emplist.Count;
            Console.WriteLine($"The total number of employees are: {Totemp}");
            Console.ReadLine();

            //5.Display total number of employees belonging to “Chennai”

            int EmpChennai = (from e in emplist
                              where e.City == "Chennai"
                              select e).Count();
            Console.WriteLine($"The total number of employees working in Chennai location: {EmpChennai}");
            Console.ReadLine();

            //6.Display highest employee id from the list
            int highestEmpID = (from e in emplist
                                select e.EmployeeID).Max();
            Console.WriteLine($"The highnest employee ID from the list is : {highestEmpID}");
            Console.ReadLine();

            //7.Display total number of employee who have joined after 1/1/2015
          
            var joinedAfter2015 = from e in emplist
                                   where e.DOJ > dateT
                                   select e;
            Console.WriteLine("Employees joined after 1-1-2015 are: ");
            foreach (var e in joinedBefore2015)
            {
                Console.WriteLine($"{e.EmployeeID}: {e.FirstName} {e.LastName}, {e.Title},{e.DOJ},{e.City}");
                Console.ReadLine();
            }

            //8.Display total number of employee whose designation is not “Associate”
            var notAssociate = from e in emplist
                             where e.Title != "Associate"
                             select e;
            Console.WriteLine("Employees whose designation isnot Associate: ");
            foreach (var e in notAssociate)
            {
                Console.WriteLine($"{e.EmployeeID}: {e.FirstName} {e.LastName}, {e.Title},{e.DOJ},{e.City}");
                Console.ReadLine();
            }

            //9. Display total number of employee based on City
            var empCity = from e in emplist
                          group e by e.City into GroupCity
                          select new
                          {
                              city = GroupCity.Key,
                              count = GroupCity.Count()
                          };
            Console.WriteLine("Total number of employees based on City:");
            foreach (var GroupCity in empCity)
            {
                Console.WriteLine($"{GroupCity.city}: {GroupCity.count}");
            }
            Console.ReadLine();

            //10.Display total number of employee based on city and title
            var groupedByCityAndTitle = from e in emplist
                                        group e by new { e.City, e.Title } into cityTitleGroup
                                        select new
                                        {
                                            City = cityTitleGroup.Key.City,
                                            Title = cityTitleGroup.Key.Title,
                                            Count = cityTitleGroup.Count()
                                        };

            Console.WriteLine("Total number of employees based on city and title:");
            foreach (var group in groupedByCityAndTitle)
            {
                Console.WriteLine($"{group.City} - {group.Title}: {group.Count}");
                Console.ReadLine();
            }

            //11. Display total number of employee who is youngest in the list
            DateTime youngestDOB = emplist.Max(e => e.DOB);

            var youngestEmp = from e in emplist
                                    where e.DOB == youngestDOB
                                    select e;

            Console.WriteLine("\nYoungest employee(s):");
            foreach (var e in youngestEmp)
            {
                Console.WriteLine($"{e.EmployeeID}: {e.FirstName} {e.LastName}, {e.Title}, {e.DOB.ToShortDateString()}, {e.City}");
                Console.ReadLine();
            }

        }
    }
}