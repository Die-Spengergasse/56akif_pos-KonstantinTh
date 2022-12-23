using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// Id
    /// LastChangeDate (?)
    /// </summary>
    /// (2P)
    public class EntityBase
    {
        // TODO: Implementation

        public int Id { get; private set; }
        public DateTime? LastChangeDate { get; set; }
    }
}