using System;
using Foundation;
using UIKit;
namespace wk3
{
    public class SessionData
    {
        public SessionData(string v1, string v2, string v3, string v4, DateTime v5, bool v6)
        {
            this.SessionId = v1;
            this.SessionTitle = v2;
            this.SessionDescription = v3;
            this.SessionSpeaker = v4;
            this.SessionDate = v5;
            this.IsTechnicalflag = v6;
        }

        public string SessionId { get; set; }
        public string SessionTitle { get; set; }
        public string SessionDescription { get; set; }
        public string SessionSpeaker { get; set; }
        public DateTime SessionDate { get; set; }
        public bool IsTechnicalflag { get; set; }


        public override string ToString()
        {
            return string.Format("           {0}, {1}", SessionId, SessionTitle);
        }

      
    }

}
