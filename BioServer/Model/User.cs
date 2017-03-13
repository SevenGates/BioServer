using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer.Model
{
    public partial class User
    {
        public User()
        {

        }

        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string password { get; set; }
    }
}
