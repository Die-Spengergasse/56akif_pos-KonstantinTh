using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCollection
{
    public class Teacher : Person
    {
        public override string GetArriveType()
        {
            return "Reist meist mit dem Auto oder mit dem Motorrad an.";
        }


        public new string FullName
        {
            get 
            { 
                return $"Full Name: {FirstName} - {LastName} (Teacher)"; 
            }
        }

    }
}
