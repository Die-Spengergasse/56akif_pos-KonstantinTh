using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCollection
{
    public abstract class Person
    {

        public Person(){ }
        public Person(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract string GetArriveType();

        public string FullName
        {
            get
            {
                /*StringBuilder s = new StringBuilder();
                s.Append("");*/
                return $"Full Name: {LastName} {FirstName}";
            }
        }
    }
}
