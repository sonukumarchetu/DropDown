using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDown.Models
{
    public class State
    {
        public int id { get; set; }
        public string name { get; set; }
        public Country Country { get; set; }
    }
}
