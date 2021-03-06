using System.Collections.Generic;

namespace heal_fit.Models
{
	public class Account
	{
		public int ID {get; set;}
		public string Email {get; set;}
		public string Pseudo {get; set;}
		public string Password {get; set;}
		public IEnumerable<Profile> Profiles {get; set;}
	}
}