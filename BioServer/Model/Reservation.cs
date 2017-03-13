using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer.Model
{
    public partial class Reservation
    {
        public Reservation()
        {
            
        }


        public int id { get; set; }

        public User user_id { get; set; }

        public Customer customer_id { get; set; }
        
        public int seat { get; set; }

        public Show show_id { get; set; }
    }
}
