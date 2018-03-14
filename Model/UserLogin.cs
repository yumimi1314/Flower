using System;
namespace Model
{
    public class UserLogin
    {
        public string UserAccount { get; set; }
        public string USerPassword { get; set; }
        public string UserName { get; set; }
        public string  UserSex { get; set; }
        public UserLogin() { }
        public UserLogin(string UserAccount, string USerPassword, string UserName,string UserSex) {
            this.UserAccount = UserAccount;
            this.UserName = UserName;
            this.USerPassword = USerPassword;
            this.UserSex = UserSex;
        }
    }
}
