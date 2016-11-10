using System;
using System.Collections.Generic;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace ios_playground
{
	public class SimpleSource : UITableViewSource
	{
		List<Player> datas;
		NSString CellIdentifier = new NSString("Custom_Cell");
		WelcomeController _controller;

		public SimpleSource(WelcomeController _controller, List<Player> datas)
		{
			this.datas = datas;
			this._controller = _controller;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return datas.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			Player single_data = this.datas[indexPath.Row];
			//use this for Custom UITableViewCell from nib
			SimpleCustomCell cell = tableView.DequeueReusableCell(CellIdentifier) as SimpleCustomCell;
			//use this for simple UITableViewCell
			//UITableViewCell cell = new SimpleCustomCell(CellIdentifier);


			if (cell == null)
			{
				cell = new SimpleCustomCell();
				var views = NSBundle.MainBundle.LoadNib("SimpleCustomCell", cell, null);
				cell = Runtime.GetNSObject(views.ValueAt(0)) as SimpleCustomCell;
			 	//use this for simple UITableViewCell
				//new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); 
			}


			//use this for Custom UITableViewCell from nib
			cell.UpdateCell(single_data);

			/*
			 * use this for simple UITableViewCell
			cell.TextLabel.Text = single_data.Name;
			cell.DetailTextLabel.Text = single_data.Club;
			*/
			return cell;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			Player single_data = this.datas[indexPath.Row];
			_controller.PerformSegue(single_data.Country, _controller);
		}
	}
}
