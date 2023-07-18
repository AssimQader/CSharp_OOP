
namespace EmployeeClass
{
    /// <summary>
    /// Class used to search about specific Employee(s)
    /// </summary>
    class EmployeeSearch
    {

        /// <summary>
        /// List of Employees
        /// </summary>
        List<Employee> employees;



        /// <summary>
        /// Parameterless ctor: initialize the list of employees that exists in the class.
        /// </summary>
        public EmployeeSearch()
        {
            employees = new List<Employee>();
        }



        /// <summary>
        /// Add Employee to the list
        /// </summary>
        /// <param name="emp"> an object from <see cref="Employee"/> class</param>
        public void Add(Employee emp)
        {
            employees.Add(emp);
        }



        /// <summary>
        /// Indexer to search Employee by ID and return his Name.
        /// </summary>
        /// <param name="id"> Employee's ID </param>
        /// <returns> The employee's name </returns>
        public string this[int id]
        {
            get
            {
                if (employees.Count == 0)
                    return "No Employees exist to search on!";

                foreach (Employee emp in employees)
                {
                    if (emp.ID == id)
                        return emp.Name;
                }

                return "There is no such Employee in your list..";
            }
        }



        /// <summary>
        /// Indexer to search Employee by Name and return list of all employees who have this name.
        /// </summary>
        /// <param name="name"> Employee's name</param>
        /// <returns>List of all employees who have this name</returns>
        public List<Employee> this[string name]
        {
            get
            {
                List<Employee> list = new List<Employee>();
                foreach (Employee emp in employees)
                {
                    if(emp.Name == name)
                        list.Add(emp);
                }

                return list;    
            }
        }



        /// <summary>
        /// Indexer to search by hiring date.
        /// </summary>
        /// <param name="hireDate"> Employee's hiring date </param>
        /// <returns>List of all employees who have this hire date</returns>
        public List<Employee> this[HireDate hireDate]
        {
            get
            {
                List<Employee> emps = new List<Employee>();

                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].EmpHireDate.Equals(hireDate))
                        emps.Add(employees[i]);
                }

                return emps;
            }
        }
    } 
}
