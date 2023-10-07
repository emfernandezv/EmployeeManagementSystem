using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{

    public class EmployeeHiring : Employee
    {
        public int Area;
        public DateTime HiringDate;
        public float salary;
        public List<EmployeeHiring> EmployeeList = new List<EmployeeHiring>();

        public EmployeeHiring(int NewID, string NewFN, string NewLN, DateTime NewDOB, string NewGender, string NewAddress, string NewStatus, string action, string NewCB, DateTime NewCD, int NewArea, DateTime NHD, float salary) : base (NewID, NewFN, NewLN, NewDOB, NewGender, NewAddress, NewStatus, action, NewCB, NewCD)
        {
            //Employee Fields
            SetID(NewID);
            SetFirstName(NewFN);
            SetLastName(NewLN);
            SetDOB(NewDOB);
            SetGender(NewGender);
            SetAddress(NewAddress);
            SetStatus(NewStatus);
            //Audit Fields
            setAction(action, NewCB, NewCD);
            //Hiring Fields
            SetArea(NewArea);
            SetHiringDate(NHD);
            SetSalary(salary);
        }
        //setters
        private void SetArea(int NewArea)
        {
            Area = NewArea;
        }
        private void SetHiringDate(DateTime NHD)
        {
            HiringDate = NHD;
        }
        private void SetSalary(float sal)
        {
            salary = sal;
        }
        //getters
        public string GetArea(string type)
        {
            if (type == "D")
            {
                switch (Area)
                {
                    case 1:
                        return "Development";
                    case 2:
                        return "Q.A.";
                    case 3:
                        return "DevOps";
                    default:
                        return "Marketing";
                }
            }
            else
            {
                return Area.ToString();
            }
        }
        public DateTime GetHiringDate()
        {
            return HiringDate;
        }
        public float GetSalary()
        {
            return salary;
        }
        
    }
}
