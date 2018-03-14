using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
   public  class StoreFBll
    {
        public static string InsertStore(StoreF sto)
        {
            string str = "";
            switch (StoreFDal.InsertStore(sto))
            {
                case 1:
                    str = "成功修改!";
                    break;
                default:
                    str = "修改失败";
                    break;
            }
            return str;
        }
    }
}
