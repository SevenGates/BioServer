using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer.Model
{
    public partial class Show
    {
        public Show()
        {

        }

        public int id { get; set; }

        public Room room_id { get; set; }

        public int date { get; set; }

        public int time { get; set; }

        public Movie movie_id { get; set; }
    }
}
