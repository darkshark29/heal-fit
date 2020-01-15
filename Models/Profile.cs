using System.ComponentModel.DataAnnotations;

namespace heal_fit.Models
{
	public class Profile
	{
		public int ID {get; set;}
		public string FirstName {get; set;}
		public string LastName {get; set;}
		public int Age {get; set;}
		public string ImageUrl {get; set;}
		public int AccountID {get; set;}
	}
}