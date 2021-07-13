using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Models.SweetnessTypes.ConfectioneryTypes
{
    public abstract class SugarConfectionery : Confectionery
    {
        public Enums.Taste Taste { get; set; }
    }
}
