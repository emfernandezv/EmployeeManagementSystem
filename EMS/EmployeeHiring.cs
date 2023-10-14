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
        public string Area;
        public DateTime HiringDate;
        public float Salary;
        public List<EmployeeHiring> EmployeeList = new List<EmployeeHiring>();

        public EmployeeHiring(int NewID, string NewFN, string NewLN, DateTime NewDOB, string NewGender, string NewAddress, string NewStatus,string NewCB, DateTime NewCD, string NewMB, DateTime NewMD, string NewArea, DateTime NHD, float NewSalary) : base (NewID, NewFN, NewLN, NewDOB, NewGender, NewAddress, NewStatus, NewCB, NewCD, NewMB, NewMD)
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
            setAudit(NewCB, NewCD, NewMB, NewMD);
            //Hiring Fields
            SetArea(NewArea);
            SetHiringDate(NHD);
            SetSalary(NewSalary);
        }
        //setters
        private void SetArea(string NewArea)
        {
            Area = NewArea;
        }
        private void SetHiringDate(DateTime NHD)
        {
            HiringDate = NHD;
        }
        private void SetSalary(float sal)
        {
            Salary = sal;
        }
        //getters
        public string GetArea()
        {
                return Area;
        }
        public DateTime GetHiringDate()
        {
            return HiringDate;
        }
        public float GetSalary()
        {
            return Salary;
        }
        
    }
}
