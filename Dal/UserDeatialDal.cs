using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Dal
{
    //public class UserDeatialDal
    //{
    //    /// <summary>
    //    /// 订单
    //    /// </summary>
    //    /// <param name="us"></param>
    //    /// <param name="ship"></param>
    //    /// <returns></returns>
    //    public static int InsertDetails(UserDeatial us, List<Shipments> ship)
    //    {
    //        SqlTransaction transaction = DbHelp.conn.BeginTransaction();
    //        try
    //        {
    //            #region 添加订单
    //            string strSql = "insert into [UserDeatial]" +
    //            "values(@UserAccount,@UserDeatialID,@DeaDat,@UserName,@ShiDat,@TakePhone,@TakeAddress,@DetailsPrice)";
    //            SqlParameter[] p = {new SqlParameter("@UserAccount",us.UserAccount),
    //                new SqlParameter("@UserDeatialID",us.UserDeatialID),
    //                                new SqlParameter("@DeaDat",us.DeaDat),
    //                                new SqlParameter("@UserName",us.UserName),
    //                                new SqlParameter("@ShiDat",us.ShiDat),
    //                                new SqlParameter("@TakePhone",us.TakePhone),
    //                                new SqlParameter("@TakeAddress",us.TakeAddress),
    //                                new SqlParameter("@DetailsPrice",us.DetailsPrice) };

    //            SqlCommand cmd = new SqlCommand(strSql, DbHelp.conn);
    //            cmd.Parameters.AddRange(p);
    //            cmd.Transaction = transaction;
    //            cmd.ExecuteNonQuery();
    //            #endregion

    //            #region 循环向订单添加商品
    //            foreach (Shipments item in ship)
    //            {
    //                strSql = "insert into [Shipments] values(@UserDeatialID,@ShipmentsDate," +
    //               "@ShimpentsPeople,@FlowerName,@FlowerColor,@FlowerSize,@FlowerPicUrl,@FlowerPrice,@DetailsNumber,@ShimpentsState)";
    //                SqlParameter[] parameter = {new SqlParameter("@UserDeatialID",us.UserDeatialID),
    //                                                new SqlParameter("@ShipmentsDate",item.ShipmentsDate),
    //                                                new SqlParameter("@ShimpentsPeople",item.ShimpentsPeople),
    //                                                new SqlParameter("@FlowerName",item.FlowerName),
    //                                                new SqlParameter("@FlowerColor",item.FlowerColor),
    //                                                new SqlParameter("@FlowerSize",item.FlowerSize),
    //                                                new SqlParameter("@FlowerPicUrl",item.FlowerPicUrl),
    //                                                new SqlParameter("@FlowerPrice",item.FlowerPrice),
    //                                                new SqlParameter("@DetailsNumber",item.DetailsNumber),
    //                                                new SqlParameter("@ShimpentsState",item.ShimpentsState) };
    //                cmd.CommandText = strSql;
    //                cmd.Parameters.Clear();
    //                cmd.Parameters.AddRange(parameter);
    //                cmd.Transaction = transaction;
    //                cmd.ExecuteNonQuery();
    //            }
    //            #endregion

    //            transaction.Commit();
    //            return 1;
    //        }
    //        catch 
    //        {
    //            transaction.Rollback();
    //            return 0;
    //        }
    //        finally
    //        {
    //            DbHelp.conn.Close();
    //        }
    //    }
    //}
}
