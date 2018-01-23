using System;
using System.Collections.Generic;
using System.Text;

namespace Detetive.Domain.Entities
{
    public class Suspeito : Entity<int>
    {
        public string Nome { get; set; }
    }
}
