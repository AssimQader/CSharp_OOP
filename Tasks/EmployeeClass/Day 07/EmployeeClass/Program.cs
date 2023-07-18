namespace EmployeeClass
{
    internal class Program
    {
        static void Main()
        {
            #region Employee Class

            Employee[] EmpArr = new Employee[3] { new(1,"Asem", 15000, "1/2/2022", 'M', 4),
                                                  new(2,"Ali", 1000, "4.11.2019", 'M', 8),
                                                  new(3,"Bassant", 30000, "15-7-2020", 'F', 15)
                                                };

            Console.WriteLine(" Before Sorting: \n");
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
                Console.WriteLine("\n");
            }

            Console.WriteLine("----------------------------------------------------------\n");

            Array.Sort(EmpArr);

            Console.WriteLine(" After Sorting: \n");
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
                Console.WriteLine("\n");
            }

            Console.WriteLine("----------------------------------------------------------\n");

            #endregion

            /* ___________________________________________________________________________________________________*/

            #region EmployeeSearch Class

            Employee E1 = new(1, "Ahmed", 9000, "7/5/2022", 'M', 2);
            Employee E2 = new(2, "Ali", 7000, "13/11/2015", 'M', 4);
            Employee E3 = new(3, "Menna", 3000, "22/2/2017", 'F', 2);
            Employee E4 = new(4, "Safwat", 5000, "2/9/2011", 'M', 6);
            Employee E5 = new(5, "Esraa", 14000, "24/2/2000", 'F', 4);
            Employee E6 = new(6, "Ahmed", 20000, "1/1/2023", 'M', 6);
            Employee E7 = new(7, "Youmna", 30000, "19/4/2018", 'F', 15);


            EmployeeSearch ES = new EmployeeSearch();
            ES.Add(E1);
            ES.Add(E2);
            ES.Add(E3);
            ES.Add(E4);
            ES.Add(E5);
            ES.Add(E6);
            ES.Add(E7);



            //test the Indexer that search by ID
            string EmpName = ES[5];
            Console.WriteLine("test the Indexer that search by ID:");
            Console.WriteLine(EmpName);

            Console.WriteLine("----------------------------------------------------------\n");


            //test Indexer taht search by Name
            Console.WriteLine("test the Indexer that search by Name:");
            foreach (Employee emp in ES["Ahmed"])
            {
                Console.WriteLine($"ID:{emp.ID}  |  Salary:{emp.Salary}");
            }

            Console.WriteLine("----------------------------------------------------------\n");


            //test Indexer taht search by Hiring Date
            HireDate hireDate = new HireDate { day = 2, month = 9, year = 2011 };
            Console.WriteLine("test the Indexer that search by Hiring Date:");
            foreach (Employee emp in ES[hireDate])
            {
                Console.WriteLine($"ID:{emp.ID}  |  Salary:{emp.Name}");
            }

            #endregion

        }
    }
}