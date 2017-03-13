using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer.Model
{
    public partial class Customer
    {
        public Customer()
        {
            
        }

        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string address { get; set; }
        
        public int telephone { get; set; }

        [StringLength(200)]
        public string creditCard { get; set; }
    }
}
