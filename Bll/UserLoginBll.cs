using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
    public class UserLoginBll
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public static string InsertUserLogin(UserLogin us)
        {
            us.USerPassword = Encryption(us.USerPassword);
            string str = "";
            switch (UserLoginDal.InsertUserLogin(us))
            {
                case 1:
                   str = "注册成功";
                    break;
                default:
                    str = "注册失败";
                    break;
            }
            return str;
        }
        /// <summary>
        /// 查询是否存在相同的邮箱
        /// </summary>
        /// <param name="username"></param>
        /// <param name="Acc"></param>
        /// <param name="us"></param>
        /// <returns></returns>
        public static string SelectUser(string Acc, UserLogin us)
        {
            string str = " where UserAccount='"+Acc+"'";
            List<UserLogin> login = UserLoginDal.GetLogin(str);
            if (login.Count!=0)
            {
                str = "已存在相同的邮箱";
                return str;
            }
            return InsertUserLogin(us);
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string Encryption(string pwd)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd);
            bytes = md5.ComputeHash(bytes);
            return BitConverter.ToString(bytes);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Acc"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static int GetUser(string Acc,string pwd)
        {
            int str=-1 ;
            pwd = Encryption(pwd);
            if (UserLoginDal.GetLogin().Where(c=>c.UserAccount==Acc).ToList().Count==0)
            {
                str=0;//用户名不存在
                return str;
            }  
            List<UserLogin> mer = UserLoginDal.GetLogin(" where UserAccount='" + Acc + "' and  USerPassword='" + pwd + "'");
           if (mer.Count==0)
            {
                str = 1;//密码错误
                return str;
            }
            return str;//登录成功
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="Acc"></param>
        /// <returns></returns>
        public static string GetUser(string Acc)
        {
           
            UserLogin us = new UserLogin();
            if (UserLoginDal.GetLogin().Where(c => c.UserAccount == Acc).ToList().Count == 0)
            {
                return "用户名不存在";
            }
            return "信息已发送至邮箱，请注意查收";
        }
        public static List<Details> GetDerails(UserLogin us)
        {
            us.USerPassword = Encryption(us.USerPassword);
            return UserLoginDal.GetDetails(us);
        }
    }
}
