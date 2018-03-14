using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
  public   class DetailsBll
    {
        public static string InsertDrtails(Details de)
        {
            return DetailsDal.InsertDrtails(de);
        }
        public static string UpdateDratils(Details de)
        {
            return DetailsDal.UpdateDratils(de);
        }
    }
}
