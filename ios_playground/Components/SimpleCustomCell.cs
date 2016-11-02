using System;
using Foundation;
using UIKit;

namespace ios_playground
{
	public partial class SimpleCustomCell : UITableViewCell
	{
		protected SimpleCustomCell(IntPtr handle) : base(handle)
		{
		}

		public SimpleCustomCell() : base()
		{
		}

		//update row with current data
		public void UpdateCell(Player data)
		{
			Name.Text = data.Name;
			Club.Text = data.Club;
			Country.Text = data.Country;
		}
	}
}