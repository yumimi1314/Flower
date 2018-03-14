using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Dal
{
   public  class UserLoginDal
    {
        /// <summary>
        /// 新用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int InsertUserLogin(UserLogin user)
        {
            string str = "insert into UserLogin values(@UserAccount,@USerPassword,@UserName,@UserSex)";
            SqlParameter[] p = { new SqlParameter("@UserAccount",user.UserAccount), new SqlParameter("@USerPassword",user.USerPassword),
            new SqlParameter("@UserName",user.UserName),
            new SqlParameter("@UserSex",user.UserSex)};
            return DbHelp.ExecuteNonQuary(str,p);
        }
        /// <summary>
        /// 查看购物车
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<Details> GetDetails(UserLogin user)
        {
            string str = "select d.*from Details d join UserLogin u  on d.UserAccount = u.UserAccount where u.UserAccount = @UserName,e and u.UserPassword=@UserPassword  and PayState=0";
            List<Details> details = new List<Details>();
                SqlParameter[] p = { new SqlParameter("@UserName",user.UserAccount),new SqlParameter("@UserPassword", user.USerPassword) };
                SqlDataReader dr = DbHelp.ExecuteDataReader(str,p);
            Details da = null;
            while (dr.Read())
            {
                da = new Details();
                da.DetailsID =(int) dr["DetailsID"];
                da.ID = (int)dr["ID"];
                da.FlowerName = dr["FlowerName"] as string;
                da.FlowerColor = dr["FlowerColor"] as string;
                da.DetailsNumber = (int)dr["DetailsNumber"];//数量
                da.FlowerPrice =(float) dr["FlowerPrice"];//单价li
                da.UserAccount = dr["UserAccount"] as string;//账户
                da.FlowerPicUrl = dr["FlowerPrice"] as string;
                da.FlowerSize = dr["FlowerSize"] as string;
                da.Discount =(decimal) dr["Discount"];
                da.PayState = (int)dr["PayState"];
                da.PayDesc = dr["DetailsPrice"] as string;
                details.Add(da);
            }
            dr.Close();
            return details;
        }
       /// <summary>
       /// 登录
       /// </summary>
       /// <param name="acc"></param>
       /// <param name="where"></param>
       /// <param name="password"></param>
       /// <returns></returns>
        public static List<UserLogin> GetLogin(string where = null)
        {
            string str = "select * from UserLogin"+where;
            List<UserLogin> lo = new List<UserLogin>();
            SqlDataReader dr = DbHelp.ExecuteDataReader(str);
            if (dr != null)
            {
                while (dr.Read())
                {
                    lo.Add(new UserLogin(dr["UserAccount"] as string, dr["UserName"] as string, dr["USerPassword"] as string, dr["UserSex"]  as string));
                }
                dr.Close();
            }
           
            return lo;
        }

    }
}
