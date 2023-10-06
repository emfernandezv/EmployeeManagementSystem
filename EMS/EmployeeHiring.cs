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

        public EmployeeHiring(int NewID, string NewFN, string NewLN, DateTime NewDOB, string NewGender, string NewAddress, string NewStatus, string NewCB, DateTime NewCD, string NewMB, DateTime NewMD, int NewArea, DateTime NHD, float salary) : base (NewID, NewFN, NewLN, NewDOB, NewGender, NewAddress, NewStatus, NewCB, NewCD, NewMB, NewMD)
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
            SetCreatedBy(NewCB);
            SetCreatedDate(NewCD);
            SetModifiedBy(NewMB);
            SetModifiedDate(NewMD);
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
