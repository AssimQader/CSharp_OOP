
using System.Globalization;

namespace EmployeeClass
{

    /// <summary>
    /// Enum "Gender" restrict the data to be M for "Male", F for "Female", 
    /// Undefined in case of wrong input.
    /// </summary>
    enum Gender
    {
        M, F , Undefined
    }


    /// <summary>
    /// SecurityPrivillages Bit Flag Enum: restricts the privillages that employee may has in:
    /// <list type="bullet">
    ///     <item>Guest = 2</item>
    ///     <item>Developer = 4</item>
    ///     <item>Secretary = 6</item>
    ///     <item>DBA = 8</item>
    ///     <item>Undefined = 0</item>
    /// </list>
    /// </summary>
    [Flags]
    enum SecurityPrivillages : byte
    {
        Guest = 2, Developer = 4, Secretary = 6, DBA = 8, SecurityOfficer = 0X0F , Undefined = 0
    }


    /// <summary>
    /// Struct HireDate represents the hiring date in the form: day/month/year
    /// </summary>
    struct HireDate
    {
        public int day, month, year;
    }


    /// <summary>
    /// Class Employee represents the employee and his/her data(fields, properties, methods).
    /// </summary>
    class Employee : IComparable<Employee>
    {
        /// <summary>
        /// ID Property to set and get the ID of the Employee.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Salary Property to set and get the salary of the Employee.
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Name Property to set and get the Name of the Employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// EmpGender Property to set and get the Gender of the Employee.
        /// </summary>
        public Gender EmpGender { get; set; }

        /// <summary>
        /// EmpSP Property to set and get the Security Privillages of the Employee.
        /// </summary>
        public SecurityPrivillages EmpSP { get; set; }

        /// <summary>
        /// EmpHireDate is a variable represents the hiring date of the Employee.
        /// </summary>
        public HireDate EmpHireDate;




        /// <summary>
        /// Takes the hiring date as string, split it to be presented in a formt of HireDate datatype(day, month, year).
        /// </summary>
        /// <param name="str">Represents the hiring date in String format: "dd/mm/yyyy"</param>
        public void SetHireDate( string str)
        {
            //char[] delimiters = new char[] { '/', '-', '.', ' ' };  //the old way to create and initialize array
            char[] delimiters = { '/', '-', '.', ':', ' ' }; //delimiters the user may seperate the date with.

            string[] ArrStr = str.Split(delimiters, StringSplitOptions.None);

            try
            {
                EmpHireDate = new HireDate()
                {
                    day = int.Parse(ArrStr[0]),
                    month = int.Parse(ArrStr[1]),
                    year = int.Parse(ArrStr[2])
                };
            }
            catch
            {
                EmpHireDate.day = 0;
                EmpHireDate.month = 0;
                EmpHireDate.year = 0;
            }
        }



        /// <summary>
        /// Parametrize ctor used to initialize the fields and properies of the object
        /// that will be created from Employee class.
        /// </summary>
        /// 
        /// <param name="id">represents the id of the Employee</param>
        /// <param name="name">represents the name of the Employee</param>
        /// <param name="sal">represents the salary of the Employee</param>
        /// <param name="hd">represents the hiring date of the Employee</param>
        /// <param name="g">represents the gender of the Employee</param>
        /// <param name="sp">represents the security privillage the Employee has</param>
        public Employee(int id, string name, decimal sal, string hd, char g, int sp )
        {
            ID = id >= 0 ? id : 1001;   

            Name = name;

            Salary = sal >= 3000 ? sal : 3000M;


            //set the hiredate
            SetHireDate(hd);




            //set the gender
            switch(g)
            {
                case 'M':
                    EmpGender = Gender.M;
                    break;
                case 'F':
                    EmpGender = Gender.F;
                    break;
                default:
                    EmpGender = Gender.Undefined; 
                    break;
            }



            //set the secutity privillages
            switch (sp)
            {
                case 2:
                    EmpSP = SecurityPrivillages.Guest;
                    break;
                case 4:
                    EmpSP = SecurityPrivillages.Developer;
                    break;
                case 6:
                    EmpSP = SecurityPrivillages.Secretary;
                    break;
                case 8:
                    EmpSP = SecurityPrivillages.DBA;
                    break;
                case 15:
                    EmpSP = SecurityPrivillages.SecurityOfficer;
                    break;
                default:
                    EmpSP = SecurityPrivillages.Undefined;
                    break;
            }
        }



        /// <summary>
        /// Print the whole data of any employee.
        /// </summary>
        /// <returns>Employee's Data in string format</returns>
        public override string ToString()
        {
            return ($" {ID}  :  {Name}  :  {EmpGender}  :  {Salary.ToString("C", CultureInfo.CurrentCulture)}  :  {EmpHireDate.day}/{EmpHireDate.month}/{EmpHireDate.year}  :  {EmpSP}");
        }




        /// <summary>
        /// Override CompareTo method to use it in sorting employees based on their hire dates.
        /// </summary>
        /// 
        /// <param name="emp">emp is an object from Employee class</param>
        /// 
        /// <returns> 
        /// <para> 1 if the caller(this) is greater than the passed employee(emp). </para>
        ///<para> 0 if the caller(this) equals the passed employee(emp). </para>
        ///<para> -1 if the caller(this) is lesser than the passed employee(emp). </para>
        /// </returns>
        public int CompareTo(Employee? emp)
        {
            if(this.EmpHireDate.year == emp.EmpHireDate.year) //if years are equal: compare months
            {
                if (this.EmpHireDate.month == emp.EmpHireDate.month) //if months are equal: compare days
                    return (this.EmpHireDate.day.CompareTo(emp.EmpHireDate.day));
                /*Return the result of comparing days: if '1' then the instance(this)
                  is greater than (emp) in the day(hired after emp), but they are equals in year and month. 
                  If result = 0 then they both equals in day, month, year(bothe are hired in the same date). 
                  if result = -1 then the instance(this) is hired before (emp). */
                else
                    return (this.EmpHireDate.month.CompareTo(emp.EmpHireDate.month));
                    //If both are equals in years, but not in month, return the result of 
                    //comparing months.
            }

            //return the result of comparing years if both are not equal in it.
            return (this.EmpHireDate.year.CompareTo(emp.EmpHireDate.year));    
        }
    }
}
