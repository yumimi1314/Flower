using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
  public   class FlowerTypeBll
    {
        public static string InsertFlowerType(FlowerType ty)
        {
            string str = "";
            switch (FlowerTypeDal.InsertFlowerType(ty))
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
                    str = "成功添加新用户";
                    break;
            }
            return str;
        }
        public static List<FlowerType> GetFlowerType()
        {
            return FlowerTypeDal.GetFLowerType();
        }
         public static List<Colors> GetColor()
        {
            return FlowerTypeDal.GetColors();
        
        }
    }
    
     
}
