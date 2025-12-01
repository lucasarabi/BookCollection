using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.ObjectClasses
{
    public class Store
    {
        public required string address {  get; set; }
        public required string city { get; set; }
        public required string state { get; set; }
        public required string zipCode { get; set; }
        public required string name { get; set; }
    }
}
