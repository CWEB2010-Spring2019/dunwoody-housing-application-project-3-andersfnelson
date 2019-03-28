using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI
{
    class worker : student
    {

        //Default constructor
        double hourlyWage = 14.00;
        double baseRent = 1245;
        double hoursWorked;

        public worker(int residentFloor, double hoursWorked, int idNumber, string firstName, string lastName, int roomNumber)
        {
            hourlyWage = 14.00;
            double monthlyPay = hoursWorked * hourlyWage;
            this.residentFloor = residentFloor;
            this.hoursWorked = hoursWorked;
            this.idNumber = idNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.roomNumber = roomNumber;
            this.monthlyRent = Convert.ToInt32(baseRent - (0.5 * monthlyPay));
        }
            public int calculateRent(double hourlyWage, double hoursWorked, double baseRent)
            {
                double monthlyPay = hoursWorked * hourlyWage;
                monthlyRent = Convert.ToInt32(baseRent - (0.5 * monthlyPay));
                return monthlyRent;
            }
        
        
        
    }

   
    
}
