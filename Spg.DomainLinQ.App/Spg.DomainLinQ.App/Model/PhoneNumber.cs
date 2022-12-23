using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// Number
    /// (2P)
    /// </summary>
    public class PhoneNumber
    {
        // TODO: Implementation

        public int Number { get; set; }
        public PhoneNumber(int number)
        {
            Number = number;
        }
    }
}
