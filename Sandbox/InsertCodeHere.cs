using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Add you test of the Employee class and derived classes here
            List<Employee> allEmployees = new List<Employee>();

            Worker w1 = new Worker("James", 15000, "Maintenance");
            Worker w2 = new Worker("Irina", 17000, "Truck Driver");
            allEmployees.Add(w1);
            allEmployees.Add(w2);

            Manager m1 = new Manager("Johanna", 22000, 4000);
            Manager m2 = new Manager("James", 23000, 3000);
            m1.setHoursWorked(190);
            m2.setHoursWorked(160);
            allEmployees.Add(m1);
            allEmployees.Add(m2);

            Director d1 = new Director("Susan", 35000);
            Director d2 = new Director("Thomas", 38000);
            d1.setHoursWorked(130);
            d2.setHoursWorked(200);
            allEmployees.Add(d1);
            allEmployees.Add(d2);

            foreach (Employee e in allEmployees)
            {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }


            // The LAST line of code should be ABOVE this line
        }

    }
}
