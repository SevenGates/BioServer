using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer.Model
{
    public partial class Room
    {
        public Room()
        {

        }

        public int id { get; set; }

        public int nrOfSeats { get; set; }

        public int seatsPerRow { get; set; }

        [StringLength(200)]
        public string name { get; set; }
    }
}
