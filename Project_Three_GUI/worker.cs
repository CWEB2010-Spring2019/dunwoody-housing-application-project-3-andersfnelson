﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI
{
    class worker : student
    {

        //Default constructor
        
        
            public worker(int residentFloor, int monthlyRent, int idNumber, string firstName, string lastName, int roomNumber)
            {
                this.residentFloor = residentFloor;
                this.monthlyRent = monthlyRent;
                this.idNumber = idNumber;
                this.firstName = firstName;
                this.lastName = lastName;
                this.roomNumber = roomNumber;
            }
        
    }

   
    
}
