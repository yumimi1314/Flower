using System;
namespace Model
{
    public class Feedback
    {
        public int FeedID { get; set; }
        public string UserAccount { get; set; }
        public string FeedDesc { get; set; }
        public DateTime FeedDay { get; set; }
        public string FeedFollow { get; set; }
        public DateTime FeedFollowTime { get; set; }
        public string FeedState { get; set; }
    }
}
