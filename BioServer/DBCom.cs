using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioServer
{
    class DBCom
    {

        public DBCom()
        {
            
        }

        public object Request(string[] args)
        {
            List<string> returnList = new List<string>();
            using (var db = new BioContext())
            {
                switch (args[0])
                {
                    default:
                        var query = from m in db.Movies
                                    orderby m.title
                                    select m;

                        foreach(var item in query)
                        {
                            returnList.Add(item.ToString());
                        }
                        return returnList;
                }
            }
        }

    }
}
