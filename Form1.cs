/*Name: Somaly Ngov
 * CIT Number: CIT237518
 * Date: 01/05/2020
 * Software: Microsoft Visual Studio 2019 Community Edition 
 * Platform: Microsoft Windows 10 Professional 64-bit 
 * Purpose:This program will show you how to display your details to the screen using nested class
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nestedClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
             
            Person personObject = new Person();
            personObject.Name = txtName.Text;
            personObject.Address = txtAddress.Text;
            personObject.City = txtCity.Text;

            Person.Details details = new Person.Details();
            details.Age = Convert.ToInt32(txtAge.Text);
            details.Id = Convert.ToInt32(txtId.Text);
            

            lstResult.Items.Add(personObject.Name);
            lstResult.Items.Add(personObject.Address);
            lstResult.Items.Add(personObject.City);
            lstResult.Items.Add(details.Age);
            lstResult.Items.Add(details.Id);
        }

        
    }
}
