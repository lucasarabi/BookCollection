using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.ObjectClasses
{
    public class Store
    {
        public int storeId { get; set; }
        public required string address { get; set; }
        public required string city { get; set; }
        public required string state { get; set; }
        public required string zipCode { get; set; }
        public required string name { get; set; }

        public Store() { }

        [SetsRequiredMembers]
        public Store(string address, string city, string state, string zipcode, string name)
        {
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipcode;
            this.name = name;
        }
    }
}
