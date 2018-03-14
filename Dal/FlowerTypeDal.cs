using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Dal
{
  public   class FlowerTypeDal
    {
        /// <summary>
        /// 品种类型
        /// </summary>
        /// <param name="ty"></param>
        /// <returns></returns>
        public static int InsertFlowerType(FlowerType ty)
        {
            string str = "insert into FlowerType values(@TypeName)";
            SqlParameter[] p = {new SqlParameter("@TypeName",ty.TypeName) };
            return DbHelp.ExecuteNonQuary(str,p);
        }
        public static List<FlowerType> GetFLowerType()
        {
            List<FlowerType> ty = new List<FlowerType>();
            string str = "select * from FlowerType";
            SqlDataReader dr = DbHelp.ExecuteDataReader(str);
            FlowerType flo = null;
            while (dr.Read())
            {
                flo = new FlowerType();
                flo.TypeName = dr["TypeName"] as string;
                flo.TypeID =(int) dr["TypeID"];
                ty.Add(flo);
            }
            dr.Close();
            return ty;
        }
      /// <summary>
      /// 颜色
      /// </summary>
      /// <returns></returns>
        public static List<Colors> GetColors()
        {
            List<Colors> co = new List<Colors>();
            string str = "select * from Colors";
            SqlDataReader dr = DbHelp.ExecuteDataReader(str);
            while (dr.Read())
            {
                co.Add(new Colors() { ID = (int)dr["ColorID"], ColorName = dr["ColorName"] as string });
            }
            dr.Close();
            return co;
        }
    }
}
