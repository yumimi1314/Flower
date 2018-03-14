using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Dal
{
  public   class FeedbackDal
    {
        /// <summary>
        /// 客户反馈，评价
        /// </summary>
        /// <param name="feed"></param>
        /// <returns></returns>
        public static int InsertFeedback(Feedback feed)
        {
            string str = "insert into Feedback(UserAccount,FeedDesc,FeedDay,FeedState) values(@UserAccount,@FeedDesc,@FeedDay,@FeedState)";
            SqlParameter[] p = { new SqlParameter("@UserAccount",feed.UserAccount),new SqlParameter("@FeedDesc",feed.FeedDesc),
            new SqlParameter("@FeedDay",feed.FeedDay),new SqlParameter ("@FeedState",feed.FeedState)};
            return DbHelp.ExecuteNonQuary(str,p);
        }
        /// <summary>
        /// 追加评论
        /// </summary>
        /// <param name="feed"></param>
        /// <returns></returns>
        public static int UpdateFeedback(Feedback feed)
        {
            string str = "update Feedback set FeedFollow=@FeedFollow ,FeedFollowTime=@FeedFollowTime ";
            SqlParameter[] p = {new SqlParameter("@FeedFollow",feed.FeedFollow),new SqlParameter("@FeedFollowTime",feed.FeedFollowTime) };
            return DbHelp.ExecuteNonQuary(str,p);
        }
    }
}
