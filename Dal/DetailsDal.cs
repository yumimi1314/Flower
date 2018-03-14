using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace Dal
{
    public class DetailsDal
    {
        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        public static string InsertDrtails(Details de)
        {
            string str = "insert into Details values(@DetailsID,@ID,@FlowerName," +
                "@FlowerColor,@FlowerSize,@FlowerPicUrl,@FlowerPrice,@DetailsNumber,@UserAccount,@Discount,@PayState,@PayDesc)";
            SqlParameter[] p = { new SqlParameter("@DetailsID",de.DetailsID), new SqlParameter("@ID",de.ID), new SqlParameter("@FlowerName",de.FlowerName),
            new SqlParameter("@FlowerColor",de.FlowerColor),new SqlParameter("@FlowerSize",de.FlowerSize),new SqlParameter("@FlowerPicUrl",de.FlowerPicUrl),
                new SqlParameter("@FlowerPrice",de.FlowerPrice),new SqlParameter("@DetailsNumber",de.DetailsNumber),new SqlParameter("@UserAccount",de.UserAccount),
                new SqlParameter("@Discount",de.Discount),new SqlParameter("@PayState",de.PayState),
            new SqlParameter("@PayDesc",de.PayDesc)};
            switch (DbHelp.ExecuteNonQuary(str,p))
            {
                case 1:
                    str = "加入购物车";
                    break;
                default:
                    str = "加入购物车失败";
                    break;
            }
            return str;
        }
        /// <summary>
        /// 付款
        /// </summary>
        /// <param name="de"></param>
        /// <returns></returns>
        public static string UpdateDratils(Details de)
        {
            string str = "update Details set PayState=1 where  UserAccount=@UserAccount";
            SqlParameter[] p = { new SqlParameter("@UserAccount", de.PayState), };
            switch (DbHelp.ExecuteNonQuary(str,p))
            {
                case 1:
                    str = "付款成功";
                    break;
                default:
                    str = "付款失败";
                    break;
            }
            return str;
        }
    }
}
