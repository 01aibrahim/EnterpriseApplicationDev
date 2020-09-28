using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Person
    {
        String name;
        int age;
        String email;
        String addressLineOne;
        String addressLinetwo;
        String postcode;

        public Person()
        {
        }

        //Constructor 
        public Person(string name, int age, string email, string addressLineOne, string addressLineTwo, string postcode)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.AddressLineOne = addressLineOne;
            this.AddressLineTwo = addressLineTwo;
            this.Postcode = postcode;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string AddressLineOne
        {
            get { return addressLineOne; }
            set { addressLineOne = value; }
        }
        public string AddressLineTwo
        {
            get { return addressLinetwo; }
            set { addressLinetwo = value; }
        }
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string printDetails()
        {
            return "-------------------------------------------------------------------------------\n"
                + "Your Name: " + Name + "\nYour age: " + Age + "\nYour email address is: " + Email +
                "\nYour address is:\n" + AddressLineOne + "\n"+ AddressLineTwo + "\n" + Postcode;
        }
    }
}
