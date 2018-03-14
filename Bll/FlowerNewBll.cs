using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
  public   class FlowerNewBll
    {
        public static string InsertFlowerNew(FlowerNew flo)
        {
            string str = "";
            switch (FlowerNewDal.InsertFlowerNew(flo))
            {
                case -2:
                    str = "数据库连接异常!请检查您的数据库或联系管理员";
                    break;
                case -1:
                    str = "数据操作异常！请检查输入的数据或联系管理员";
                    break;
                case 0:
                    str = "操作失败，请检查数据是否错误";
                    break;
                default:
                    str = "商品添加成功！";
                    break;
            }
            return str;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static List<FlowerNew> GetPagse(int i)
        {
            return FlowerNewDal.GetPage(i);
        }
        /// <summary>
        /// 查询数据总条数
        /// </summary>
        /// <returns></returns>
        public static int GetPageCount()
        {
            return FlowerNewDal.GetPageCount();
        }
        /// <summary>
        /// 状态
        /// </summary>
        /// <returns></returns>
        public static string UnderFlowerNew()
        {
            return "商品已下架";
        }
      /// <summary>
      /// 排序
      /// </summary>
      /// <returns></returns>
        public static List<FlowerNew> GetFlower()
        {
            return FlowerNewDal.GetOrderFLower();
        }
      /// <summary>
      /// 详细信息
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
        public static List<FlowerNew> GetFlowerId(int id)
        {
            return FlowerNewDal.GetWhereId(id);
        }
      /// <summary>
      /// 条件查询
      /// </summary>
      /// <param name="name"></param>
      /// <returns></returns>
        public static List<FlowerNew> GetWhereFlower(string name)
        {
            return FlowerNewDal.GetWhereFlower(name);
        }
    }
}
