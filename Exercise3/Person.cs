using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double height;
        private double weight;

        public string FirstName 
        { 
            get { return firstName; } 
            set { 
                if(value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Name has to be longer than 2 letters and shorter than 10");
                }
                else
                {
                    firstName = value;
                } 
            } 
        }
        public string LastName 
        { 
            get { return lastName; } 
            set 
            {
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Last name has to be longer than 3 letters and shorter than 15");
                }
                else
                {
                    lastName = value; 
                }
                
            } 
        }
        public int Age 
        { 
            get { return age; } 
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age must be a number higher than 0");
                }
                else
                {
                    age = value; 
                }   
            } 
        }
        public double Height 
        { 
            get { return height; } 
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Height must be a number higher than 0");
                }
                else
                {
                    height = value; 
                }
            } 
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Weight must be a number higher than 0");
                }
                else
                {
                    weight = value;
                }
            }
        }

        public Person(string firstName, string lastName, int age, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            Weight = weight;
            
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string DisplayPerson()
        {
            return $"First name: {FirstName}\nLast name: {LastName}\nAge: {Age} years\nHeight: {Height} cm\nWeight: {Weight} kg";
        }
    }
}
