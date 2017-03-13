using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer.Model
{
    public partial class Movie
    {
        public Movie()
        {

        }

        public int id { get; set; }

        [StringLength(200)]
        public string title { get; set; }
        
        public int runtime { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(200)]
        public string actors { get; set; }

        [StringLength(200)]
        public string directors { get; set; }

    }
}
