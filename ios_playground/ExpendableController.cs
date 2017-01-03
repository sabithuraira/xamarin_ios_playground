using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace ios_playground
{
    public partial class ExpendableController : UIViewController
    {
		List<SoccerClubModel> datas = new List<SoccerClubModel>();
		
        public ExpendableController (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SoccerClubModel barcelona = new SoccerClubModel("Barcelona");
			barcelona.Players = new List<string>(new string[] { "Lionel Messi", "Andres Iniesta", "Luis Suarez", "Neymar" });

			SoccerClubModel realmadrid = new SoccerClubModel("Real Madrid");
			realmadrid.Players = new List<string>(new string[] { "Christiano Ronaldo", "Sergio Ramos" });

			SoccerClubModel m_u = new SoccerClubModel("Manchester United");
			m_u.Players = new List<string>(new string[] { "Zlatan Ibrahimovic", "Wayne Rooney" });

			this.datas.Add(barcelona);
			this.datas.Add(realmadrid);
			this.datas.Add(m_u);
			this.tableExpend.Source = new ExpendableSource(this.tableExpend, datas);
		}
    }
}