using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
   public  class FeedbackBll
    {
        public static string InsertFeedback(Feedback feed)
        {
            string str = "";
            switch (FeedbackDal.InsertFeedback(feed))
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
                    str = "评价成功！";
                    break;
            }
            return str;
        }
        public static string UpdateFeedback(Feedback feed)
        {
            string str = "";
            switch (FeedbackDal.UpdateFeedback(feed))
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
                    str = "追加成功！";
                    break;
            }
            return str;
        }
    }
}
