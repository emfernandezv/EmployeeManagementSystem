using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MonthCalendar;

namespace EMS
{

    // List of available areas


    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Gender;
        public string Address;
       
        public string Status;
        public string CreatedBy;
        public DateTime CreatedDate;
        public string ModifiedBy;
        public DateTime ModifiedDate;

        public Employee (int NewID, string NewFN, string NewLN, DateTime NewDOB, string NewGender, string NewAddress, string NewStatus, string action, string NewCB, DateTime NewCD)
        {
            SetID(NewID);
            SetFirstName(NewFN);
            SetLastName(NewLN);
            SetDOB(NewDOB);
            SetGender(NewGender);
            SetAddress(NewAddress);
            SetStatus(NewStatus);
            //Audit Fields
            setAction(action,NewCB, NewCD);
           


            

        }

        // setters
        protected void SetID(int newID)
        {
            Id = newID;
        }
        protected void SetFirstName(string NewFN) 
        {
            FirstName = NewFN;
        }
        protected void SetLastName(string NewLN)
        {
            LastName = NewLN;
        }
        protected void SetDOB(DateTime NewDOB)
        {
            DateOfBirth = NewDOB;
        }
        protected void SetGender(string NewGender)
        {
            Gender = NewGender;
        }
        protected void SetAddress(string NewAddress)
        {
            Address = NewAddress;
        }
        protected void SetStatus(string NewStatus)
        {
            Status = NewStatus;
        }
        protected void SetCreatedBy(string NewCB)
        {
            CreatedBy = NewCB;
        }
        protected void SetCreatedDate(DateTime NewCD)
        {
            CreatedDate = NewCD;
        }
        protected void SetModifiedBy(string NewMB)
        {
            ModifiedBy = NewMB;
        }
        protected void SetModifiedDate(DateTime NewMD)
        {
            CreatedDate = NewMD;
        }
        protected void setAction(string action,string NewCB, DateTime NewCD)
        {
            if (action == "NEW")
            {
                SetCreatedBy(NewCB);
                SetCreatedDate(NewCD);
            }
            else
            {
                SetModifiedBy(NewCB);
                SetModifiedDate(NewCD);
            }
        }
        // getters
        internal int GetID()
        {
            return Id;
        }
        internal string GetFirstName()
        {
            return FirstName;
        }
        internal string GetLastName()
        {
            return LastName;
        }
        internal string GetFullName()
        {
            return GetLastName() + ", " +GetFirstName();
        }
        internal DateTime GetDOB()
        {
            return DateOfBirth;
        }
        internal string GetGender(string type)
        {
            if (type == "D") { 
                if (Gender == "M")
                {
                    return "Male";
                }else if (Gender == "F")
                {
                    return "Female";
                }
                else
                {
                    return "Other";
                }
            }
            else
            {
                return Gender;
            }
        }
        internal Int32 GetAge()
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (DateOfBirth.Year * 100 + DateOfBirth.Month) * 100 + DateOfBirth.Day;

            return (a - b) / 10000;
        }
        internal string GetAddress()
        {
            return Address;
        }
        internal string GetStatus(string type)
        {
            if (type == "D")
            {
                if (Status == "A")
                {
                    return "Active";
                }
                else
                {
                    return "Inactive";
                }
            }
            else
            {
                return Status;
            }

        }
        internal string GetCreatedBy()
        {
            return CreatedBy;
        }
        internal DateTime GetCreatedDate()
        {
            return CreatedDate;
        }
        internal string GetModifiedBy()
        {
            return ModifiedBy;
        }
        internal DateTime GetModifiedDate()
        {
            return ModifiedDate;
        }


    
    }








}
