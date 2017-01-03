using System;
using System.Collections.Generic;

namespace ios_playground
{
	public class SoccerClubModel
	{
		private List<string> players;
		private string name;

		public SoccerClubModel(string name)
		{
			this.name = name;
			players = new List<string>();
		}

		public string Name { 
			get { return this.name;}
		}

		public List<string> Players
		{
			get { return this.players; }
			set { this.players = value;}
		}
	}
}
