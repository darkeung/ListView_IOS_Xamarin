using Foundation;
using System;
using UIKit;

namespace wk3
{
    public partial class SessionsViewController : UITableViewController

    {
        SessionData[] sessions = new SessionData[3];
        public SessionsViewController (IntPtr handle) : base (handle)
        {
           
             {

                SessionData a = new SessionData("1", "Session Title1", "speaker1", "desc 1", DateTime.Today, true);
                SessionData b = new SessionData("1", "Session Title1", "speaker1", "desc 1", DateTime.Today, true);
                SessionData c = new SessionData("1", "Session Title1", "speaker1", "desc 1", DateTime.Today, true);
                sessions[0] = a;
                sessions[1] = b;
                sessions[2] = c;



            };
                


        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView.Source = new TableViewSource(sessions);

        }


    }
}