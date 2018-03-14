using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Dal
{
   public  class StoreFDal
    {
       /// <summary>
       /// 存放商品，添加商品数量
       /// </summary>
       /// <param name="sto"></param>
       /// <returns></returns>
        public static int InsertStore(StoreF sto)
        {
            string str = "insert into StotreF values(@NewDate,@Repertory.@TypeID.@Guardian)";
            SqlParameter[] p = { new SqlParameter("@NewDate", sto.NewDate), new SqlParameter("@Repertory",sto.Repertory),
            new SqlParameter("@TypeID",sto.TypeID),new SqlParameter("@Guardian",sto.Guardian)};
            return DbHelp.ExecuteNonQuary(str, p);
        }
    }
}
