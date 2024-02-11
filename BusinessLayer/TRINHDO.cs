using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDO
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<TB_TRINHDO> getList()
        {
            return db.TB_TRINHDO.ToList();
        }
    }
}
