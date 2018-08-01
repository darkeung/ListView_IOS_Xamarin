using System;
using Foundation;
using UIKit;

namespace wk3
{
    public class TableViewSource : UITableViewSource {
         SessionData[] TableItems;
        string CellIdentifier = "SessionCell";
        public TableViewSource (SessionData[] sessions)
        {
            TableItems = sessions;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            SessionData item = TableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }
            else
            {
                if (item != null)
                {
                    cell.TextLabel.Text = item.ToString();
                }
            }

            return cell;
        }
    }


}
