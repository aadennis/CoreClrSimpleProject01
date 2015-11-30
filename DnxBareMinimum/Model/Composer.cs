using System.Collections.Generic;

namespace Model {
	
	public class Composer {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public LifeSpan LifeDates  { get; set; }
		public List<Song> Songs {get;set;}
	}
}