/*Name: Somaly Ngov
 * CIT Number: CIT237518
 * Date: 01/05/2020
 * Software: Microsoft Visual Studio 2019 Community Edition 
 * Platform: Microsoft Windows 10 Professional 64-bit 
 * Purpose:This program will show you how to display your details to the screen using nested class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedClass
{
    class Person
    {

        private string name;
        private string address;
        private string city;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        //nested class
        public class Details
        {
            public int age;
            public int id;

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

        }
    }
}
