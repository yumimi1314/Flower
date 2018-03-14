using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Dal
{
    public class FlowerNewDal
    {
		/// <summary>
        /// 添加新商品
        /// </summary>
        /// <param name="flo"></param>
        /// <returns></returns>
		public static int InsertFlowerNew(FlowerNew flo)
        {
            string str = "Insert into FlowerNew values(@FlowerName,@FlowerMaterials,@TypeID,@FlowerColor,@FlowerSize,@FlowerPicUrl,@FlowerPrice,@FlowerNum,@FlowerLang,@FlowerDesc,@FlowerState)";
            SqlParameter[] p = { new SqlParameter("@FlowerName",flo.FlowerName), new SqlParameter("@FlowerMaterials",flo.FlowerMaterials), new SqlParameter("@TypeID",flo.TypeID),
             new SqlParameter("@FlowerColor",flo.FlowerColor), new SqlParameter("@FlowerSize",flo.FlowerSize), new SqlParameter("@FlowerPicUrl",flo.FlowerPicUrl),
             new SqlParameter("@FlowerPrice",flo.FlowerPrice), new SqlParameter("@FlowerNum",flo.FlowerNum),new SqlParameter("@FlowerLang",flo.FlowerLang),
            new SqlParameter("@FlowerDesc",flo.FlowerDesc),new SqlParameter("@FlowerState",flo.FlowerState)};
            return DbHelp.ExecuteNonQuary(str,p);
        }
		/// <summary>
        /// 修改状态，是否下架
        /// </summary>
        /// <param name="flower"></param>
        /// <returns></returns>
        public static int UnderFlowerNew()
        {
            string sr = "是";
            string str = "update FlowerNew set FlowerState=@FlowerState";//默认状态否
            SqlParameter[] p = { new SqlParameter("@FlowerState", sr) };
            return DbHelp.ExecuteNonQuary(str,p);
        }
        /// <summary>
        /// 查询所有的商品
        /// </summary>
        /// <param name="old"></param>
        /// <returns></returns>
        public static List<FlowerNew> GetFlowerNew(string str)
        {
           
            List<FlowerNew> flo = new List<FlowerNew>();
            SqlDataReader dr = DbHelp.ExecuteDataReader(str);
            FlowerNew flower = null;
            while (dr.Read())
            {
                flower = new FlowerNew();
                flower.FlowerColor = dr["FlowerColor"] as string;
                flower.FlowerDesc = dr["FlowerDesc"] as string;
                flower.FlowerID=(int)dr["FlowerID"];
                flower.FlowerLang=dr["FlowerLang"]as string;
                flower.FlowerMaterials=dr["FlowerMaterials"] as string;
                flower.FlowerName=dr["FlowerName"] as string;
                flower.FlowerNum=(int)dr["FlowerNum"];
                flower.FlowerPicUrl=dr["FlowerPicUrl"] as string;
                flower.FlowerPrice=(decimal)dr["FlowerPrice"];
                flower.FlowerSize=dr["FlowerSize"]as string;
                flower.FlowerState=dr["FlowerState"] as string;
                flower.TypeID=(int)dr["TypeID"];
                flo.Add(flower);
            }
            dr.Close();
            return flo;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static List<FlowerNew> GetPage(int i)
        {
            int start = ((i - 1) * 9 + 1);
            string str = "select* from(select ROW_NUMBER() over(order by FlowerID) as RowID, *from FlowerNew) as b where b.RowID between "+start+" and "+i*9;
            return GetFlowerNew(str);
        }
        public static int GetPageCount()
        {
            string str = "select count(*) from [FlowerNew]";
            return (int)DbHelp.ExecuteScalar(str);
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <returns></returns>
        public static List<FlowerNew> GetOrderFLower()
        {
            string str = "select * from FlowerNew where FlowerNum>0 order by FlowerPrice";
            return GetFlowerNew(str);
        }
        /// <summary>
        /// 条件
        /// 过滤
        /// </summary>
        /// <returns></returns>
        public static List<FlowerNew> GetWhereFlower(string name)
        {
            string str = "select * from FlowerNew where FlowerName like'%"+name+"%'";
            return GetFlowerNew(str);
        }
        public static List<FlowerNew> GetWhereId(int id)
        {
            string str = "select * from FlowerNew where FlowerID="+id;
            return GetFlowerNew(str);
        }
        /// <summary>
        ///类型查询
        ///子查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<FlowerNew> GetSonFlower(string name)
        {
            string str = "select * from FlowerNew where TypeID=(select TypeID from  FlowerType where TypeName='"+name+"')";
            return GetFlowerNew(str);
        }
    }
}
