namespace ios_playground
{
	public class Player
	{
		private string name;
		private string club;
		private string country;

		public Player(string name,string club, string country)
		{
			this.name = name;
			this.club = club;
			this.country = country;
		}

		public string Name
		{
			get { return this.name; }
		}

		public string Club
		{
			get { return this.club; }
		}

		public string Country 
		{ 
			get { return this.country; }
		}
	}
}
