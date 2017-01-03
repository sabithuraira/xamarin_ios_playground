using System;
using System.Collections.Generic;
using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace ios_playground
{
	public class ExpendableSource : UITableViewSource
	{
		List<SoccerClubModel> datas;
		NSString childIdentifier = new NSString("CellChild");
		UITableView parentTable;

		private bool[] _isSectionOpen;
		private EventHandler _buttonClick;

		public ExpendableSource(UITableView parentTable,List<SoccerClubModel> datas)
		{
			this.datas = datas;
			this.parentTable = parentTable;

			_isSectionOpen = new bool[datas.Count];

			_buttonClick = (sender, e) =>
			{
				var button = sender as UIButton;
				var section = button.Tag;
				_isSectionOpen[(int)section] = !_isSectionOpen[(int)section];

				parentTable.ReloadData();
				var paths = new NSIndexPath[RowsInSection(parentTable, section)];
				for (int i = 0; i < paths.Length; i++)
				{
					paths[i] = NSIndexPath.FromItemSection(i, section);
				}

				parentTable.ReloadRows(paths, UITableViewRowAnimation.Automatic);
			};
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return datas.Count;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return _isSectionOpen[(int)section] ? datas[(int)section].Players.Count : 0;
		}


		public override nfloat GetHeightForHeader(UITableView tableView, nint section)
		{
			return 44f;
		}

		public override nfloat EstimatedHeightForHeader(UITableView tableView, nint section)
		{
			return 44f;
		}

		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			UIView view = CustomView(datas[(int)section].Name, (int)section);
			return view;
		}

		public UIView CustomView(string caption,nint tag)
		{
			UIView view = new UIView(new System.Drawing.RectangleF(0, 0, 320, 20));
			view.BackgroundColor = UIColor.White;

			UILabel label = new UILabel();
			label.Font = UIFont.FromName("Helvetica-Bold", 16f);
			label.Frame = new System.Drawing.RectangleF(5, 10, 315, 20);
			label.Text = caption;
			view.AddSubview(label);

			UIButton hiddenButton = new UIButton(view.Bounds);
			hiddenButton.Tag = tag;
			hiddenButton.TouchUpInside += _buttonClick;
			view.AddSubview(hiddenButton);

			return view;
		}

		private UIButton HiddenButton(CGRect frame, nint tag)
		{
			var button = new UIButton(frame);
			button.Tag = tag;
			button.TouchUpInside += _buttonClick;
			return button;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(childIdentifier);
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, childIdentifier);

			cell.TextLabel.Text = datas[indexPath.Section].Players[indexPath.Row];
			cell.DetailTextLabel.Text = datas[indexPath.Section].Name;

			return cell;

		}
	}
}
